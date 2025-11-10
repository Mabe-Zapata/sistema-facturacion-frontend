using Microsoft.JSInterop;
using System.Text.Json;

// Make sure to clear the Session if stored. As the values are overrided by the session value automatially.
// If any Changes  to values thne the priority will move to the default values rather than the session.
public class AppState
{
    public string ColorTheme { get; set; } = "light";                   // light, dark
    public string Direction { get; set; } = "ltr";                      // ltr, rtl
    public string NavigationStyles { get; set; } = "vertical";          // vertical, horizontal
    public string MenuStyles { get; set; } = "";                        // menu-click, menu-hover, icon-click, icon-hover
    public string LayoutStyles { get; set; } = "doublemenu";            // doublemenu, detached, icon-overlay, icontext-menu, closed-menu, default-menu
    public string PageStyles { get; set; } = "flat";                    // regular, classic, modern, flat
    public string WidthStyles { get; set; } = "fullwidth";              // default, fullwidth, boxed
    public string MenuPosition { get; set; } = "fixed";                 // fixed, scrollable
    public string HeaderPosition { get; set; } = "fixed";               // fixed, scrollable
    public string MenuColor { get; set; } = "transparent";              // light, dark, color, gradient, transparent
    public string HeaderColor { get; set; } = "transparent";            // light, dark, color, gradient, transparent
    public string ThemePrimary { get; set; } = "";                      // '106, 91, 204', '100, 149, 237', ...
    public string ThemeBackground { get; set; } = "";                   // add rgb values like '49, 63, 141' and same for ThemeBackground1
    public string ThemeBackground1 { get; set; } = "";
    public string BackgroundImage { get; set; } = "";                   // bgimg1, bgimg2, bgimg3, bgimg4, bgimg5
    public MainMenuItems? currentItem { get; set; } = null;

    public bool IsDifferentFrom(AppState other)
    {
        return ColorTheme != other.ColorTheme ||
            Direction != other.Direction ||
            NavigationStyles != other.NavigationStyles ||
            MenuStyles != other.MenuStyles ||
            LayoutStyles != other.LayoutStyles ||
            PageStyles != other.PageStyles ||
            WidthStyles != other.WidthStyles ||
            MenuPosition != other.MenuPosition ||
            HeaderPosition != other.HeaderPosition ||
            MenuColor != other.MenuColor ||
            HeaderColor != other.HeaderColor ||
            ThemePrimary != other.ThemePrimary ||
            ThemeBackground != other.ThemeBackground ||
            ThemeBackground1 != other.ThemeBackground1 ||
            BackgroundImage != other.BackgroundImage ||
            (currentItem != null ? !currentItem.Equals(other.currentItem) : other.currentItem != null);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;
        AppState other = (AppState)obj;

        return ColorTheme == other.ColorTheme &&
               Direction == other.Direction &&
               NavigationStyles == other.NavigationStyles &&
               MenuStyles == other.MenuStyles &&
               LayoutStyles == other.LayoutStyles &&
               PageStyles == other.PageStyles &&
               WidthStyles == other.WidthStyles &&
               MenuPosition == other.MenuPosition &&
               HeaderPosition == other.HeaderPosition &&
               MenuColor == other.MenuColor &&
               HeaderColor == other.HeaderColor &&
               ThemePrimary == other.ThemePrimary &&
               ThemeBackground == other.ThemeBackground &&
               ThemeBackground1 == other.ThemeBackground1 &&
               BackgroundImage == other.BackgroundImage &&
               Equals(currentItem, other.currentItem);
    }

    public override int GetHashCode() => base.GetHashCode();

    public void CopyFrom(AppState other)
    {
        ColorTheme = other.ColorTheme;
        Direction = other.Direction;
        NavigationStyles = other.NavigationStyles;
        MenuStyles = other.MenuStyles;
        LayoutStyles = other.LayoutStyles;
        PageStyles = other.PageStyles;
        WidthStyles = other.WidthStyles;
        MenuPosition = other.MenuPosition;
        HeaderPosition = other.HeaderPosition;
        MenuColor = other.MenuColor;
        HeaderColor = other.HeaderColor;
        ThemePrimary = other.ThemePrimary;
        ThemeBackground = other.ThemeBackground;
        ThemeBackground1 = other.ThemeBackground1;
        BackgroundImage = other.BackgroundImage;
        currentItem = other.currentItem;
    }

    public async Task InitializeFromSession(AppState sessionState, SessionService _sessionService)
    {
        var stored = await _sessionService.GetInitalAppStateFromSession();
        if (sessionState != null)
        {
            CopyFrom(sessionState);
        }
        else
        {
            if (stored == null)
            {
                await _sessionService.SetInitalAppStateToSession(this);
            }
        }
    }
}

public class StateService
{
    private const string LocalStorageKey = "app:state:v1";

    private readonly IJSRuntime _jsRuntime;
    private readonly SessionService _sessionService;
    private readonly AppState _currentState;
    private readonly ILogger<AppState> _logger;

    public AppState GetAppState() => _currentState;

    public event Action OnChange;
    public event Action? OnStateChanged;

    public StateService(IJSRuntime jsRuntime, SessionService sessionService, AppState appState, ILogger<AppState> logger)
    {
        _jsRuntime = jsRuntime;
        _sessionService = sessionService;
        _currentState = appState;
        OnChange = () => { };
        _logger = logger;
    }

    public async Task InitializeAsync()
    {
        try
        {
            var sessionState = await _sessionService.GetAppStateFromSession();
            var initialAppState = await _sessionService.GetInitalAppStateFromSession();
            if (initialAppState == null)
            {
                await _sessionService.SetInitalAppStateToSession(_currentState);
            }
            await _currentState.InitializeFromSession(sessionState, _sessionService);

            OnChange?.Invoke();
            NotifyStateChanged();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error initializing AppState");
        }
    }

    public async Task InitializeLandingAppState()
    {
        var sessionState = await _sessionService.GetAppStateFromSession();
        _currentState.NavigationStyles = "horizontal";
        _currentState.MenuStyles = "menu-hover";
        await _currentState.InitializeFromSession(sessionState, _sessionService);
        NotifyStateChanged();
    }

    private async void NotifyStateChanged()
    {
        await _sessionService.SetAppStateToSession(_currentState);
        var json = JsonSerializer.Serialize(_currentState);
        await _jsRuntime.InvokeVoidAsync("interop.setLocalStorageItem", LocalStorageKey, json);
        OnStateChanged?.Invoke();
    }

    public async Task directionFn(string val)
    {
        _currentState.Direction = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "dir", val);
        NotifyStateChanged();
    }

    public Task setCurrentItem(MainMenuItems val)
    {
        _currentState.currentItem = val;
        return Task.CompletedTask;
    }

    public async Task colorthemeFn(string val, bool stateClick)
    {
        _currentState.ColorTheme = val;
        if (stateClick)
        {
            _currentState.ThemeBackground = "";
            _currentState.ThemeBackground1 = "";
        }

        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-theme-mode", val);
        if (stateClick)
        {
            if (val == "light")
            {
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-menu-styles", "transparent");
                await menuColorFn("transparent");
                await headerColorFn("transparent");
            }
            else
            {
                await menuColorFn(val);
            }
        }

        await _jsRuntime.InvokeVoidAsync("interop.removeCssVariable", "--body-bg-rgb");
        await _jsRuntime.InvokeVoidAsync("interop.removeCssVariable", "--body-bg-rgb2");
        await _jsRuntime.InvokeVoidAsync("interop.removeCssVariable", "--light-rgb");
        await _jsRuntime.InvokeVoidAsync("interop.removeCssVariable", "--form-control-bg");
        await _jsRuntime.InvokeVoidAsync("interop.removeCssVariable", "--input-border");
        await _jsRuntime.InvokeVoidAsync("interop.removeCssVariable", "--gray-3");
        NotifyStateChanged();
    }

    int screenSize = 1268;

    public async Task navigationStylesFn(string val, bool stateClick)
    {
        if (string.IsNullOrEmpty(_currentState.MenuStyles) && val == "horizontal")
        {
            _currentState.MenuStyles = "menu-click";
            _currentState.LayoutStyles = "";
            await menuStylesFn("menu-click");
        }
        if (stateClick && val == "vertical")
        {
            _currentState.MenuStyles = "";
            _currentState.LayoutStyles = "doublemenu";
        }

        _currentState.NavigationStyles = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-layout", val);

        if (val == "horizontal")
        {
            await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-vertical-style");
        }
        else
        {
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-layout", val);
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-vertical-style", "doublemenu");
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "double-menu-open");
            await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-nav-style");
        }

        screenSize = await _jsRuntime.InvokeAsync<int>("interop.inner", "innerWidth");

        if (screenSize < 992)
        {
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "close");
        }
        NotifyStateChanged();
    }

    public async Task layoutStylesFn(string val)
    {
        _currentState.LayoutStyles = val;
        _currentState.MenuStyles = "";
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-nav-style");

        switch (val)
        {
            case "default-menu":
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-vertical-style", "overlay");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-layout", "vertical");
                if (await _jsRuntime.InvokeAsync<int>("interop.inner", "innerWidth") > 992)
                {
                    await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-toggled");
                }
                break;
            case "closed-menu":
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-vertical-style", "closed");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-layout", "vertical");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "close-menu-close");
                break;
            case "detached":
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-vertical-style", "detached");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-layout", "vertical");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "detached-close");
                break;
            case "icontext-menu":
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-vertical-style", "icontext");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-layout", "vertical");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "icon-text-close");
                break;
            case "icon-overlay":
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-vertical-style", "overlay");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-layout", "vertical");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "icon-overlay-close");
                break;
            case "doublemenu":
                var isdoubleMenuActive = await _jsRuntime.InvokeAsync<bool>("interop.isEleExist", ".double-menu-active");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-vertical-style", "doublemenu");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-layout", "vertical");
                await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "double-menu-open");
                if (!isdoubleMenuActive)
                {
                    await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "double-menu-close");
                }
                break;
        }

        screenSize = await _jsRuntime.InvokeAsync<int>("interop.inner", "innerWidth");

        if (screenSize < 992)
        {
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "close");
        }
        NotifyStateChanged();
    }

    public async Task menuStylesFn(string val)
    {
        _currentState.LayoutStyles = "";
        _currentState.MenuStyles = val;
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-vertical-style");
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-hor-style");
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-nav-style", val);

        screenSize = await _jsRuntime.InvokeAsync<int>("interop.inner", "innerWidth");
        if (screenSize < 992)
        {
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "close");
        }
        else
        {
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", $"{val}-closed");
        }

        NotifyStateChanged();
    }

    public async Task pageStyleFn(string val)
    {
        _currentState.PageStyles = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-page-style", val);
        NotifyStateChanged();
    }

    public async Task widthStylessFn(string val)
    {
        _currentState.WidthStyles = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-width", val);
        NotifyStateChanged();
    }

    public async Task menuPositionFn(string val)
    {
        _currentState.MenuPosition = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-menu-position", val);
        NotifyStateChanged();
    }

    public async Task headerPositionFn(string val)
    {
        _currentState.HeaderPosition = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-header-position", val);
        NotifyStateChanged();
    }

    public async Task menuColorFn(string val)
    {
        _currentState.MenuColor = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-menu-styles", val);
        NotifyStateChanged();
    }

    public async Task headerColorFn(string val)
    {
        _currentState.HeaderColor = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-header-styles", val);
        NotifyStateChanged();
    }

    public async Task themePrimaryFn(string val)
    {
        _currentState.ThemePrimary = val;
        await _jsRuntime.InvokeVoidAsync("interop.setCssVariable", "--primary-rgb", val);
        NotifyStateChanged();
    }

    public async Task themeBackgroundFn(string val, string val2, bool stateClick)
    {
        _currentState.ThemeBackground = val;
        _currentState.ThemeBackground1 = val2;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-theme-mode", "dark");
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-header-styles", "dark");
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-menu-styles", "dark");
        _currentState.ColorTheme = "dark";
        if (stateClick)
        {
            _currentState.MenuColor = "dark";
            _currentState.HeaderColor = "dark";
        }
        await _jsRuntime.InvokeVoidAsync("interop.setCssVariable", "--body-bg-rgb", val);
        await _jsRuntime.InvokeVoidAsync("interop.setCssVariable", "--body-bg-rgb2", val2);
        await _jsRuntime.InvokeVoidAsync("interop.setCssVariable", "--light-rgb", val2);
        await _jsRuntime.InvokeVoidAsync("interop.setCssVariable", "--form-control-bg", $"rgb({val2})");
        await _jsRuntime.InvokeVoidAsync("interop.setCssVariable", "--input-border", "rgba(255,255,255,0.1)");
        await _jsRuntime.InvokeVoidAsync("interop.setCssVariable", "--gray-3", $"rgb({val2})");
        NotifyStateChanged();
    }

    public async Task backgroundImageFn(string val)
    {
        _currentState.BackgroundImage = val;
        await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-bg-img", val);
        NotifyStateChanged();
    }

    public async Task reset()
    {
        _currentState.ColorTheme = "light";
        _currentState.Direction = "ltr";
        _currentState.NavigationStyles = "vertical";
        _currentState.MenuStyles = "";
        _currentState.LayoutStyles = "doublemenu";
        _currentState.PageStyles = "flat";
        _currentState.WidthStyles = "fullwidth";
        _currentState.MenuPosition = "fixed";
        _currentState.HeaderPosition = "fixed";
        _currentState.MenuColor = "transparent";
        _currentState.HeaderColor = "transparent";
        _currentState.ThemePrimary = "";
        _currentState.ThemeBackground = "";
        _currentState.ThemeBackground1 = "";
        _currentState.BackgroundImage = "";

        await _jsRuntime.InvokeVoidAsync("interop.clearAllLocalStorage");
        await _jsRuntime.InvokeVoidAsync("interop.setclearCssVariables");

        await colorthemeFn("light", false);

        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "style");

        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-nav-style");
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-menu-position");
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-header-position");
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-page-style");
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-width");

        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-bg-img");

        await directionFn("ltr");

        await layoutStylesFn("doublemenu");

        await widthStylessFn("fullwidth");

        await navigationStylesFn("vertical", false);

        await menuColorFn("transparent");

        var innerWidth = await _jsRuntime.InvokeAsync<int>("interop.inner", "innerWidth");
        if (innerWidth < 992)
        {
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "close");
        }
        else
        {
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "double-menu-close");
        }

        await headerColorFn("transparent");

        await _sessionService.DeleteAppStateFromSession();

        NotifyStateChanged();
    }

    public async Task Landingreset()
    {
        await _jsRuntime.InvokeVoidAsync("interop.clearAllLocalStorage");

        await colorthemeFn("light", false);

        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "style");

        await directionFn("ltr");
        await menuColorFn("transparent");
        _currentState.ThemePrimary = "";
        await _sessionService.DeleteAppStateFromSession();
        NotifyStateChanged();
    }

    public async Task retrieveFromLocalStorage()
    {
        string direction = _currentState.Direction;
        await directionFn(direction);
        string navstyles = _currentState.NavigationStyles;
        await navigationStylesFn(navstyles, false);
        string pageStyle = _currentState.PageStyles;
        await pageStyleFn(pageStyle);
        string widthStyles = _currentState.WidthStyles;
        await widthStylessFn(widthStyles);
        string Vyzormenuposition = _currentState.MenuPosition;
        await menuPositionFn(Vyzormenuposition);
        string Vyzorheaderposition = _currentState.HeaderPosition;
        await headerPositionFn(Vyzorheaderposition);
        string Vyzorcolortheme = _currentState.ColorTheme;
        await colorthemeFn(Vyzorcolortheme, false);
        string Vyzorbgimg = _currentState.BackgroundImage;
        if (!string.IsNullOrEmpty(Vyzorbgimg))
        {
            await backgroundImageFn(Vyzorbgimg);
        }
        string Vyzorbgcolor = _currentState.ThemeBackground;
        string Vyzorbgcolor1 = _currentState.ThemeBackground1;
        if (!string.IsNullOrEmpty(Vyzorbgcolor))
        {
            await themeBackgroundFn(Vyzorbgcolor, Vyzorbgcolor1, false);
            _currentState.ColorTheme = "dark";
        }
        string VyzorMenu = _currentState.MenuColor;
        await menuColorFn(VyzorMenu);
        string VyzorHeader = _currentState.HeaderColor;
        await headerColorFn(VyzorHeader);
        string VyzormenuStyles = _currentState.MenuStyles;
        string Vyzorverticalstyles = _currentState.LayoutStyles;
        if (string.IsNullOrEmpty(Vyzorverticalstyles))
        {
            await menuStylesFn(VyzormenuStyles);
        }
        else
        {
            await layoutStylesFn(Vyzorverticalstyles);
        }
        string VyzorprimaryRGB = _currentState.ThemePrimary;
        await themePrimaryFn(VyzorprimaryRGB);
    }

    public async Task retrieveFromLandingLocalStorage()
    {
        await navigationStylesFn("horizontal", false);
        _currentState.MenuStyles = "menu-hover";
        _currentState.LayoutStyles = "";
        await menuStylesFn("menu-hover");

        string direction = await _jsRuntime.InvokeAsync<string>("interop.getLocalStorageItem", "vyzordirection") ?? _currentState.Direction;
        await directionFn(direction);
        string Vyzorcolortheme = await _jsRuntime.InvokeAsync<string>("interop.getLocalStorageItem", "vyzorcolortheme") ?? _currentState.ColorTheme;
        await colorthemeFn(Vyzorcolortheme, false);
        string VyzorprimaryRGB = await _jsRuntime.InvokeAsync<string>("interop.getLocalStorageItem", "vyzorprimaryRGB") ?? _currentState.ThemePrimary;
        await themePrimaryFn(VyzorprimaryRGB);

        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-header-styles");
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-menu-styles");
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-page-style");
        await _jsRuntime.InvokeVoidAsync("interop.removeAttributeFromHtml", "data-width");

        var innerWidth = await _jsRuntime.InvokeAsync<int>("interop.inner", "innerWidth");
        if (innerWidth < 992)
        {
            await _jsRuntime.InvokeVoidAsync("interop.addAttributeToHtml", "data-toggled", "close");
        }

        NotifyStateChanged();
    }

    private async Task PersistState()
    {
        await Task.Delay(0);
        await _sessionService.SetAppStateToSession(_currentState);
        var json = JsonSerializer.Serialize(_currentState);
        await _jsRuntime.InvokeVoidAsync("interop.setLocalStorageItem", LocalStorageKey, json);
    }
}

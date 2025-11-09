window.interop = {

    // --- FUNCIONES QUE YA TENÍAS ---
    addAttributeToHtml: (name, value) => document.documentElement.setAttribute(name, value ?? ''),
    removeAttributeFromHtml: (name) => document.documentElement.removeAttribute(name),
    getAttributeToHtml: (name) => document.documentElement.getAttribute(name),

    setCssVariable: (k, v) => document.documentElement.style.setProperty(k, v),
    removeCssVariable: (k) => document.documentElement.style.removeProperty(k),

    clearAllLocalStorage: () => localStorage.clear(),
    setLocalStorageItem: (k, v) => localStorage.setItem(k, v),
    getLocalStorageItem: (k) => localStorage.getItem(k),

    inner: (prop) => window[prop],
    isEleExist: (sel) => !!document.querySelector(sel),

    applyPageStyleClass: () => {/* aquí tu lógica si necesitas agregar clases globales */ },

    updateScrollVisibility: (dotnetRef) => {
        const handler = () => dotnetRef.invokeMethodAsync('UpdateScrollVisibility', window.scrollY | 0);
        window.addEventListener('scroll', handler, { passive: true });
        handler(); // evaluar al inicio
    },

    scrollToTop: () => window.scrollTo({ top: 0, behavior: 'smooth' }),

    setclearCssVariables: () => {
        const st = document.documentElement.style;
        ['--body-bg-rgb', '--body-bg-rgb2', '--light-rgb', '--form-control-bg', '--input-border', '--gray-3', '--primary-rgb']
            .forEach(k => st.removeProperty(k));
    },

    // --- ¡¡AQUÍ EMPIEZAN LAS FUNCIONES QUE FALTABAN!! ---

    /**
     * Inicializa los tooltips de Bootstrap
     * Llamado por Switcher.razor
     */
    initializeTooltips: function () {
        const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]');
        const tooltipList = [...tooltipTriggerList].map((tooltipTriggerEl) => new bootstrap.Tooltip(tooltipTriggerEl));
    },

    /**
     * Registra el listener de scroll para el NavMenu
     * Llamado por NavMenu.razor (para SetStickyClass)
     */
    registerScrollListener: function (dotnetHelper) {
        window.addEventListener('scroll', function () {
            // Usamos (valor || 0) para manejar null/undefined
            // Usamos Math.floor() para quitar decimales y enviar un INT
            var scrollY = window.scrollY || window.pageYOffset || 0;
            var safeScrollY = Math.floor(scrollY);
            dotnetHelper.invokeMethodAsync("SetStickyClass", safeScrollY);
        });

        // Trigger inicial
        var scrollY = window.scrollY || window.pageYOffset || 0;
        var safeScrollY = Math.floor(scrollY);
        dotnetHelper.invokeMethodAsync("SetStickyClass", safeScrollY);
    },

    /**
     * Registra el listener de scroll para el MainHeader
     * Llamado por MainHeader.razor (para SetStickyClass1)
     */
    registerheaderScrollListener: function (dotnetHelper) {
        window.addEventListener('scroll', function () {
            var scrollY = window.scrollY || window.pageYOffset || 0;
            var safeScrollY = Math.floor(scrollY);
            dotnetHelper.invokeMethodAsync("SetStickyClass1", safeScrollY);
        });

        // Trigger inicial
        var scrollY = window.scrollY || window.pageYOffset || 0;
        var safeScrollY = Math.floor(scrollY);
        dotnetHelper.invokeMethodAsync("SetStickyClass1", safeScrollY);
    }

    // ... (aquí puedes agregar el resto de funciones que te falten,
    // como initializePopover, initCardRemove, etc., si también dan error)
};
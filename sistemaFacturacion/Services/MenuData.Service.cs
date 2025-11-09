public class MenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        // ───────────────────────────
        // ENCABEZADO PRINCIPAL
        // ───────────────────────────
        new MainMenuItems(menuTitle: "Main"),

        // Dashboard (opcional para landing interna)
        new MainMenuItems(
            type: "sub",
            title: "Dashboards",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M32 216H224' stroke='currentColor' stroke-width='16' stroke-linecap='round'/><rect x='40' y='56' width='80' height='112' rx='8' fill='none' stroke='currentColor' stroke-width='16'/><rect x='136' y='96' width='80' height='72' rx='8' fill='none' stroke='currentColor' stroke-width='16'/></svg>",
            selected: false, active: false, dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems(
                    path: "",
                    type: "link",
                    title: "Resumen",
                    selected: false, active: false, dirChange: false
                ),
            }
        ),

        // ───────────────────────────
        // SECCIÓN: GESTIONES
        // ───────────────────────────
        new MainMenuItems(menuTitle: "Gestiones"),

        new MainMenuItems(
            type: "sub",
            title: "Gestiones",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M40 64h176v128H40z' fill='none' stroke='currentColor' stroke-width='16'/> <path d='M40 104h176' stroke='currentColor' stroke-width='16'/></svg>",
            selected: false, active: false, dirChange: false,
            children: new MainMenuItems[]
            {
                // Gestión de Clientes
                new MainMenuItems(
                    path: "/dashboards/clientes",
                    type: "link",
                    title: "Gestión de Clientes",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><circle cx='96' cy='96' r='32' fill='none' stroke='currentColor' stroke-width='16'/><path d='M24 208a64 64 0 0 1 128 0' fill='none' stroke='currentColor' stroke-width='16'/></svg>",
                    selected: false, active: false, dirChange: false
                ),

                // Gestión de Productos (Seguros/Planes)
                new MainMenuItems(
                    path: "/dashboards/productos",
                    type: "link",
                    title: "Gestión de Productos",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect x='40' y='64' width='176' height='128' rx='8' fill='none' stroke='currentColor' stroke-width='16'/><path d='M40 104h176' stroke='currentColor' stroke-width='16'/></svg>",
                    selected: false, active: false, dirChange: false
                ),

                // Gestión de Usuarios
                new MainMenuItems(
                    path: "/dashboards/empleados",
                    type: "link",
                    title: "Gestión de Empleados",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><circle cx='128' cy='88' r='28' fill='none' stroke='currentColor' stroke-width='16'/><path d='M64 208a64 64 0 0 1 128 0' fill='none' stroke='currentColor' stroke-width='16'/></svg>",
                    selected: false, active: false, dirChange: false
                ),

                //Gestion de Lotes
                // Gestión de Lotes
            new MainMenuItems(
                 path: "/dashboards/lotes",
                 type: "link",
                 title: "Gestión de Lotes",
                 svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect x='36' y='56' width='184' height='144' rx='8' fill='none' stroke='currentColor' stroke-width='16'/><path d='M36 100h184M84 56v144M172 56v144' fill='none' stroke='currentColor' stroke-width='16' stroke-linecap='round'/></svg>",
             selected: false, active: false, dirChange: false
            ),

            }
        ),

        // ───────────────────────────
        // SECCIÓN: OPERACIONES
        // ───────────────────────────
        new MainMenuItems(menuTitle: "Operaciones"),

        new MainMenuItems(
            type: "sub",
            title: "Operaciones",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M48 72h160v48H48z' fill='none' stroke='currentColor' stroke-width='16'/><path d='M32 176h192' stroke='currentColor' stroke-width='16'/></svg>",
            selected: false, active: false, dirChange: false,
            children: new MainMenuItems[]
            {
                // Contratación de Seguros
                new MainMenuItems(
                    path: "",
                    type: "link",
                    title: "Contratación de Seguros",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><path d='M40 64l88-32 88 32v56a88 88 0 0 1-88 88A88 88 0 0 1 40 120Z' fill='none' stroke='currentColor' stroke-width='16'/></svg>",
                    selected: false, active: false, dirChange: false
                ),

                // Reembolsos
                new MainMenuItems(
                    path: "",
                    type: "link",
                    title: "Reembolsos",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><path d='M128 40v80l48-24' fill='none' stroke='currentColor' stroke-width='16'/><rect x='40' y='120' width='176' height='72' rx='8' fill='none' stroke='currentColor' stroke-width='16'/></svg>",
                    selected: false, active: false, dirChange: false
                ),
            }
        ),

        // ───────────────────────────
        // SECCIÓN: REPORTES
        // ───────────────────────────
        new MainMenuItems(menuTitle: "Reportes"),

        new MainMenuItems(
            type: "sub",
            title: "Reportes",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M40 200h176' stroke='currentColor' stroke-width='16'/><rect x='48' y='48' width='64' height='120' rx='8' fill='none' stroke='currentColor' stroke-width='16'/><rect x='144' y='96' width='64' height='72' rx='8' fill='none' stroke='currentColor' stroke-width='16'/></svg>",
            selected: false, active: false, dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems(
                    path: "",
                    type: "link",
                    title: "Reportes Generales",
                    selected: false, active: false, dirChange: false
                ),
                new MainMenuItems(
                    path: "",
                    type: "link",
                    title: "KPI & Métricas",
                    selected: false, active: false, dirChange: false
                ),
            }
        ),
            
        // (Opcional) Otras páginas base si quieres mantener
        // new MainMenuItems(menuTitle: "Pages"),
        // ...
    };

    public List<MainMenuItems> GetMenuData() => MenuData;
}

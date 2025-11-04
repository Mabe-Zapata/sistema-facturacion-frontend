public class MenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems(
            menuTitle: "Main"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Dashboards",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect> <path d='M133.66,34.34a8,8,0,0,0-11.32,0L40,116.69V216h64V152h48v64h64V116.69Z' opacity='0.2'></path> <line x1='16' y1='216' x2='240' y2='216' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line>  <polyline points='152 216 152 152 104 152 104 216' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><line x1='40' y1='116.69' x2='40' y2='216' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='216' y1='216' x2='216' y2='116.69' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><path d='M24,132.69l98.34-98.35a8,8,0,0,1,11.32,0L232,132.69' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>",
            badgeValue: "",
            badgeClass: "",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/dashboard/sales",
                    type: "link",
                    icon: "",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M54.46,201.54c-9.2-9.2-3.1-28.53-7.78-39.85C41.82,150,24,140.5,24,128s17.82-22,22.68-33.69C51.36,83,45.26,63.66,54.46,54.46S83,51.36,94.31,46.68C106.05,41.82,115.5,24,128,24S150,41.82,161.69,46.68c11.32,4.68,30.65-1.42,39.85,7.78s3.1,28.53,7.78,39.85C214.18,106.05,232,115.5,232,128S214.18,150,209.32,161.69c-4.68,11.32,1.42,30.65-7.78,39.85s-28.53,3.1-39.85,7.78C150,214.18,140.5,232,128,232s-22-17.82-33.69-22.68C83,204.64,63.66,210.74,54.46,201.54Z' opacity='0.2'></path><path d='M54.46,201.54c-9.2-9.2-3.1-28.53-7.78-39.85C41.82,150,24,140.5,24,128s17.82-22,22.68-33.69C51.36,83,45.26,63.66,54.46,54.46S83,51.36,94.31,46.68C106.05,41.82,115.5,24,128,24S150,41.82,161.69,46.68c11.32,4.68,30.65-1.42,39.85,7.78s3.1,28.53,7.78,39.85C214.18,106.05,232,115.5,232,128S214.18,150,209.32,161.69c-4.68,11.32,1.42,30.65-7.78,39.85s-28.53,3.1-39.85,7.78C150,214.18,140.5,232,128,232s-22-17.82-33.69-22.68C83,204.64,63.66,210.74,54.46,201.54Z' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><circle cx='96' cy='96' r='16' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle><circle cx='160' cy='160' r='16' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle><line x1='88' y1='168' x2='168' y2='88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Sales",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    icon: "",
                    badgeValue: "9",
                    badgeClass: "bg-primary-transparent ",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M224,56V200a8,8,0,0,1-8,8H40a8,8,0,0,1-8-8V56a8,8,0,0,1,8-8H216A8,8,0,0,1,224,56Z' opacity='0.2'></path><path d='M216,40H40A16,16,0,0,0,24,56V200a16,16,0,0,0,16,16H216a16,16,0,0,0,16-16V56A16,16,0,0,0,216,40Zm0,160H40V56H216V200ZM176,88a48,48,0,0,1-96,0,8,8,0,0,1,16,0,32,32,0,0,0,64,0,8,8,0,0,1,16,0Z'></path></svg>",
                    title: "Ecommerce",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                        path: "/ecommerce/dashboard",
                        type: "link",
                        title: "Dashboard",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                        new MainMenuItems (
                        path: "/ecommerce/products",
                        type: "link",
                        title: "Products",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                        new MainMenuItems (
                        path: "/ecommerce/productdetails",
                        type: "link",
                        title: "Product Details",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                        new MainMenuItems (
                        path: "/ecommerce/cart",
                        type: "link",
                        title: "Cart",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                        new MainMenuItems (
                        path: "/ecommerce/checkout",
                        type: "link",
                        title: "Checkout",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                        new MainMenuItems (
                        path: "/ecommerce/customers",
                        type: "link",
                        title: "Customers",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                        new MainMenuItems (
                        path: "/ecommerce/orders",
                        type: "link",
                        title: "Orders",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                        new MainMenuItems (
                        path: "/ecommerce/orderdetails",
                        type: "link",
                        title: "Order Details",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                        new MainMenuItems (
                        path: "/ecommerce/addproduct",
                        type: "link",
                        title: "Add Product",
                        selected: false,
                        active: false,
                        dirChange: false
                      ),
                    }
                ),
                new MainMenuItems (
                    path: "/dashboards/stocks",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M32,48H208a16,16,0,0,1,16,16V208a0,0,0,0,1,0,0H32a0,0,0,0,1,0,0V48A0,0,0,0,1,32,48Z' opacity='0.2'></path><polyline points='224 208 32 208 32 48' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><polyline points='224 96 160 152 96 104 32 160' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline></svg>",
                    title: "Stocks",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Nested Menu",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><polygon points='32 80 128 136 224 80 128 24 32 80' opacity='0.2'></polygon><polyline points='32 176 128 232 224 176' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><polyline points='32 128 128 184 224 128' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><polygon points='32 80 128 136 224 80 128 24 32 80' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polygon></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "",
                    type: "empty",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><rect x='32' y='80' width='160' height='128' rx='8' opacity='0.2'></rect><rect x='32' y='80' width='160' height='128' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></rect><path d='M64,48H216a8,8,0,0,1,8,8V176' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>",
                    title: "Nested-1",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><rect x='40' y='96' width='176' height='112' rx='8' opacity='0.2'></rect><rect x='40' y='96' width='176' height='112' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></rect><line x1='56' y1='64' x2='200' y2='64' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='72' y1='32' x2='184' y2='32' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Nested-2",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "",
                            type: "empty",
                            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><rect x='40' y='96' width='176' height='112' rx='8' opacity='0.2'></rect><rect x='40' y='96' width='176' height='112' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></rect><line x1='56' y1='64' x2='200' y2='64' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='72' y1='32' x2='184' y2='32' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                            title: "Nested-2-1",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            type: "sub",
                            title: "Nested-2-2",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Nested-2-2-1",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Nested-2-2-2",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                )
                            }
                        )
                    }
                )
            }
        ),
          new MainMenuItems(
            menuTitle: "Pages"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Pages",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'></polygon><path d='M200,224H56a8,8,0,0,1-8-8V40a8,8,0,0,1,8-8h96l56,56V216A8,8,0,0,1,200,224Z' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline></svg>",
            badgeValue: "",
            badgeClass: "",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M128,128V48H48a8,8,0,0,0-8,8v56a146.29,146.29,0,0,0,.87,16Z' opacity='0.2'></path><path d='M128,128V232s78.06-21.3,87.13-104Z' opacity='0.2'></path><path d='M216,112V56a8,8,0,0,0-8-8H48a8,8,0,0,0-8,8v56c0,96,88,120,88,120S216,208,216,112Z' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><line x1='128' y1='232' x2='128' y2='48' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='40.86' y1='128' x2='215.14' y2='128' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Authentication",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/authentication/comingsoon",
                            type: "link",
                            title: "Coming Soon",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Create Password",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/authentication/createpassword/basic",
                                    type: "link",
                                    title: "Basic",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/authentication/createpassword/cover",
                                    type: "link",
                                    title: "Cover",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Lock Screen",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/authentication/lockscreen/basic",
                                    type: "link",
                                    title: "Basic",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/authentication/lockscreen/cover",
                                    type: "link",
                                    title: "Cover",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Reset Password",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/authentication/resetpassword/basic",
                                    type: "link",
                                    title: "Basic",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/authentication/resetpassword/cover",
                                    type: "link",
                                    title: "Cover",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Sign Up",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "authentication/signup/basic",
                                    type: "link",
                                    title: "Basic",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/authentication/signup/cover",
                                    type: "link",
                                    title: "Cover",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Sign In",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/signin/basic",
                                    type: "link",
                                    title: "Basic",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/signin/cover",
                                    type: "link",
                                    title: "Cover",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Two Step Verification",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/twostepverification/basic",
                                    type: "link",
                                    title: "Basic",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/twostepverification/cover",
                                    type: "link",
                                    title: "Cover",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "/authentication/undermaintenance",
                            type: "link",
                            title: "Under Maintenance",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><circle cx='128' cy='128' r='96' opacity='0.2'></circle><circle cx='128' cy='128' r='96' fill='none' stroke='currentColor' stroke-miterlimit='10' stroke-width='16'></circle><line x1='128' y1='136' x2='128' y2='80' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><circle cx='128' cy='172' r='12'></circle></svg>",
                    title: "Error",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/error/error401",
                            type: "link",
                            title: "401 - Error",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/error/error404",
                            type: "link",
                            title: "404 - Error",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/error/error500",
                            type: "link",
                            title: "500 - Error",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M32,96H224V56a8,8,0,0,0-8-8H40a8,8,0,0,0-8,8Z' opacity='0.2'></path><rect x='32' y='48' width='192' height='160' rx='8' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></rect><line x1='32' y1='96' x2='224' y2='96' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Blog",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/blog/blog",
                            type: "link",
                            title: "Blog",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blog/blogdetails",
                            type: "link",
                            title: "Blog Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blog/createblog",
                            type: "link",
                            title: "Create Blog",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/pages/empty",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><circle cx='128' cy='128' r='88' opacity='0.2'></circle><circle cx='128' cy='128' r='88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle><line x1='208' y1='40' x2='48' y2='216' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Empty",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'></polygon><path d='M200,224H56a8,8,0,0,1-8-8V40a8,8,0,0,1,8-8h96l56,56V216A8,8,0,0,1,200,224Z' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><line x1='96' y1='136' x2='160' y2='136' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='96' y1='168' x2='160' y2='168' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Forms",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]{
                        new MainMenuItems (
                            path: "/forms/formadvanced",
                            type: "link",
                            title: "Form Advanced",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Form Elements",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/formelements/inputs",
                                    type: "link",
                                    title: "Inputs",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/formelements/checksradios",
                                    type: "link",
                                    title: "Checks & Radios",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/formelements/inputgroup",
                                    type: "link",
                                    title: "Input Group",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/formelements/formselect",
                                    type: "link",
                                    title: "Form Select",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/formelements/rangeslider",
                                    type: "link",
                                    title: "Range Slider",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/formelements/inputmasks",
                                    type: "link",
                                    title: "Input Masks",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/formelements/fileuploads",
                                    type: "link",
                                    title: "File Uploads",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/formelements/datetimepicker",
                                    type: "link",
                                    title: "Date,Time Picker",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/formelements/colorpickers",
                                    type: "link",
                                    title: "Color Pickers",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "/forms/floatinglabels",
                            type: "link",
                            title: "Floating Labels",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/forms/formlayouts",
                            type: "link",
                            title: "Form Layouts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Form Wizards",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/forms/formwizards",
                                    type: "link",
                                    title: "JS",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/blazor-form-wizards",
                                    type: "link",
                                    title: "Blazor",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "/forms/quilleditor",
                            type: "link",
                            title: "Quill Editor",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/forms/formvalidation",
                            type: "link",
                            title: "Validation",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/forms/select2",
                            type: "link",
                            title: "Select2",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/faqs",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><circle cx='128' cy='128' r='96' opacity='0.2'></circle><circle cx='128' cy='180' r='12'></circle><path d='M128,144v-8c17.67,0,32-12.54,32-28s-14.33-28-32-28S96,92.54,96,108v4' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><circle cx='128' cy='128' r='96' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle></svg>",
                    title: "FAQ'S",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M168,200V104h56v88a8,8,0,0,1-8,8Z' opacity='0.2'></path><path d='M64,56H40A16,16,0,0,0,24,72h0A16,16,0,0,0,40,88H56a16,16,0,0,1,16,16h0a16,16,0,0,1-16,16H28' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><line x1='48' y1='48' x2='48' y2='56' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='48' y1='120' x2='48' y2='128' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><path d='M96,56H224V192a8,8,0,0,1-8,8H40a8,8,0,0,1-8-8V152' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><line x1='104' y1='104' x2='224' y2='104' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='80' y1='152' x2='224' y2='152' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='168' y1='104' x2='168' y2='200' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Invoice",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/invoice/createinvoice",
                            type: "link",
                            title: "Create Invoice",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/invoice/invoicedetails",
                            type: "link",
                            title: "Invoice Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/invoice/invoicelist",
                            type: "link",
                            title: "Invoice List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/landing",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M41.85,147.24a8,8,0,0,0-1.66,6.86l12.36,55.63a8,8,0,0,0,12.81,4.51L94.81,192C76.7,161.43,71,134.25,72.16,110.91Z' opacity='0.2'></path><path d='M183.84,110.91c1.21,23.34-4.54,50.52-22.65,81.09l29.45,22.24a8,8,0,0,0,12.81-4.51l12.36-55.63a8,8,0,0,0-1.66-6.86Z' opacity='0.2'></path><line x1='144' y1='224' x2='112' y2='224' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><circle cx='128' cy='100' r='12'></circle><path d='M94.81,192C37.52,95.32,103.87,32.53,123.09,17.68a8,8,0,0,1,9.82,0C152.13,32.53,218.48,95.32,161.19,192Z' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><path d='M183.84,110.88l30.31,36.36a8,8,0,0,1,1.66,6.86l-12.36,55.63a8,8,0,0,1-12.81,4.51L161.19,192' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><path d='M72.16,110.88,41.85,147.24a8,8,0,0,0-1.66,6.86l12.36,55.63a8,8,0,0,0,12.81,4.51L94.81,192' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>",
                    title: "Landing",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pages/pricing",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M128,128h24a40,40,0,0,1,0,80H128Z' opacity='0.2'></path><path d='M128,48H112a40,40,0,0,0,0,80h16Z' opacity='0.2'></path><line x1='128' y1='24' x2='128' y2='48' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='128' y1='208' x2='128' y2='232' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><path d='M184,88a40,40,0,0,0-40-40H112a40,40,0,0,0,0,80h40a40,40,0,0,1,0,80H104a40,40,0,0,1-40-40' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>",
                    title: "Pricing",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/profile",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M128,32A96,96,0,0,0,63.8,199.38h0A72,72,0,0,1,128,160a40,40,0,1,1,40-40,40,40,0,0,1-40,40,72,72,0,0,1,64.2,39.37A96,96,0,0,0,128,32Z' opacity='0.2'></path><path d='M63.8,199.37a72,72,0,0,1,128.4,0' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><circle cx='128' cy='128' r='96' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle><circle cx='128' cy='120' r='40' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle></svg>",
                    title: "Profile",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/profilesettings",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M205.31,71.08a16,16,0,0,1-20.39-20.39A96,96,0,0,0,63.8,199.38h0A72,72,0,0,1,128,160a40,40,0,1,1,40-40,40,40,0,0,1-40,40,72,72,0,0,1,64.2,39.37A96,96,0,0,0,205.31,71.08Z' opacity='0.2'></path><line x1='200' y1='40' x2='200' y2='28' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><circle cx='200' cy='56' r='16' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle><line x1='186.14' y1='48' x2='175.75' y2='42' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='186.14' y1='64' x2='175.75' y2='70' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='200' y1='72' x2='200' y2='84' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='213.86' y1='64' x2='224.25' y2='70' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='213.86' y1='48' x2='224.25' y2='42' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><circle cx='128' cy='120' r='40' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle><path d='M63.8,199.37a72,72,0,0,1,128.4,0' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><path d='M222.67,112A95.92,95.92,0,1,1,144,33.33' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>",
                    title: "Profile Settings",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pages/testimonials",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><path d='M105.07,192l16,28a8,8,0,0,0,13.9,0l16-28H216a8,8,0,0,0,8-8V56a8,8,0,0,0-8-8H40a8,8,0,0,0-8,8V184a8,8,0,0,0,8,8Z' opacity='0.2'></path><line x1='96' y1='104' x2='160' y2='104' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='96' y1='136' x2='160' y2='136' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><path d='M105.07,192l16,28a8,8,0,0,0,13.9,0l16-28H216a8,8,0,0,0,8-8V56a8,8,0,0,0-8-8H40a8,8,0,0,0-8,8V184a8,8,0,0,0,8,8Z' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>",
                    title: "Testimonials",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pages/search",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><circle cx='112' cy='112' r='80' opacity='0.2'></circle><circle cx='112' cy='112' r='80' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle><line x1='168.57' y1='168.57' x2='224' y2='224' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='80' y1='112' x2='144' y2='112' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='112' y1='80' x2='112' y2='144' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Search",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pages/team",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><circle cx='128' cy='144' r='40' opacity='0.2'></circle><circle cx='64' cy='88' r='32' opacity='0.2'></circle><circle cx='192' cy='88' r='32' opacity='0.2'></circle><path d='M192,120a59.91,59.91,0,0,1,48,24' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><path d='M16,144a59.91,59.91,0,0,1,48-24' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><circle cx='128' cy='144' r='40' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></circle><path d='M72,216a65,65,0,0,1,112,0' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><path d='M161,80a32,32,0,1,1,31,40' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><path d='M64,120A32,32,0,1,1,95,80' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path></svg>",
                    title: "Team",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pages/termsconditions",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><polygon points='152 32 152 88 208 88 152 32' opacity='0.2'></polygon><path d='M200,224H56a8,8,0,0,1-8-8V40a8,8,0,0,1,8-8h96l56,56V216A8,8,0,0,1,200,224Z' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></path><polyline points='152 32 152 88 208 88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polyline><line x1='96' y1='136' x2='160' y2='136' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='96' y1='168' x2='160' y2='168' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line></svg>",
                    title: "Terms & Conditions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pages/timeline",
                    type: "link",
                    svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu-doublemenu__icon' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'></rect><polygon points='240 160 176 200 176 120 240 160' opacity='0.2'></polygon><line x1='40' y1='64' x2='216' y2='64' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='40' y1='128' x2='136' y2='128' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><line x1='40' y1='192' x2='136' y2='192' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></line><polygon points='240 160 176 200 176 120 240 160' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'></polygon></svg>",
                    title: "Timeline",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
    };
    public List<MainMenuItems> GetMenuData()
    {
        return MenuData;
    }
}

window.interop = {
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

    // Los que ya llamas en el Layout:
    applyPageStyleClass: () => {/* aquí tu lógica si necesitas agregar clases globales */ },

    updateScrollVisibility: (dotnetRef) => {
        const handler = () => dotnetRef.invokeMethodAsync('UpdateScrollVisibility', window.scrollY | 0);
        window.addEventListener('scroll', handler, { passive: true });
        handler(); // evaluar al inicio
    },

    scrollToTop: () => window.scrollTo({ top: 0, behavior: 'smooth' }),

    // Limpieza de vars (cuando reseteas)
    setclearCssVariables: () => {
        const st = document.documentElement.style;
        ['--body-bg-rgb', '--body-bg-rgb2', '--light-rgb', '--form-control-bg', '--input-border', '--gray-3', '--primary-rgb']
            .forEach(k => st.removeProperty(k));
    }
};

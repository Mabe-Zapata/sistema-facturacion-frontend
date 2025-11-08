
console.log('[particles/index] 📦 Iniciando carga del módulo...');

if (typeof window.tsParticles === 'undefined') {
    console.error('[particles/index] ❌ tsParticles no está disponible. Asegúrate de cargar tsparticles.slim.bundle.min.js ANTES de este módulo');
}


import * as loginBg from "./login-bg.js";
import * as backgroundVector from "./background-vector.js"

console.log('[particles/index] ✅ Módulos importados exitosamente');

window.particleFunctions = {

    mountParticlesBG: loginBg.mountParticlesBG,
    unmountParticlesBG: loginBg.unmountParticlesBG,
    isParticlesMounted: loginBg.isParticlesMounted
};

console.log('[particles/index] ✅ Funciones de partículas exportadas globalmente');
console.log('[particles/index] 📋 Funciones disponibles:', Object.keys(window.particleFunctions));
console.log('[particles/index] 🎯 Puedes llamar a: window.particleFunctions.mountParticlesBG("login-bg")');
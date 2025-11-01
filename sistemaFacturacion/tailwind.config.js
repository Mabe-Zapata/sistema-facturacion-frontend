/** @type {import('tailwindcss').Config} */
module.exports = {
    darkMode: 'class',

    content: [
        "./**/*.{razor,html,cshtml,css}" 
    ],
    theme: {
        extend: {
            
            keyframes: {
                fadeIn: {
                    '0%': { opacity: '0' },
                    '100%': { opacity: '1' },
                },
                slideInUp: {
                    '0%': { opacity: '0', transform: 'translateY(20px)' },
                    '100%': { opacity: '1', transform: 'translateY(0)' },
                },
                slideInRight: {
                    '0%': { transform: 'translateX(100%)', opacity: '0' },
                    '100%': { transform: 'translateX(0)', opacity: '1' },
                }
            },
            
            animation: {
                fadeIn: 'fadeIn 0.3s ease-out forwards',
                slideInUp: 'slideInUp 0.5s ease-out forwards',
                slideInRight: 'slideInRight 0.3s ease-out forwards',
            },
        },
    },
    plugins: [],
}
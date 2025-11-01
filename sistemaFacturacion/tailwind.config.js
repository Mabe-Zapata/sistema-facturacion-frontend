/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./**/*.{razor,html,cshtml}" // Esto le dice a Tailwind que mire todos tus archivos Blazor
    ],
    theme: {
        extend: {},
    },
    plugins: [],
}
/** @type {import('tailwindcss').Config} */

const defaultTheme = require("tailwindcss/defaultTheme");

module.exports = {
  content: [
    './Pages/**/*.cshtml',
    './Views/**/*.cshtml'
  ],
  theme: {
    extend: {
      fontFamily: {
        'sans': ['"Rubik"', ...defaultTheme.fontFamily.sans],
      }
    },
  },
  plugins: [],
}


const path = require('path');

module.exports = {
    // This is our entry point containing the code 
    // required to perform server-side rendering.
    entry: './wwwroot/source/main.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/dist'),
        filename: 'bundle.js'
    },
    module: {
        // Transform .jsx files.
        rules: [
            { test: /\.jsx$/, use: 'jsx-loader?harmony' }
        ]
    },
    resolve: {
        // Ensure we can deal with .js and .jsx and require files.
        extensions: ['.js', '.jsx']
    },
    // Set mode for development, production or none.
    mode: 'none'
};
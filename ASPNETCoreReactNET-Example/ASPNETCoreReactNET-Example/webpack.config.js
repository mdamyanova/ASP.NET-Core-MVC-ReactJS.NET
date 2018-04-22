const path = require('path');

module.exports = {
    entry: './wwwroot/source/main.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/dist'),
        filename: 'bundle.js'
    },
    module: {
        rules: [
            { test: /\.jsx$/, use: 'jsx-loader?harmony' }
        ]
    },
    resolve: {
        extensions: ['.js', '.jsx']
    },
    externals: {
        // Use external version of React (from CDN for client-side, or
        // bundled with ReactJS.NET for server-side)
        react: 'React'
    },
    mode: 'none'
};
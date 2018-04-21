const path = require('path');
module.exports = {
    entry: './wwwroot/source/main.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/dist'),
        filename: 'bundle.js'
    },
    mode: 'none'
};
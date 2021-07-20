const path = require("path");

const config = {
  entry: {
    main: path.resolve(__dirname, path.join("src", "client", "index.js")),
  },

  output: {
    path: path.resolve(__dirname, path.join("src", "build")),
    filename: "index.js",
  },
};

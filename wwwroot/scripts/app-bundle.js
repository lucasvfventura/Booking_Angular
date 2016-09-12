define('app',["require", "exports"], function (require, exports) {
    "use strict";
    var App = (function () {
        function App() {
            this.message = 'Hello World!';
        }
        return App;
    }());
    exports.App = App;
});

define('environment',["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.default = {
        debug: true,
        testing: true
    };
});

define('main',["require", "exports", './environment'], function (require, exports, environment_1) {
    "use strict";
    Promise.config({
        warnings: {
            wForgottenReturn: false
        }
    });
    function configure(aurelia) {
        aurelia.use
            .standardConfiguration()
            .feature('resources');
        if (environment_1.default.debug) {
            aurelia.use.developmentLogging();
        }
        if (environment_1.default.testing) {
            aurelia.use.plugin('aurelia-testing');
        }
        aurelia.start().then(function () { return aurelia.setRoot(); });
    }
    exports.configure = configure;
});

define('resources/index',["require", "exports"], function (require, exports) {
    "use strict";
    function configure(config) {
    }
    exports.configure = configure;
});

define('text!app.html', ['module'], function(module) { module.exports = "<template>\n  <require from=\"bootstrap/css/bootstrap.css\"></require>\n\n   <nav class=\"navbar navbar-default navbar-fixed-top\">\n        <div class=\"container\">\n            <div class=\"navbar-header\">\n                <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">\n                    <span class=\"sr-only\">Toggle navigation</span>\n                    <span class=\"icon-bar\"></span>\n                    <span class=\"icon-bar\"></span>\n                    <span class=\"icon-bar\"></span>\n                </button>\n                <a asp-controller=\"Home\" asp-action=\"Index\" class=\"navbar-brand\">Booking</a>\n            </div>\n            <div class=\"navbar-collapse collapse\">\n                <ul class=\"nav navbar-nav\">\n                    <li><a asp-controller=\"Home\" asp-action=\"Index\">Home</a></li>\n                    <li><a asp-controller=\"Home\" asp-action=\"About\">About</a></li>\n                    <li><a asp-controller=\"Home\" asp-action=\"Contact\">Contact</a></li>\n                </ul>\n\n                <!--// TODO: Add a separated element for login -->\n                <ul class=\"nav navbar-nav navbar-right\">\n                    <li><a>Register</a></li>\n                    <li><a>Log in</a></li>\n                </ul>\n            </div>\n        </div>\n    </nav>\n    <div class=\"container body-content\" style=\"padding-top: 40px\">\n        <h1>${message}</h1>\n        <hr />\n        <footer>\n            <p>&copy; 2016 - Booking</p>\n        </footer>\n    </div>\n  \n</template>\n"; });
//# sourceMappingURL=app-bundle.js.map
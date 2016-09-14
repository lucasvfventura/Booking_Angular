define('app',["require", "exports"], function (require, exports) {
    "use strict";
    var App = (function () {
        function App() {
        }
        App.prototype.configureRouter = function (config, router) {
            this.router = router;
            config.title = "Booking";
            config.map([
                { route: ["", "search"], name: "search", moduleId: "./resources/elements/reservation/search", nav: true, title: "Search your place" },
                { route: "deals", name: "deals", moduleId: "./resources/elements/deals", nav: true, title: "Deals" },
                { route: "aboutus", name: "aboutus", moduleId: "./resources/elements/aboutus", nav: true, title: "About Us" },
                { route: "business", name: "business", moduleId: "./resources/elements/business", nav: true, title: "For Business" }
            ]);
            config.mapUnknownRoutes('./resources/elements/error');
        };
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

define('resources/elements/aboutus',["require", "exports"], function (require, exports) {
    "use strict";
    var AboutUs = (function () {
        function AboutUs() {
        }
        return AboutUs;
    }());
    exports.AboutUs = AboutUs;
});

define('resources/elements/business',["require", "exports"], function (require, exports) {
    "use strict";
    var Business = (function () {
        function Business() {
        }
        return Business;
    }());
    exports.Business = Business;
});

define('resources/elements/deals',["require", "exports"], function (require, exports) {
    "use strict";
    var Deals = (function () {
        function Deals() {
        }
        return Deals;
    }());
    exports.Deals = Deals;
});

define('resources/elements/error',["require", "exports"], function (require, exports) {
    "use strict";
    var Error = (function () {
        function Error() {
        }
        return Error;
    }());
    exports.Error = Error;
});

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
define('resources/elements/login/login-menu',["require", "exports", 'aurelia-router', 'aurelia-framework'], function (require, exports, aurelia_router_1, aurelia_framework_1) {
    "use strict";
    var LoginMenu = (function () {
        function LoginMenu() {
        }
        LoginMenu.prototype.bind = function () {
            this.router.addRoute({ route: "register", name: "register", moduleId: "./resources/elements/login/register", nav: true, title: "Register" });
            this.router.refreshNavigation();
        };
        __decorate([
            aurelia_framework_1.bindable, 
            __metadata('design:type', aurelia_router_1.Router)
        ], LoginMenu.prototype, "router", void 0);
        return LoginMenu;
    }());
    exports.LoginMenu = LoginMenu;
});

define('resources/elements/login/register',["require", "exports", "bootstrap-daterangepicker"], function (require, exports) {
    "use strict";
    var Register = (function () {
        function Register() {
        }
        Register.prototype.attached = function () {
            jQuery("#birthdate").daterangepicker({
                singleDatePicker: true
            });
        };
        Register.prototype.submit = function () {
            alert("Registration Complete");
        };
        return Register;
    }());
    exports.Register = Register;
});

define('resources/elements/reservation/search',["require", "exports"], function (require, exports) {
    "use strict";
    var Search = (function () {
        function Search() {
        }
        return Search;
    }());
    exports.Search = Search;
});

define('text!app.html', ['module'], function(module) { module.exports = "<template>\n  <require from=\"bootstrap/css/bootstrap.css\"></require>\n  <require from=\"bootstrap-daterangepicker/daterangepicker.css\"></require>\n  <require from=\"./resources/elements/login/login-menu\"></require>\n  <require from=\"./resources/styles/main.css\"></require>\n\n   <nav class=\"navbar navbar-default navbar-fixed-top\">\n        <div class=\"container\">\n            <div class=\"navbar-header\">\n                <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">\n                    <span class=\"sr-only\">Toggle navigation</span>\n                    <span class=\"icon-bar\"></span>\n                    <span class=\"icon-bar\"></span>\n                    <span class=\"icon-bar\"></span>\n                </button>\n                <a route-href=\"route: search\" class=\"navbar-brand\">Booking</a>\n            </div>\n            <div class=\"navbar-collapse collapse\">\n                <ul class=\"nav navbar-nav\">\n                    <li><a route-href=\"route: deals\">Deals</a></li>\n                    <li><a route-href=\"route: business\">For Business</a></li>\n                    <li><a route-href=\"route: aboutus\">About Us</a></li>\n                </ul>\n\n                <login-menu class=\"login-menu\" router.bind=\"router\"></login-menu>\n            </div>\n        </div>\n    </nav>\n\n    <div class=\"container body-content\" style=\"padding-top: 50px\">\n        <router-view></router-view>\n    </div>\n    \n    <div class=\"container\" >\n        <hr />\n        <footer>\n            <p>&copy; 2016 - Booking</p>\n        </footer>\n    </div>\n</template>\n"; });
define('text!resources/elements/aboutus.html', ['module'], function(module) { module.exports = "<template>\r\n    About Us\r\n</template>"; });
define('text!resources/styles/main.css', ['module'], function(module) { module.exports = ".login-menu {\n  margin: 0px;\n  padding: 0px; }\n"; });
define('text!resources/elements/business.html', ['module'], function(module) { module.exports = "<template>\r\n    For Business\r\n</template>"; });
define('text!resources/elements/deals.html', ['module'], function(module) { module.exports = "<template>\r\n    <div>\r\n        Deals\r\n    </div>\r\n</template>"; });
define('text!resources/elements/error.html', ['module'], function(module) { module.exports = "<template>\r\n    <div>\r\n        Page not found 404\r\n    </div>\r\n</template>"; });
define('text!resources/elements/login/login-menu.html', ['module'], function(module) { module.exports = "<template>\r\n    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li><a route-href=\"route: register\">Register</a></li>\r\n        <li><a>Log in</a></li>\r\n    </ul>\r\n</template>"; });
define('text!resources/elements/login/register.html', ['module'], function(module) { module.exports = "<template>\r\n    <div class=\"container\">\r\n        <h4>Create a new account.</h4>\r\n        <hr />\r\n        <form submit.delegate=\"submit()\">\r\n            <div class=\"form-inline\">\r\n                <div class=\"form-group\">\r\n                <label>\r\n                    First Name:\r\n                    <input type=\"text\" class=\"form-control\" value.bind=\"firstName\" />\r\n                </label>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>\r\n                        Middle Name:\r\n                        <input type=\"text\" class=\"form-control\" value.bind=\"middleName\" />\r\n                    </label>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>\r\n                        Last Name:\r\n                        <input type=\"text\" class=\"form-control\" value.bind=\"lastName\" />\r\n                    </label>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    Birth date:\r\n                    <input id=\"birthdate\" type=\"text\" class=\"form-control\" value.bind=\"birthDate\" />\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    E-mail:\r\n                    <input type=\"email\" class=\"form-control\" value.bind=\"email\" />\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    Password:\r\n                    <input type=\"password\" class=\"form-control\" value.bind=\"password\"/>\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    Repeat Password:\r\n                    <input type=\"password\" class=\"form-control\" value.bind=\"repassword\"/>\r\n                </label>\r\n            </div>\r\n            <div class=\"form-inline form-group\">\r\n                <button class=\"btn btn-primary\" type=\"submit\">Register</button>\r\n                <button class=\"btn btn-default\" type=\"button\">Cancel</button>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</template>"; });
define('text!resources/elements/reservation/search.html', ['module'], function(module) { module.exports = "<template>\r\n    Search\r\n</template>"; });
//# sourceMappingURL=app-bundle.js.map
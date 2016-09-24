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

define('models/userviewmodel',["require", "exports"], function (require, exports) {
    "use strict";
    var UserViewModel = (function () {
        function UserViewModel() {
        }
        Object.defineProperty(UserViewModel.prototype, "FirstName", {
            get: function () {
                return this.firstName;
            },
            set: function (v) {
                this.firstName = v;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(UserViewModel.prototype, "MiddleName", {
            get: function () {
                return this.middleName;
            },
            set: function (v) {
                this.middleName = v;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(UserViewModel.prototype, "LastName", {
            get: function () {
                return this.lastName;
            },
            set: function (v) {
                this.lastName = v;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(UserViewModel.prototype, "BirthDate", {
            get: function () {
                return this.birthDate;
            },
            set: function (v) {
                this.birthDate = v;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(UserViewModel.prototype, "Email", {
            get: function () {
                return this.email;
            },
            set: function (v) {
                this.email = v;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(UserViewModel.prototype, "Password", {
            get: function () {
                return this.password;
            },
            set: function (v) {
                this.password = v;
            },
            enumerable: true,
            configurable: true
        });
        return UserViewModel;
    }());
    exports.UserViewModel = UserViewModel;
});

define('resources/index',["require", "exports"], function (require, exports) {
    "use strict";
    function configure(config) {
    }
    exports.configure = configure;
});

define('services/apiexception',["require", "exports"], function (require, exports) {
    "use strict";
    var ApiException = (function () {
        function ApiException(message) {
            this.message = message;
        }
        Object.defineProperty(ApiException.prototype, "Message", {
            get: function () {
                return this.message;
            },
            enumerable: true,
            configurable: true
        });
        return ApiException;
    }());
    exports.ApiException = ApiException;
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
define('services/dataservices',["require", "exports", 'aurelia-fetch-client', 'aurelia-framework', './apiexception', 'whatwg-fetch'], function (require, exports, aurelia_fetch_client_1, aurelia_framework_1, apiexception_1) {
    "use strict";
    var DataService = (function () {
        function DataService(client) {
            this.client = client;
            this.client.configure(function (config) {
                config
                    .withBaseUrl('/api/')
                    .withDefaults({
                    credentials: 'same-origin',
                    headers: {
                        'Accept': 'application/json',
                        'X-Requested-With': 'Fetch'
                    }
                });
            });
            this.baseUri = "";
        }
        DataService.prototype.setBaseUri = function (baseUri) {
            this.baseUri = baseUri;
        };
        DataService.prototype.get = function () {
            if (this.baseUri == "") {
                throw new apiexception_1.ApiException("Base uri must be set before using this method");
            }
            return this.client.fetch(this.baseUri);
        };
        DataService.prototype.getCustomResource = function (resource) {
            if (this.baseUri == "") {
                throw new apiexception_1.ApiException("Base uri must be set before using this method");
            }
            return this.client.fetch(this.baseUri + resource);
        };
        DataService.prototype.post = function (resource) {
            if (this.baseUri == "") {
                throw new apiexception_1.ApiException("Base uri must be set before using this method");
            }
            return this.client.fetch(this.baseUri, { method: "POST", body: aurelia_fetch_client_1.json(resource) });
        };
        DataService.prototype.postCustomResource = function (resourceUri, resource) {
            if (this.baseUri == "") {
                throw new apiexception_1.ApiException("Base uri must be set before using this method");
            }
            return this.client.fetch(this.baseUri + resourceUri, { method: "POST", body: aurelia_fetch_client_1.json(resource) });
        };
        DataService.prototype.delete = function (id) {
            if (this.baseUri == "") {
                throw new apiexception_1.ApiException("Base uri must be set before using this method");
            }
            return this.client.fetch(this.baseUri + ("/" + id), {
                method: "DELETE"
            });
        };
        DataService.prototype.put = function (resource) {
            if (this.baseUri == "") {
                throw new apiexception_1.ApiException("Base uri must be set before using this method");
            }
            return this.client.fetch(this.baseUri, {
                method: "DELETE"
            });
        };
        DataService = __decorate([
            aurelia_framework_1.autoinject(), 
            __metadata('design:paramtypes', [aurelia_fetch_client_1.HttpClient])
        ], DataService);
        return DataService;
    }());
    exports.DataService = DataService;
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

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
define('resources/elements/login/register',["require", "exports", '../../../services/dataservices', 'aurelia-framework', '../../../models/userviewmodel', "bootstrap-daterangepicker"], function (require, exports, dataservices_1, aurelia_framework_1, userviewmodel_1) {
    "use strict";
    var Register = (function () {
        function Register(dataService) {
            this.dataService = dataService;
            this.dataService.setBaseUri("account");
            this.user = new userviewmodel_1.UserViewModel();
        }
        Register.prototype.attached = function () {
            var _this = this;
            jQuery("#birthdate").daterangepicker({
                singleDatePicker: true
            }).on("change", function (o) {
                _this.user.BirthDate = o.target.value;
            });
        };
        Register.prototype.submit = function () {
            console.log(this.user);
        };
        Register = __decorate([
            aurelia_framework_1.autoinject(), 
            __metadata('design:paramtypes', [dataservices_1.DataService])
        ], Register);
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

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
define('resources/elements/ui-components/daterangepicker',["require", "exports", 'aurelia-framework', "bootstrap-daterangepicker"], function (require, exports, aurelia_framework_1) {
    "use strict";
    var DateRangePicker = (function () {
        function DateRangePicker() {
            this.dateRange = Date.now().toLocaleString();
            this.settings = {};
        }
        DateRangePicker.prototype.bind = function () {
            this.settings = {};
        };
        DateRangePicker.prototype.attached = function () {
            var _this = this;
            jQuery("#birthdate").daterangepicker(this.settings).on("change", function (o) {
                _this.dateRange = o.target.value;
            });
        };
        __decorate([
            aurelia_framework_1.bindable, 
            __metadata('design:type', String)
        ], DateRangePicker.prototype, "dateRange", void 0);
        __decorate([
            aurelia_framework_1.bindable, 
            __metadata('design:type', Object)
        ], DateRangePicker.prototype, "settings", void 0);
        return DateRangePicker;
    }());
    exports.DateRangePicker = DateRangePicker;
});

define('text!app.html', ['module'], function(module) { module.exports = "<template>\n  <require from=\"bootstrap/css/bootstrap.css\"></require>\n  <require from=\"bootstrap-daterangepicker/daterangepicker.css\"></require>\n  <require from=\"./resources/elements/login/login-menu\"></require>\n  <require from=\"./resources/styles/main.css\"></require>\n\n   <nav class=\"navbar navbar-default navbar-fixed-top\">\n        <div class=\"container\">\n            <div class=\"navbar-header\">\n                <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">\n                    <span class=\"sr-only\">Toggle navigation</span>\n                    <span class=\"icon-bar\"></span>\n                    <span class=\"icon-bar\"></span>\n                    <span class=\"icon-bar\"></span>\n                </button>\n                <a route-href=\"route: search\" class=\"navbar-brand\">Booking</a>\n            </div>\n            <div class=\"navbar-collapse collapse\">\n                <ul class=\"nav navbar-nav\">\n                    <li><a route-href=\"route: deals\">Deals</a></li>\n                    <li><a route-href=\"route: business\">For Business</a></li>\n                    <li><a route-href=\"route: aboutus\">About Us</a></li>\n                </ul>\n\n                <login-menu class=\"login-menu\" router.bind=\"router\"></login-menu>\n            </div>\n        </div>\n    </nav>\n\n    <div class=\"container body-content\" style=\"padding-top: 50px\">\n        <router-view></router-view>\n    </div>\n    \n    <div class=\"container\" >\n        <hr />\n        <footer>\n            <p>&copy; 2016 - Booking</p>\n        </footer>\n    </div>\n</template>\n"; });
define('text!resources/styles/main.css', ['module'], function(module) { module.exports = ".login-menu {\n  margin: 0px;\n  padding: 0px; }\n"; });
define('text!resources/elements/aboutus.html', ['module'], function(module) { module.exports = "<template>\r\n    About Us\r\n</template>"; });
define('text!resources/elements/business.html', ['module'], function(module) { module.exports = "<template>\r\n    For Business\r\n</template>"; });
define('text!resources/elements/deals.html', ['module'], function(module) { module.exports = "<template>\r\n    <div>\r\n        Deals\r\n    </div>\r\n</template>"; });
define('text!resources/elements/error.html', ['module'], function(module) { module.exports = "<template>\r\n    <div>\r\n        Page not found 404\r\n    </div>\r\n</template>"; });
define('text!resources/elements/reservation/search.html', ['module'], function(module) { module.exports = "<template>\r\n    Search\r\n</template>"; });
define('text!resources/elements/login/login-menu.html', ['module'], function(module) { module.exports = "<template>\r\n    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li><a route-href=\"route: register\">Register</a></li>\r\n        <li><a>Log in</a></li>\r\n    </ul>\r\n</template>"; });
define('text!resources/elements/login/register.html', ['module'], function(module) { module.exports = "<template>\r\n    <div class=\"container\">\r\n        <h4>Create a new account.</h4>\r\n        <hr />\r\n        <form submit.delegate=\"submit()\">\r\n            <div class=\"form-inline\">\r\n                <div class=\"form-group\">\r\n                <label>\r\n                    First Name:\r\n                    <input type=\"text\" class=\"form-control\" value.bind=\"user.FirstName\" />\r\n                </label>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>\r\n                        Middle Name:\r\n                        <input type=\"text\" class=\"form-control\" value.bind=\"user.MiddleName\" />\r\n                    </label>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>\r\n                        Last Name:\r\n                        <input type=\"text\" class=\"form-control\" value.bind=\"user.LastName\" />\r\n                    </label>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    Birth date:\r\n                    <input id=\"birthdate\" type=\"text\" class=\"form-control\" value.bind=\"user.BirthDate\" />\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    E-mail:\r\n                    <input type=\"email\" class=\"form-control\" value.bind=\"user.Email\" />\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    Password:\r\n                    <input type=\"password\" class=\"form-control\" value.bind=\"user.Password\"/>\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    Repeat Password:\r\n                    <input type=\"password\" class=\"form-control\" value.bind=\"confirmPassword\"/>\r\n                </label>\r\n            </div>\r\n            <div class=\"form-inline form-group\">\r\n                <button class=\"btn btn-primary\" type=\"submit\">Register</button>\r\n                <button class=\"btn btn-default\" type=\"button\">Cancel</button>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</template>"; });
define('text!resources/elements/ui-components/daterangepicker.html', ['module'], function(module) { module.exports = "<template>\r\n    <require from=\"bootstrap-daterangepicker/daterangepicker.css\"></require>\r\n    \r\n    <input type=\"text\" class=\"form-control\" />\r\n</template>"; });
//# sourceMappingURL=app-bundle.js.map
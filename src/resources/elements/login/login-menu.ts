import { Router } from 'aurelia-router';
import { bindable } from 'aurelia-framework'

export class LoginMenu {
    @bindable
    private router: Router;

    bind(){
        this.router.addRoute({route: "register", name: "register", moduleId: "./resources/elements/login/register", nav: true, title: "Register"});
        this.router.refreshNavigation();
    }
}
import { Router } from 'aurelia-router';
import { bindable, autoinject } from 'aurelia-framework';
import { EventAggregator } from 'aurelia-event-aggregator';

@autoinject
export class LoginMenu {
    @bindable
    private router: Router;
    private eventAggregator: EventAggregator;
    private user: any;

    constructor(eventAggregator: EventAggregator) {
        this.eventAggregator = eventAggregator;

        this.subscribeToEvents();
    }

    bind(){
        this.router.addRoute({route: "register", name: "register", moduleId: "./resources/elements/login/register", nav: true, title: "Register"});
        this.router.refreshNavigation();
    }

    private subscribeToEvents() {
        this.eventAggregator.subscribe('user logged in', user => {
            this.user = user;
        });
    }
}
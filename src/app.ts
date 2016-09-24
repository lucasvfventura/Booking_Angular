import { RouterConfiguration, Router } from 'aurelia-router';

export class App {
	private router: Router;

	configureRouter(config: RouterConfiguration, router: Router){
		this.router = router;
		config.title = "Booking";

		config.map([
			{route: ["", "search"], name: "search", moduleId: "./resources/elements/reservation/search", nav: true, title: "Search your place"},
			{route: "deals", name: "deals", moduleId: "./resources/elements/deals", nav: true, title: "Deals"},
			{route: "aboutus", name: "aboutus", moduleId: "./resources/elements/aboutus", nav: true, title: "About Us"},
			{route: "business", name: "business", moduleId: "./resources/elements/business", nav: true, title: "For Business"}
		])

		config.mapUnknownRoutes('./resources/elements/error');
	}
}

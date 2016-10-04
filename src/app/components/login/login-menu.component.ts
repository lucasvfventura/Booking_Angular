import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'login-menu',
    templateUrl: './login-menu.component.html',
    
    styleUrls: ['./login-menu.component.css'],
    
})
export class LoginMenuComponent implements OnInit {

    private user: any;

    constructor() { }

    ngOnInit() {
    }

}

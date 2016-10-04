import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginMenuComponent } from './login-menu.component';
import { RegisterComponent } from './register/register.component';
import { BookingRoutingModule } from '../../app-routing.module';

@NgModule({
    imports: [
        CommonModule,
        ReactiveFormsModule,
        BookingRoutingModule
    ],
    declarations: [LoginMenuComponent, RegisterComponent],
    exports: [LoginMenuComponent, RegisterComponent]
})
export class LoginModule {}

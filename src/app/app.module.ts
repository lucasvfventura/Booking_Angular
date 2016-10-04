import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { AboutusComponent } from './components/aboutus/aboutus.component';
import { BusinessComponent } from './components/business/business.component';
import { DealsComponent } from './components/deals/deals.component';
import { SearchComponent } from './components/search/search.component';

import { BookingRoutingModule } from './app-routing.module';
import { ServicesModule } from './services/services.module';
import { LoginModule } from './components/login/login.module';

@NgModule({
    declarations: [
        AppComponent,
        AboutusComponent,
        BusinessComponent,
        DealsComponent,
        SearchComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        BookingRoutingModule,
        ServicesModule,
        LoginModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }

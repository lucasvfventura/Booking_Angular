import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AboutusComponent } from './components/aboutus/aboutus.component';
import { BusinessComponent } from './components/business/business.component';
import { DealsComponent } from './components/deals/deals.component';
import { SearchComponent } from './components/search/search.component';

import { RegisterComponent } from './components/login/register/register.component';

const routes: Routes = [
    { path: '', redirectTo: '/search', pathMatch: 'full' },
    { path: 'deals', component: DealsComponent },
    { path: 'business', component: BusinessComponent },
    { path: 'aboutus', component: AboutusComponent },
    { path: 'search', component: SearchComponent },
    { path: 'register', component: RegisterComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
    providers: []
})
export class BookingRoutingModule { }

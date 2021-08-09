
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AdminPageComponent } from './Home/Pages/Admin-Page/Admin-Page.component';
import { PagesComponent } from './Home/Pages/Pages.component';
import { LoginComponent } from './Login/Login.component';
import { HomeComponent } from './Home/Home.component';

import { NavigationComponent } from './Navigation/Navigation.component';


const routes: Routes = [

  { path: '', component: LoginComponent },
  { path: 'Home', component: HomeComponent },
  { path: 'Main', component: PagesComponent },
  { path: 'Admin', component: AdminPageComponent },
  { path: 'Navigation', component: NavigationComponent }


];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

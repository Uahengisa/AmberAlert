
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AdminPageComponent } from './Home/Pages/Administrator/Admin-Page/Admin-Page.component';
import { PagesComponent } from './Home/Pages/Pages.component';
import { LoginComponent } from './Login/Login.component';
import { HomeComponent } from './Home/Home.component';
// import { ProfileComponent } from 'src/app/pages/profile/profile.component';
import { ExternalApiComponent } from 'src/app/pages/external-api/external-api.component';

import { AuthGuard } from '@auth0/auth0-angular';
import { NavigationComponent } from './Navigation/Navigation.component';
import { AuthNavComponent } from './components/auth-nav/auth-nav.component';


const routes: Routes = [

  { path: '', component: HomeComponent },
  { path: 'profile', component: HomeComponent },
  { path: 'external-api', component: ExternalApiComponent , canActivate: [AuthGuard]},
  // { path: 'Admin', component: AdminPageComponent },
  // { path: 'Navigation', component: NavigationComponent },
  // { path: 'app-nav', component: AuthNavComponent}


];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { MenuModule } from '@syncfusion/ej2-angular-navigations';
import { AuthModule } from '@auth0/auth0-angular';
import { environment as env } from '../environments/environment';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';

/* Component Imports */
import { HomeComponent } from './Home/Home.component';
import { SignInComponent } from './Login/Sign-in/Sign-in.component';
import { LoginComponent } from './Login/Login.component';
import { NavigationComponent } from './Navigation/Navigation.component';
import { SideBarComponent } from './Navigation/SideBar/SideBar.component';
import { NavbarComponent } from './Navigation/Navbar/Navbar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AuthorizationHubComponent } from './Authorization-hub/Authorization-hub.component';
import { LoginButtonComponent } from './components/login-button/login-button.component';
import { SignupButtonComponent } from './components/signup-button/signup-button.component';
import { LogoutButtonComponent } from './components/logout-button/logout-button.component';
import { AuthenticationButtonComponent } from './components/authentication-button/authentication-button.component';
import { AuthNavComponent } from './components/auth-nav/auth-nav.component';

@NgModule({
  declarations: [
    AppComponent,
      HomeComponent,
      SignInComponent,
      LoginComponent,
      NavigationComponent,
      NavbarComponent,
      SideBarComponent,
      AuthorizationHubComponent,
      LoginButtonComponent,
      SignupButtonComponent,
      LogoutButtonComponent,
      AuthenticationButtonComponent,
      AuthNavComponent,
      NavbarComponent,
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MenuModule,
        AuthModule.forRoot({
      ...env.auth,
    }),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

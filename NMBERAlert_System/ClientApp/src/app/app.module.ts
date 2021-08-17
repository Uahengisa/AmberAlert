import { AuthModule } from '@auth0/auth0-angular';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';

/* Component Imports */
import { AppComponent } from './app.component';

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
import { HomeImageGridComponent } from './components/Home-Image-grid/Home-Image-grid.component';


/* Syncfusion Imports */
import { MenuModule } from '@syncfusion/ej2-angular-navigations';
import { GridModule } from '@syncfusion/ej2-angular-grids';
import { ChartModule } from '@syncfusion/ej2-angular-charts';
import { CategoryService, LineSeriesService} from '@syncfusion/ej2-angular-charts';



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
      HomeImageGridComponent
      
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    
    GridModule,
    ChartModule ,
    MenuModule,
        AuthModule.forRoot({
          "domain": "dev-n73l99ce.us.auth0.com",
          "clientId": "WqXJ7vElXIbPjd5vPO2Y82xq4FZxOt02"
    }),
  ],
  providers: [CategoryService, LineSeriesService],
  bootstrap: [AppComponent]
})
export class AppModule { }

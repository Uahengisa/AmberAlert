import { MenuModule } from '@syncfusion/ej2-angular-navigations';


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

@NgModule({
  declarations: [
    AppComponent,
      HomeComponent,
      SignInComponent,
      LoginComponent,
      NavigationComponent,
      NavbarComponent,
      SideBarComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MenuModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import {
  Component,
  OnInit,
  Inject,
  ViewChild,
  ElementRef,
} from "@angular/core";

import { ServiceService } from './../Services/service.service';

import { AuthUserInformation } from './../Models/UserInformation.';

import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: 'app-Login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.scss']
})
export class LoginComponent implements OnInit {

  public AuthUserInformation: AuthUserInformation;

  constructor(
    private activeRoute: ActivatedRoute,
    public network: ServiceService,
    private route: Router,
    @Inject("BASE_URL") ApiUrl: string
  ) {
    this.AuthUserInformation = new AuthUserInformation();


  }

  ngOnInit() {



  }

}

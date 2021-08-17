import { AuthUserInformation, UserInformation,UserLoginInformation,NMBERAlert  } from './../Models/UserInformation.';
import { Injectable, Inject } from "@angular/core";


import { HttpClient } from "@angular/common/http";
import { enableRipple } from "@syncfusion/ej2-base";

@Injectable({  providedIn: 'root' })
export class ServiceService {
  private url = "";
  private baseUrl: any;
  private AuthUserInformation: AuthUserInformation = new AuthUserInformation();
  private UserLoginInformation: UserLoginInformation = new UserLoginInformation();
  private UserInformation: UserInformation = new UserInformation();

  constructor(private http: HttpClient, @Inject("BASE_URL") ApiUrl: string) {
    this.baseUrl = ApiUrl + "odata/";

   }

   async GetAuthUserInformation(Id: string) {
    enableRipple(true);
    let JSONResult;
    this.url = this.baseUrl + `AuthUserInformation(${Id})`; // extention to url
    try {
      JSONResult = await this.http
        .get(this.url, { withCredentials: true })
        .toPromise();
      // console.log("AuthUserInformation is  = "+JSONResult);
    } catch (error) {
      console.log(error);
      JSONResult = error;
    }
    this.AuthUserInformation = JSONResult;
    // this.populateAuthUserInformationData(JSONResult, false);
    console.log(this.AuthUserInformation);
    console.log(JSONResult);
    // return this.AuthUserInformation    ;
    return JSONResult;
  }



}

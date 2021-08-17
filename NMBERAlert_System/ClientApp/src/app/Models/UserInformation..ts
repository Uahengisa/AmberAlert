export class AuthUserInformation {
  public Id:number;
  public UserGuid:string;
  public Username:string;
  public LoginKey:string;
  public DisplayName:string;

constructor (

  Id:number = 0,
  UserGuid:string = "",
  Username:string = "",
  LoginKey:string = "",
  DisplayName:string = "",


) {
  this.Id = Id;
  this.UserGuid = UserGuid;
  this.Username = Username;
  this.LoginKey = LoginKey;
  this.DisplayName = DisplayName;
}

 }

 export class NMBERAlert {

  public NMBERAlertGuid:string;
  public ChildFirstName:string;
  public ChildLastName:string;
  public UserGuid:string;
  public ChildDescription:string;
  public ChildLastSeenLocation:string;
  public ChildAbductionDate:Date ;
  public ChildGender:string;
  public ChildRace:string;
  public ChildHeight:number;
  public AbductionNarrative:string;
constructor (

NMBERAlertGuid:string = "",
ChildFirstName:string = "",
ChildLastName:string = "",
UserGuid:string = "",
ChildDescription:string = "",
ChildLastSeenLocation:string = "",
ChildAbductionDate:Date  = new Date(),
ChildGender:string = "",
ChildRace:string = "",
ChildHeight:number = 0,
AbductionNarrative:string = ""

) {

  this.NMBERAlertGuid = NMBERAlertGuid;
  this.ChildFirstName = ChildFirstName;
  this.ChildLastName = ChildLastName;
  this.UserGuid = UserGuid;
  this.ChildDescription = ChildDescription;
  this.ChildLastSeenLocation = ChildLastSeenLocation;
  this.ChildAbductionDate = ChildAbductionDate;
  this.ChildGender = ChildGender;
  this.ChildRace = ChildRace;
  this.ChildHeight = ChildHeight;
  this.AbductionNarrative = AbductionNarrative;



}

 }


 export class UserLoginInformation {
  public Id:number;
  public UserGuid:string;
  public Username:string;
  public LoginKey:string;

constructor (

  Id:number = 0,
  UserGuid:string = "",
  Username:string = "",
  LoginKey:string = ""


) {
  this.Id = Id;
  this.UserGuid = UserGuid;
  this.Username = Username;
  this.LoginKey = LoginKey;
}

 }


 export class UserInformation {


  public UserGuid?:string;
  public FirstName:string;
  public LastName:string;
  public IdNumber:string;
  public MainContactNumber:string;
  public SecondaryContactNumber:string;
  public PrimaryAddress:string;

constructor (
  UserGuid:string = "",
  FirstName:string = "",
  LastName:string= "" ,
  IdNumber:string= "" ,
  MainContactNumber:string= "" ,
  SecondaryContactNumber:string= "" ,
  PrimaryAddress:string= ""
) {


  this.UserGuid = UserGuid;
  this.FirstName = FirstName;
  this.LastName = LastName;
  this.IdNumber = IdNumber;
  this.MainContactNumber = MainContactNumber;
  this.SecondaryContactNumber = SecondaryContactNumber;
  this.PrimaryAddress = PrimaryAddress;
}

 }


//

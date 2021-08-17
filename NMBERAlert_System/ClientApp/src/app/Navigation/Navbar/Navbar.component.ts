import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Navbar',
  templateUrl: './Navbar.component.html',
  styleUrls: ['./Navbar.component.scss']
})
export class NavbarComponent implements OnInit {
  userIsRegistered = true;
  isExpanded = false;
  constructor() { }

  ngOnInit() {


    
  }
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

}

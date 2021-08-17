import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-Navigation',
  templateUrl: './Navigation.component.html',
  styleUrls: ['./Navigation.component.scss']
})
export class NavigationComponent implements OnInit {
  topNavgation = true;

  constructor() { }

  ngOnInit() {
  }

}

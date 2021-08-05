import { Component } from '@angular/core';
// import { title } from 'process';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent {


  constructor() {

  }

  ngOnInit() {
    function onClick(){
      document.write("Hello");
    }
  }
  onClick(name:string){
    console.log(name)
  }
}


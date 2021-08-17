import { Component, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { GridComponent } from '@syncfusion/ej2-angular-grids';
import { Internationalization } from '@syncfusion/ej2-base';

import { employeeData  } from '../../Data/Data';
let instance: Internationalization = new Internationalization();

@Component({
  selector: 'app-Home-Image-grid',
  templateUrl: './Home-Image-grid.component.html',
  styleUrls: ['./Home-Image-grid.component.scss'],
  encapsulation: ViewEncapsulation.None

})

export class HomeImageGridComponent  implements OnInit {
  public data: object[] = [];

  ngOnInit(): void {
      this.data = employeeData;
  }
  public format(value: Date): string {
      return instance.formatDate(value, { skeleton: 'yMd', type: 'date' });
  }
}
export interface DateFormat extends Window {
  format?: (value: Date) => string;
}

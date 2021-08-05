import { TestComponentComponent } from './test-component/test-component.component';
import { ndPageComponent } from './ndPage/ndPage.component';
import { AppComponent } from './app.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [

  { path: '', component: TestComponentComponent },
  { path: 'gisa', component: ndPageComponent }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

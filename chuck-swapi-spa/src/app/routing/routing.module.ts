import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { CategoriesComponent } from '../categories/categories.component';
import { WelcomeComponent } from '../welcome/welcome.component';
import { PeopleComponent } from '../people/people.component';
import { SearchComponent } from '../search/search.component';

const routes: Routes = [
  {
    path:'',
    component:WelcomeComponent
  },
  {
    path: 'categories',
    component:CategoriesComponent
  }
  ,
  {
    path: 'people',
    component:PeopleComponent
  },
  {
    path: 'search',
    component:SearchComponent
  }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class RoutingModule { }

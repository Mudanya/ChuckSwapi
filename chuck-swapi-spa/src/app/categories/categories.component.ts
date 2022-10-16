import { Component, OnInit } from '@angular/core';
import { Category } from '../models/category';
import { ApiService } from '../services/api.service';
import { SpinnerService } from '../services/spinner.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {
  categories:Category[] = []
  category?:Category
  active = false
  constructor(public spinner: SpinnerService, private apiService:ApiService) { }

  ngOnInit(): void {
    this.apiService.isLoading.subscribe(cat => this.active = cat)
    this.apiService.getCategories().subscribe({
      next: data => {
        this.categories = data
        this.apiService.isLoading.next(true)
      },
      error: err => console.log(err)
    })
  }

}

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
  constructor(public spinner: SpinnerService, private apiService:ApiService) { }

  ngOnInit(): void {
    
    this.apiService.getCategories().subscribe({
      next: data => {
        this.categories = data
        this.spinner.start()
      },
      error: err => console.log(err)
    })
  }

}

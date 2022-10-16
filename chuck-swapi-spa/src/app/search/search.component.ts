import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiService } from '../services/api.service';
import { SpinnerService } from '../services/spinner.service';
import {SearchResults} from '../models/search-results'
 @Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
active = false
searching =  false
searchData ?: SearchResults;
form =  new FormGroup({})
  constructor(public spinner: SpinnerService,private apiService : ApiService, private fb:FormBuilder) { }

  ngOnInit(): void {
    this.apiService.isLoading.subscribe(isLoading => this.active = isLoading )
    this.form = this.fb.group({
      search: ['', Validators.required]
    })
  }
  searchForm() {
    this.searching = true
    this.apiService.search(this.form.value?.search).subscribe(
      {
        next:data=> {
          this.active = true
           this.searchData = data
           this.apiService.isLoading.next(true)
      },
    error:err=>console.log(err)}
    )
  }
}

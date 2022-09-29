import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
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
searchData ?: SearchResults;

  constructor(public spinner: SpinnerService,private apiService : ApiService) { }

  ngOnInit(): void {
    this.active = this.spinner.active
    this.spinner.start()
    
  }
  searchForm(event:Event) {
    debugger
    this.apiService.search((event.target as HTMLInputElement).value).subscribe(
      {
        next:data=> {
           this.searchData = data
           console.log(data)
           this.spinner.start()
      },
    error:err=>console.log(err)}
    )
  }
}

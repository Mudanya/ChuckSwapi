import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {Observable} from 'rxjs'
import { Category } from '../models/category';
import { People } from '../models/people';
import { SearchResults } from '../models/search-results';
@Injectable({
  providedIn: 'root'
})

export class ApiService {
 apiUrl = "https://localhost:7088/api/"
  constructor(private http:HttpClient) { }

  getCategories():Observable<Category[]> {
      return this.http.get<Category[]>(this.apiUrl+'Chuck/categories')
  }

  getPeople():Observable<People[]> {
      return this.http.get<People[]>(this.apiUrl+'Swapi/people')
  }

  search(query:string):Observable<SearchResults> {
      return this.http.get<SearchResults>(this.apiUrl+'search?query='+query)
  }
}

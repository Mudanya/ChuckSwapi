import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {
  category?:string|null
  constructor(private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.category = this.route.snapshot.queryParamMap.get('category')
  }

}

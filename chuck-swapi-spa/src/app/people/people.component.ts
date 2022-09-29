import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { SpinnerService } from '../services/spinner.service';
import {MatTableDataSource} from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { ApiService } from '../services/api.service';
import { People } from '../models/people';
@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent  implements AfterViewInit, OnInit {
  people:People[] =[]
  active = false
  displayedColumns: string[] = ['name', 'birthYear', 'mass', 'height'];
  ELEMENT_DATA: peopleTable[] = [];
  dataSource !:MatTableDataSource<People>;

  @ViewChild(MatPaginator) paginator?: MatPaginator;

  ngAfterViewInit() {
    this.dataSource!.paginator  = this.paginator as MatPaginator;
  }
  constructor(public spinner: SpinnerService, private apiService:ApiService) { }

  ngOnInit(): void {
    this.apiService.getPeople().subscribe({
      next:data=>{
        debugger
        this.people = data
        this.dataSource = new MatTableDataSource(data)
        this.spinner.start()
        console.log(this.ELEMENT_DATA)
      },
      error:err=>console.log(err)
    })
    this.active = this.spinner.active
  }

}
export interface peopleTable {
  name: string;
  birthYear: string;
  height: string;
  mass: string;
}

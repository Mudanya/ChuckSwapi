import { Component, OnInit } from '@angular/core';
import { SpinnerService } from '../services/spinner.service';

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html',
  styleUrls: ['./welcome.component.css']
})
export class WelcomeComponent implements OnInit {
  active = false
  constructor(public spinner: SpinnerService) { }

  ngOnInit(): void {
    this.active = this.spinner.active
    this.spinner.start()
    
  }

}

import { Component, OnInit } from '@angular/core';
import { SpinnerService } from '../services/spinner.service';

@Component({
  selector: 'app-spinner',
  templateUrl: './spinner.component.html',
  styleUrls: ['./spinner.component.css']
})
export class SpinnerComponent implements OnInit {
  public active?: boolean;
  public constructor(spinner: SpinnerService) {
    spinner.status.subscribe((status: boolean) => {
      debugger
      this.active = status;
    });
  }
  ngOnInit(): void {
  }

}

import { Component } from '@angular/core';

@Component({
  selector: 'request-component',
  templateUrl: './request.component.html'
})
export class RequesttComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}

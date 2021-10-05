import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'client';
  armors: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getArmors();
  }

  getArmors() {
    this.http.get('https://localhost:5001/api/armors').subscribe(response => {
      this.armors = response;
    }, error => {
      console.log(error);
    });
  }
}

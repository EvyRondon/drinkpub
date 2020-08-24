import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { phone, address } from '../../../../Model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  People: people[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<people[]>(baseUrl + 'api/People').subscribe(result => {
      this.People = result
    }, error => console.error(error));
  }
}

interface people {
  id: number;
  name: string;
  document: string;
  email: string;
  //phone: phone;
  //address: address;
}

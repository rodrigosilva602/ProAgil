import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  eventos: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }

  getEventos()
  {
    this.http.get('https://localhost:44374/api/weatherforecast').subscribe(
      response => {this.eventos = response; console.log(response);
      }
      , error => {
          console.log(error);
      }
    );
  }

}

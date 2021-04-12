import { Ciudad } from './../../models/ciudad.interface';
import { Pais } from './../../models/pais.interface';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-servicio',
  templateUrl: './servicio.component.html',
  styleUrls: ['./servicio.component.css'],
})
export class ServicioComponent implements OnInit {
  paises: Pais[] = [];
  ciudades: Ciudad[] = [];

  constructor(private httpClient: HttpClient) {}

  ngOnInit(): void {
    this.httpClient
      .get<Pais[]>('https://localhost:44330/api/Clima/Paises')
      .toPromise()
      .then((result) => {
        this.paises = result;
      });
  }

  getCiudades($event: Event) {
    const event = $event.currentTarget as HTMLInputElement;
    const paisId = event.value || 0;
    return this.httpClient
      .get<Ciudad[]>('https://localhost:44330/api/Clima/Ciudades/' + paisId)
      .toPromise()
      .then((result) => {
        this.ciudades = result;
      });
  }
}

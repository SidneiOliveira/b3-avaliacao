import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { CalculoCDBResponse } from '../models/calculo-cdb';

@Injectable({
  providedIn: 'root'
})
export class CalculoCDBService {
  url = 'https://localhost:7038/calculo-cdb';
  constructor(private httpClient: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Accept': 'application/json', 'Access-Control-Allow-Origin': 'https://localhost:7038', 'Access-Control-Allow-Credentials' : 'true' })
  }

  getCalculoCDB(valor: number, meses: number): Observable<CalculoCDBResponse> {
    return this.httpClient.get<CalculoCDBResponse>(`${this.url}?valor=${valor}&qtdMeses=${meses}`)
  }
}


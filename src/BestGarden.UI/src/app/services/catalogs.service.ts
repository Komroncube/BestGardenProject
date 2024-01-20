import { Injectable } from '@angular/core';
import { ICatalogService } from '../Interfaces/catalogs.interface';
import { Observable } from 'rxjs';
import { ICatalogTitle } from '../Interfaces/Catalogs/ICatalogTitle';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CatalogsService implements ICatalogService {

  constructor(private http:HttpClient) { }
  getCatalogs(): Observable<ICatalogTitle[]> {
    return this.http.get<ICatalogTitle[]>('api/catalogs');
  }
  getCatalogById(id: number): Observable<ICatalogTitle> {
    throw new Error('Method not implemented.');
  }
}

import { Injectable } from '@angular/core';
import { ICatalogService } from '../Interfaces/catalogs.interface';
import { Observable } from 'rxjs';
import { ICatalogTitle } from '../Interfaces/Catalogs/ICatalogTitle';
import { HttpClient } from '@angular/common/http';
import { ICatalog } from '../Interfaces/Catalogs/ICatalog';

@Injectable({
  providedIn: 'root'
})
export class CatalogsService implements ICatalogService {

  constructor(private http:HttpClient) { }
  /**
   * 
   * @returns Observable<ICatalogTitle[]>
   */
  getCatalogs(): Observable<ICatalogTitle[]> {
    return this.http.get<ICatalogTitle[]>('api/catalogs');
  }
  /**
   * 
   * @param id 
   * @returns Observable<ICatalog>
   */
  getCatalogById(id: number): Observable<ICatalog> {
    return this.http.get<ICatalog>(`api/catalogs/${id}`);
  }
}

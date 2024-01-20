import { Observable } from "rxjs";
import { ICatalogTitle } from "./Catalogs/ICatalogTitle";

export interface ICatalogService {
  getCatalogs(): Observable<Array<ICatalogTitle>>;
  getCatalogById(id: number): Observable<ICatalogTitle>;
}

import { Observable } from "rxjs";
import { ICatalogTitle } from "./Catalogs/ICatalogTitle";

export interface ICatalogService {
  getProducts(): Observable<Array<ICatalogTitle>>;
  getProductById(id: number): Observable<ICatalogTitle>;
}

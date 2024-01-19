import { Observable } from "rxjs/internal/Observable";
import { IProduct } from "./Products/IProduct";


export interface IProductService {
  getProducts(): Observable<Array<IProduct>>;
  getProductById(id: number): Observable<IProduct>;
}
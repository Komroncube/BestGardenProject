import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IProduct } from '../Interfaces/Products/IProduct';
import { IProductService } from '../Interfaces/products.interface';

@Injectable({
  providedIn: 'root'
})
export class ProductsService implements IProductService {

  constructor(private http: HttpClient) { }

  /**
   * 
   * @returns array of products
   */
  getProducts() {
    return this.http.get<Array<IProduct>>('api/products');
  }
  getProductById(id: number) {
    return this.http.get<IProduct>(`api/products/${id}`);
  }
  createProduct(product: IProduct) {
    return this.http.post<IProduct>('api/products', product);
  }
}

import { Component } from '@angular/core';
import { SupportFormComponent } from "../../components/support-form/support-form.component";
import { FaqComponent } from "../../components/faq/faq.component";
import { ProductsService } from '../../services/products.service';
import { IProduct } from '../../Interfaces/Products/IProduct';
import { ProductInfoCardComponent } from "../../components/product-info-card/product-info-card.component";
import { ProductInfo } from '../../Interfaces/Products/ProductInfo';
import { CatalogsService } from '../../services/catalogs.service';

@Component({
  selector: 'app-home',
  standalone: true,
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss',
  imports: [SupportFormComponent, FaqComponent, ProductInfoCardComponent]
})
export class HomeComponent {
  landscape = "../../../assets/landscape.png";
  /**
   * 
   */
  products!: ProductInfo[];
  catalogs!: IProduct[];


  /**
   * 
   * @param productService 
   */
  constructor(
    private productService: ProductsService,
    private catalogService: CatalogsService
    ) {
    this.getProducts();
  }

  private getProducts() {
    this.productService.getProducts().subscribe((products) => {

      console.log(products[0].id);
      
      this.products = products.map((product) => new ProductInfo(
        product.id || 0, // Default to 0 if Id is missing
        product.name || '', // Default to empty string if Name is missing
        product.imagePath || '' // Default to empty string if ImagePath is missing
    )).slice(0, 4)
      
      // console.log(this.products);
    },
    (error: any) => console.log(error));
  }

  private getCatalogs() {
    this.productService.getCatalogs().subscribe((catalogs) => {
      this.catalogs = catalogs;
      console.log(this.catalogs);
    },
    (error: any) => console.log(error));
  }
}

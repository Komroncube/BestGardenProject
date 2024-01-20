import { Component } from '@angular/core';
import { SupportFormComponent } from "../../components/support-form/support-form.component";
import { FaqComponent } from "../../components/faq/faq.component";
import { ProductsService } from '../../services/products.service';
import { IProduct } from '../../Interfaces/Products/IProduct';
import { ProductInfoCardComponent } from "../../components/product-info-card/product-info-card.component";
import { ProductInfo } from '../../Interfaces/Products/ProductInfo';
import { CatalogsService } from '../../services/catalogs.service';
import { ICatalogTitle } from '../../Interfaces/Catalogs/ICatalogTitle';
import { CatalogTitleComponent } from "../../components/catalog-title-card/catalog-title-card.component";

@Component({
    selector: 'app-home',
    standalone: true,
    templateUrl: './home.component.html',
    styleUrl: './home.component.scss',
    imports: [SupportFormComponent, FaqComponent, ProductInfoCardComponent, CatalogTitleComponent]
})
export class HomeComponent {
  landscape = "../../../assets/landscape.png";
  /**
   * 
   */
  products!: ProductInfo[];
  catalogs!: ICatalogTitle[];


  /**
   * 
   * @param productService 
   */
  constructor(
    private productService: ProductsService,
    private catalogService: CatalogsService
  ) {
    this.getProducts();
    this.getCatalogs();
  }

  private getProducts() {
    this.productService.getProducts().subscribe({
      next: (products) => {

        console.log(products[0].id);

        this.products = products.map((product) => new ProductInfo(
          product.id || 0, // Default to 0 if Id is missing
          product.name || '', // Default to empty string if Name is missing
          product.imagePath || '' // Default to empty string if ImagePath is missing
        )).slice(0, 4)

        // console.log(this.products);
      },
      error: (error: any) => console.log(error)
    });
  }

  private getCatalogs() {
    this.catalogService.getCatalogs().subscribe({
      next: (catalogs) => {
        this.catalogs = catalogs.slice(0, 9)  // Default to 0 if Id is missing);
        console.log(this.catalogs);
      },
      error: (error: any) => console.log(error)
    });
  }
}

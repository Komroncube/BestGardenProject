import { Component } from '@angular/core';
import { CatalogsService } from '../../../services/catalogs.service';
import { ICatalog } from '../../../Interfaces/Catalogs/ICatalog';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { ProductCardComponent } from "../../../components/product-card/product-card.component";
import { ImageUrlPipe } from "../../../pipes/image-url.pipe";

@Component({
    selector: 'app-catalog-details',
    standalone: true,
    templateUrl: './catalog-details.component.html',
    styleUrl: './catalog-details.component.scss',
    imports: [RouterLink, ProductCardComponent, ImageUrlPipe]
})
export class CatalogDetailsComponent {
  catalog: ICatalog | undefined;
  /**
   * 
   * @param catalogService 
   */
  constructor(private catalogService: CatalogsService,
    private route: ActivatedRoute) {
    catalogService.getCatalogById(this.catalogId).subscribe({
      next: (catalog) => {
        this.catalog = catalog;
        console.log(this.catalog);
      },
      error: (error: any) => console.log(error)
    });
  }




  get catalogId() {
    return  Number(this.route.snapshot.params["id"])
  }
}

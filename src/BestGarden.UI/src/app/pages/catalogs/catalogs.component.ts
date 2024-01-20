import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { CatalogsService } from '../../services/catalogs.service';
import { ICatalogTitle } from '../../Interfaces/Catalogs/ICatalogTitle';
import { CatalogCardComponent } from "../../components/catalog-card/catalog-card.component";
import { ScrollPanel, ScrollPanelModule } from 'primeng/scrollpanel';
@Component({
    selector: 'app-catalogs',
    standalone: true,
    templateUrl: './catalogs.component.html',
    styleUrl: './catalogs.component.scss',
    imports: [RouterLink, CatalogCardComponent, ScrollPanelModule]
})
export class CatalogsComponent {
  
  catalogs: ICatalogTitle[] = [];
  /**
   *
   */
  constructor(private catalogService: CatalogsService) {
    catalogService.getCatalogs().subscribe({
      next: (catalogs) => {
        this.catalogs = catalogs;
        console.log(this.catalogs);
      },
      error: (error: any) => console.log(error)
    });
  }
}

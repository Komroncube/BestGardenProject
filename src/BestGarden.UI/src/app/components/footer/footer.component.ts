import { Component } from '@angular/core';
import { ICatalogTitle } from '../../Interfaces/Catalogs/ICatalogTitle';
import { CatalogsService } from '../../services/catalogs.service';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.scss'
})
export class FooterComponent {
  catalogs: ICatalogTitle[] = [];
  /**
   *
   */
  constructor(private catalogService: CatalogsService) {
    catalogService.getCatalogs().subscribe({
      next: (catalogs) => {
        this.catalogs = catalogs.slice(0, 5);
        console.log(this.catalogs);
      },
      error: (error: any) => console.log(error)
    });
  }
}

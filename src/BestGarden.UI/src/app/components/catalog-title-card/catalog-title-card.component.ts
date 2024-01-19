import { Component, Input } from '@angular/core';
import { ICatalogTitle } from '../../Interfaces/Catalogs/ICatalogTitle';


@Component({
  selector: 'app-catalog-title-card',
  standalone: true,
  imports: [],
  templateUrl: './catalog-title-card.component.html',
  styleUrl: './catalog-title-card.component.scss'
})
export class CatalogTitleComponent {
  @Input()
  data! : ICatalogTitle;
}

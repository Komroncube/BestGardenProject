import { Component, Input } from '@angular/core';
import { ICardTitle } from '../../Interfaces/ICatalogTitle';


@Component({
  selector: 'app-catalog-title-card',
  standalone: true,
  imports: [],
  templateUrl: './catalog-title-card.component.html',
  styleUrl: './catalog-title-card.component.scss'
})
export class CatalogTitleComponent {
  @Input()
  data! : ICardTitle;
}

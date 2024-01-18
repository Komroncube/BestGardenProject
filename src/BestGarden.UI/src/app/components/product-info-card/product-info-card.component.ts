import { Component, Input } from '@angular/core';
import { ICardTitle } from '../../Interfaces/ICatalogTitle';

@Component({
  selector: 'app-product-info-card',
  standalone: true,
  imports: [],
  templateUrl: './product-info-card.component.html',
  styleUrl: './product-info-card.component.scss'
})
export class ProductInfoCardComponent {
  @Input()
  data! : ICardTitle;
}

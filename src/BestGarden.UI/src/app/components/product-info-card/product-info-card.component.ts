import { Component, Input } from '@angular/core';
import { ProductInfo } from '../../Interfaces/Products/ProductInfo';
import { ImageUrlPipe } from '../../pipes/image-url.pipe';

@Component({
    selector: 'app-product-info-card',
    standalone: true,
    templateUrl: './product-info-card.component.html',
    styleUrl: './product-info-card.component.scss',
    imports: [ImageUrlPipe]
})
export class ProductInfoCardComponent {
  @Input()
  data! : ProductInfo;
}

import { Component, Input } from '@angular/core';
import { IProduct } from '../../Interfaces/Products/IProduct';
import { ImageUrlPipe } from "../../pipes/image-url.pipe";

@Component({
    selector: 'app-product-card',
    standalone: true,
    templateUrl: './product-card.component.html',
    styleUrl: './product-card.component.scss',
    imports: [ImageUrlPipe]
})
export class ProductCardComponent {
addToBasket() {
throw new Error('Method not implemented.');
}

  @Input()
  product!: IProduct;
}

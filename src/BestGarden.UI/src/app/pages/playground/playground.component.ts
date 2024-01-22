import { Component } from '@angular/core';
import { FaqComponent } from '../../components/faq/faq.component';
import { SupportFormComponent } from "../../components/support-form/support-form.component";
import { ProductCardComponent } from "../../components/product-card/product-card.component";
import { IProduct } from '../../Interfaces/Products/IProduct';
import { QuantityButtonComponent } from "../../components/quantity-button/quantity-button.component";

@Component({
    selector: 'app-playground',
    standalone: true,
    templateUrl: './playground.component.html',
    styleUrl: './playground.component.scss',
    imports: [FaqComponent, SupportFormComponent, ProductCardComponent, QuantityButtonComponent]
})
export class PlaygroundComponent {
    data : IProduct= {
        id: 1,
        name: 'Product 1',
        description: 'Product 1 description',
        price: 100,
        imagePath: 'https://via.placeholder.com/150',
    };
    num: number =1;
}


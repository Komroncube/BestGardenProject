import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from "./components/footer/footer.component";
import { CatalogTitleComponent } from "./components/catalog-title-card/catalog-title-card.component";
import { ProductInfoCardComponent } from "./components/product-info-card/product-info-card.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss',
    imports: [CommonModule, RouterOutlet, HeaderComponent, FooterComponent, CatalogTitleComponent, ProductInfoCardComponent]
})
export class AppComponent {
  title = 'BestGarden.UI';

  catalogTitle = {
    title : "Catalog",
    imagePath : "../../../assets/landscape.png",
    quantity : 10
  }
}

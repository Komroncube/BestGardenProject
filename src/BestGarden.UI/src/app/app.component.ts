import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss',
    imports: [CommonModule, RouterOutlet]
})
export class AppComponent {
  title = 'BestGarden.UI';

  catalogTitle = {
    title : "Catalog",
    imagePath : "../../../assets/landscape.png",
    quantity : 10
  }
}

import { Component, Input } from '@angular/core';
import { ICatalogTitle } from '../../Interfaces/Catalogs/ICatalogTitle';
import { ImageUrlPipe } from "../../pipes/image-url.pipe";
import { RouterLink } from '@angular/router';

@Component({
    selector: 'app-catalog-card',
    standalone: true,
    templateUrl: './catalog-card.component.html',
    styleUrl: './catalog-card.component.scss',
    imports: [RouterLink,ImageUrlPipe]
})
export class CatalogCardComponent {
  @Input()
  data!: ICatalogTitle;
}

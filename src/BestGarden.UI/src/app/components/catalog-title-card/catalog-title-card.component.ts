import { Component, Input } from '@angular/core';
import { ICatalogTitle } from '../../Interfaces/Catalogs/ICatalogTitle';
import { RouterLink } from '@angular/router';
import { ImageUrlPipe } from "../../pipes/image-url.pipe";


@Component({
    selector: 'app-catalog-title-card',
    standalone: true,
    templateUrl: './catalog-title-card.component.html',
    styleUrl: './catalog-title-card.component.scss',
    imports: [RouterLink, ImageUrlPipe]
})
export class CatalogTitleComponent {
  @Input()
  data! : ICatalogTitle;
}

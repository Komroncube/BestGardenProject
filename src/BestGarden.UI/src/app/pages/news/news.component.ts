import { Component } from '@angular/core';
import { ImageUrlPipe } from "../../pipes/image-url.pipe";
import { RouterLink } from '@angular/router';

@Component({
    selector: 'app-news',
    standalone: true,
    templateUrl: './news.component.html',
    styleUrl: './news.component.scss',
    imports: [ImageUrlPipe, RouterLink]
})
export class NewsComponent {

}

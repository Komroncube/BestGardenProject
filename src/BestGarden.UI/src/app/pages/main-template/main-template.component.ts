import { Component } from '@angular/core';
import { HeaderComponent } from "../../components/header/header.component";
import { FooterComponent } from "../../components/footer/footer.component";
import { RouterOutlet } from '@angular/router';

@Component({
    selector: 'app-main-template',
    standalone: true,
    templateUrl: './main-template.component.html',
    styleUrl: './main-template.component.scss',
    imports: [RouterOutlet, HeaderComponent, FooterComponent]
})
export class MainTemplateComponent {

}

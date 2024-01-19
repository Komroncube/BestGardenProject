import { Component } from '@angular/core';
import { FaqComponent } from '../../components/faq/faq.component';
import { SupportFormComponent } from "../../components/support-form/support-form.component";

@Component({
    selector: 'app-playground',
    standalone: true,
    templateUrl: './playground.component.html',
    styleUrl: './playground.component.scss',
    imports: [FaqComponent, SupportFormComponent]
})
export class PlaygroundComponent {

}

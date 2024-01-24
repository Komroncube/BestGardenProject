import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { AccordionModule } from 'primeng/accordion';
import { TabViewModule } from 'primeng/tabview'
@Component({
  selector: 'app-delivery-and-payment',
  standalone: true,
  imports: [RouterLink, TabViewModule, AccordionModule],
  templateUrl: './delivery-and-payment.component.html',
  styleUrl: './delivery-and-payment.component.scss'
})
export class DeliveryAndPaymentComponent {

}

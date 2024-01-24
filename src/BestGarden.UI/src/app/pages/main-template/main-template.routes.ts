import path from "path";
import { HomeComponent } from "../home/home.component";
import { MainTemplateComponent } from "./main-template.component";
import { CatalogsComponent } from "../catalogs/catalogs.component";
import { CatalogDetailsComponent } from "../catalogs/catalog-details/catalog-details.component";
import { NewsComponent } from "../news/news.component";
import { AboutComponent } from "../about/about.component";
import { ContactsComponent } from "../contacts/contacts.component";
import { DeliveryAndPaymentComponent } from "../delivery-and-payment/delivery-and-payment.component";

export const MAIN_TEMPLATE_ROUTES = [
    { 
        path: '', 
        component: HomeComponent,
    },
    {
        path: 'catalogs',
        component: CatalogsComponent,
        // loadchildren: () => import('../catalogs/catalogs.routes')
        //     .then(m => m.CATALOGS_ROUTES)
    },
    {
        path: 'catalogs/:id',
        component: CatalogDetailsComponent
    },
    {
        path: 'news',
        component: NewsComponent,
    },
    {
        path: 'about',
        component: AboutComponent
    },
    {
        path: 'contacts',
        component: ContactsComponent
    },
    {
        path: 'delivery-and-payment',
        component: DeliveryAndPaymentComponent,
        // children: [
        //     {
        //         path: '',
        //         redirectTo: 'delivery',
        //     },
        //     {
        //         path: 'delivery',
        //         component: DeliveryAndPaymentComponent
        //     },
        //     {
        //         path: 'payment',
        //         component: DeliveryAndPaymentComponent
        //     }
        // ]
    },
    {
        path: 'playground',
        component: HomeComponent
    }
]
import path from "path";
import { HomeComponent } from "../home/home.component";
import { MainTemplateComponent } from "./main-template.component";
import { CatalogsComponent } from "../catalogs/catalogs.component";
import { CatalogDetailsComponent } from "../catalogs/catalog-details/catalog-details.component";

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
        path: 'playground',
        component: HomeComponent
    }
]
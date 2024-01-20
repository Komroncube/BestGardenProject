import path from "path";
import { HomeComponent } from "../home/home.component";
import { MainTemplateComponent } from "./main-template.component";
import { CatalogsComponent } from "../catalogs/catalogs.component";

export const MAIN_TEMPLATE_ROUTES = [
    { 
        path: '', 
        component: HomeComponent,
    },
    {
        path: 'catalogs',
        component: CatalogsComponent,
        loadchildren: () => import('../catalogs/catalogs.routes')
            .then(m => m.CATALOGS_ROUTES)
    },
    {
        path: 'playground',
        component: HomeComponent
    }
]
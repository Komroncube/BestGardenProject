import { Routes } from "@angular/router";
import { CatalogsComponent } from "./catalogs.component";

export const CATALOGS_ROUTES: Routes = [
    { path: '', component: CatalogsComponent},
    { path: ':id', component: CatalogsComponent}

];
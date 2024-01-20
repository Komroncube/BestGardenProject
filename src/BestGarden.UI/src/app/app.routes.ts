import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { PlaygroundComponent } from './pages/playground/playground.component';
import { CatalogsComponent } from './pages/catalogs/catalogs.component';
import { MainTemplateComponent } from './pages/main-template/main-template.component';

export const routes: Routes = [
    { 
        path: 'home',
        component: MainTemplateComponent,
        loadChildren: () => import('./pages/main-template/main-template.routes')
        .then(m => m.MAIN_TEMPLATE_ROUTES)
    },
    { path: '', component: PlaygroundComponent},
    { path: '**', redirectTo: 'home' }
];

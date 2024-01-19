import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { PlaygroundComponent } from './pages/playground/playground.component';

export const routes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: '', component: PlaygroundComponent}
];

import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DrinksComponent } from './drinks/drinks.component';

import { SavedIngredientsComponent } from './saved-ingredients/saved-ingredients.component';
import { SavedDrinksComponent } from './saved-drinks/saved-drinks.component';
import { HomeComponent } from './home/home.component';
import { AddDrinkComponent } from './add-drink/add-drink.component';


const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'drinks', component: DrinksComponent },
  { path: 'saved-ingredients', component: SavedIngredientsComponent },
  { path: 'saved-drinks', component: SavedDrinksComponent },
  { path: 'home', component: HomeComponent },
  { path: 'add-drink', component: AddDrinkComponent}
];
@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { IngredientsComponent } from './ingredients/ingredients.component';
import { DrinksComponent } from './drinks/drinks.component';
import { SavedIngredientsComponent } from './saved-ingredients/saved-ingredients.component';
import { SavedDrinksComponent } from './saved-drinks/saved-drinks.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    IngredientsComponent,
    DrinksComponent,
    SavedIngredientsComponent,
    SavedDrinksComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

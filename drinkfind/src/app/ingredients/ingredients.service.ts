import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of} from 'rxjs';
import { catchError, map, tap} from 'rxjs/operators';
//import { Ingredients } from './ingredients';
//import { Ingredients } from '';

@Injectable({
  providedIn: 'root'
})
export class IngredientsService {
  private ingredientsUri = 'https://localhost:5001/api/ingredients';
  private handleError<T>(operation = 'operation', result?: T){
    return (error: any): Observable<T> => {
      console.error(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
  constructor(private http: HttpClient) { }

  
}
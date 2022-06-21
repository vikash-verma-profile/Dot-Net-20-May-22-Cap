import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private _productUrl = "https://localhost:44371/api/Product";
  constructor(private http: HttpClient,private _router:Router) { }

  
  getProducts() {
    return this.http.get<any>(this._productUrl);
  }
}

import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { CustomerRoutes } from '../routing/routing.customer';
import { CustomerComponent } from './customer.component';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    CustomerComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forChild(CustomerRoutes)
  ],
  providers: [],
  bootstrap: [CustomerComponent]
})
export class CustomerModule { }

import { Component } from '@angular/core';
import { Customer } from './app.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'first-sample-project';
  myname = 'vikash Verma'
  CustomerModel: Customer = new Customer();
  CustmerModels: Array<Customer> = new Array<Customer>();
  AddCustomer() {
    this.CustmerModels.push(this.CustomerModel);
    this.CustomerModel = new Customer();
  }
  EditCustomer(input: Customer) {
    console.log(input);
  }
  DeleteCustomer(input: Customer) {
    console.log(input);
  }

}

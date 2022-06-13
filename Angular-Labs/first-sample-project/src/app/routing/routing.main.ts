import { CustomerComponent } from "../customer/customer.component";
import { HomeComponent } from "../home/home.component";
import { SupplierComponent } from "../supplier/supplier.component";

export const MainRoutes= [
    {path:'',component:HomeComponent},
    {path:'home',component:HomeComponent},
    {path:'customer',component:CustomerComponent},
    {path:'supplier',component:SupplierComponent}
];

import { CustomerComponent } from "../customer/customer.component";
import { HomeComponent } from "../home/home.component";
import { SupplierComponent } from "../supplier/supplier.component";

export const MainRoutes= [
    {path:'',component:HomeComponent},
    {path:'home',component:HomeComponent},
    {path:'customer',loadChildren:()=>import('../customer/customer.module').then(m=>m.CustomerModule)},
    {path:'supplier',loadChildren:()=>import('../supplier/supplier.module').then(m=>m.SupplierModule)}
];

import "bootstrap-daterangepicker"
import { DataService } from '../../../services/dataservices';
import { autoinject } from 'aurelia-framework';
import { UserViewModel } from '../../../models/userviewmodel'

@autoinject()
export class Register{
    private user:UserViewModel;
    private confirmPassword:string;
    private dataService:DataService;

    constructor(dataService: DataService) {
        this.dataService = dataService;
        this.dataService.setBaseUri("account");

        this.user =  new UserViewModel();        
    }

    attached(){
        jQuery("#birthdate").daterangepicker({
            singleDatePicker: true
        }).on("change", o => {
            this.user.BirthDate = (o.target as HTMLInputElement).value;
        });
    }
 
    submit(){
        console.log(this.user);
        //this.dataService.delete("delete/1234");
    }
}
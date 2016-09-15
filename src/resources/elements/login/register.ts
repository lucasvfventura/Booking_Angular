import "bootstrap-daterangepicker"
import { DataService } from '../../../services/dataservices';
import { autoinject } from 'aurelia-framework';

@autoinject
export class Register{
    private firstName:string;
    private middleName:string;
    private lastName:string;
    private birthDate:string;
    private email:string;
    private password:string;
    private confirmPassword:string;
    private dataService: DataService;

    constructor(dataService: DataService) {
        this.dataService = dataService;
        this.dataService.setBaseUri("account");        
    }

    attached(){
        jQuery("#birthdate").daterangepicker({
            singleDatePicker: true
        });
    }

    submit(){
        this.dataService.delete("delete/1234");
    }
}
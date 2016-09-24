import "bootstrap-daterangepicker"
import { bindable } from 'aurelia-framework'

export class DateRangePicker{

    @bindable
    public dateRange:string;

    @bindable
    public settings:daterangepicker.Settings;
    constructor(){
        this.dateRange = Date.now().toLocaleString();
        this.settings = {};
    }

    bind(){
        this.settings = {
            
        }
    }

    attached(){
        jQuery("#birthdate").daterangepicker(this.settings).on("change", o => {
            this.dateRange = (o.target as HTMLInputElement).value;
        });
    }
}
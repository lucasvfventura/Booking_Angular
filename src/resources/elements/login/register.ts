import "bootstrap-daterangepicker"

export class Register{
    private email:string;
    private password:string;
    private repassword:string;
    private firstName:string;
    private middleName:string;
    private lastName:string;
    private birthDate:string;

    attached(){
        jQuery("#birthdate").daterangepicker({
            singleDatePicker: true
        });
    }

    submit(){
        alert("Registration Complete");
    }
}
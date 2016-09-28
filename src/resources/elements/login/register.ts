import "bootstrap-daterangepicker"
import { DataService } from '../../../services/dataservices';
import { autoinject, NewInstance } from 'aurelia-framework';
import { RegisterViewModel } from '../../../models/registerviewmodel'
import { ValidationController, ValidationRules } from 'aurelia-validation'
import { EventAggregator } from 'aurelia-event-aggregator';

@autoinject()
export class Register{
    private model: RegisterViewModel;
    private dataService: DataService;
    private validation: ValidationController;
    private eventAggregator: EventAggregator;

    constructor(dataService: DataService, validation: ValidationController, eventAggregator: EventAggregator) {
        this.dataService = dataService;
        // TODO: remove hard coded resources Uri`s
        this.dataService.setBaseUri("account");
        this.validation = validation;
        this.model = new RegisterViewModel();
        this.eventAggregator = eventAggregator;

        this.setUpValidation();
    }

    attached() {
        // TODO: separate daterangepicker in a separated element
        jQuery("#birthdate").daterangepicker({
            singleDatePicker: true
        }).on("change", o => {
            this.model.birthDate = (o.target as HTMLInputElement).value;
        });
    }
 
    submit() {
        this.validation.validate().then(errors => {
            if (errors.length == 0) {
                this.dataService.post(this.model)
                    .then(r => {
                        // TODO: remove hard coded event names for a enum
                        this.eventAggregator.publish('user logged in', r);
                    })
                    .catch(error => {
                        // TODO: Remove alert for a better in line error message
                        alert('Error registering user. Try again in a moment!');
                    });
            }
        });
    }

    private setUpValidation() {
        ValidationRules
            .ensure((m: RegisterViewModel) => m.firstName)
            .required()
            .minLength(2)
            .maxLength(100)
            .ensure((m: RegisterViewModel) => m.middleName)
            .maxLength(100)
            .ensure((m: RegisterViewModel) => m.lastName)
            .required()
            .minLength(2)
            .maxLength(100)
            .ensure((m: RegisterViewModel) => m.birthDate)
            .required()
            .ensure((m: RegisterViewModel) => m.email)
            .required()
            .email()
            .ensure((m: RegisterViewModel) => m.password)
            .required()
            .minLength(6)
            .maxLength(100)
            .matches(/[^a-zA-Z\d\s]/).withMessage("Password must contains non-alphanumeric character")
            .matches(/[a-z]/).withMessage("Password must contains at least one lower case character")
            .matches(/[A-Z]/).withMessage("Password must contains at least one upper case character")
            .matches(/[\d]/).withMessage("Password must contains at least one digit")
            .ensure((m: RegisterViewModel) => m.confirmPassword)
            .required()
            .satisfies((value: string, m: RegisterViewModel) => {
                return value == this.model.password;
            }).withMessage("Passwords do not match.")
            .on(this.model);
    }
}
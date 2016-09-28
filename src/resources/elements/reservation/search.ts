import { autoinject } from 'aurelia-framework';
import { DataService } from '../../../services/dataservices';
import { CompanyViewModel } from '../../../models/companyviewmodel';

@autoinject
export class Search{
    private dataService: DataService;
    private companies: CompanyViewModel[];
    private expression: string;

    constructor(dataService: DataService) {
        this.dataService = dataService;

        this.dataService.setBaseUri('company');
    }

    attached() {
        this.dataService.get()
            .then(r => r.json())
            .then(r => {
                this.companies = r as CompanyViewModel[];
            });
    }

    search() {
        this.dataService.get(this.expression != null ? { "expression": this.expression } : null)
            .then(r => r.json())
            .then(r => console.log(r));
    }
}
import { Component, OnInit } from '@angular/core';
import { DataService } from '../../services/data.service';
import { SearchPropertyViewModel } from '../../models/search-property-view-model';

@Component({
    selector: 'app-search',
    templateUrl: './search.component.html',
    styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
    private expression: string;
    private properties: SearchPropertyViewModel[];

    constructor(private service: DataService) {
        this.properties = new Array<SearchPropertyViewModel>();
    }

    ngOnInit() {
        this.search();
    }

    search() {
        this.service.getProperty(this.expression).subscribe(r => {
            this.properties = r.json();
        });
    }
}

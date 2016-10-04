import { Injectable } from '@angular/core';
import { Http, URLSearchParams } from '@angular/http';

@Injectable()
export class DataService {

    private baseUrl = 'api/';
    private propertyUrl = this.baseUrl + 'property';

    constructor(private http: Http) {
    }

    getProperty(query: string) {
        let params = new URLSearchParams();
        params.set('expression', query);
        return this.http.get(this.propertyUrl, { search: params });
    }
}

import 'whatwg-fetch';
import { HttpClient, json } from 'aurelia-fetch-client';
import { autoinject } from 'aurelia-framework';
import { ApiException } from './apiexception'
import { buildQueryString } from 'aurelia-path'

@autoinject()
export class DataService{
    client:HttpClient;
    private baseUri:string;

    constructor(client:HttpClient){
        this.client = client;
        this.client.configure(config => {
            config
                .withBaseUrl('/api/')
                .withDefaults({
                    credentials: 'same-origin',
                    headers: {
                        'Accept': 'application/json',
                        'X-Requested-With': 'Fetch'
                    }
                });
            });
        this.baseUri = "";
    }

    setBaseUri(baseUri:string){
        this.baseUri = baseUri;
    }

    get(query?: Object) {
        if(this.baseUri == "") {
            throw new ApiException("Base uri must be set before using this method");
        }

        return this.client.fetch(query == null ? this.baseUri : `${this.baseUri}?${buildQueryString(query, true)}`);
    }

    getCustomResource(resource:string){
        if(this.baseUri == "") {
            throw new ApiException("Base uri must be set before using this method");
        }
        return this.client.fetch(this.baseUri + resource);
    }

    post(resource:any){
        if(this.baseUri == "") {
            throw new ApiException("Base uri must be set before using this method");
        }
        return this.client.fetch(this.baseUri, { method: "POST", body: json(resource) })
    }

    postCustomResource(resourceUri:string, resource:any){
        if(this.baseUri == "") {
            throw new ApiException("Base uri must be set before using this method");
        }
        return this.client.fetch(
                 this.baseUri + resourceUri, 
                 { method: "POST", body: json(resource) }
               );
    }

    delete(id: string){
        if(this.baseUri == "") {
            throw  new ApiException("Base uri must be set before using this method");
        }
        return this.client.fetch(this.baseUri + `/${id}`, {
            method: "DELETE"
        });
    }

    put(resource:any){
        if(this.baseUri == "") {
            throw  new ApiException("Base uri must be set before using this method");
        }
        return this.client.fetch(this.baseUri, {
            method: "DELETE"
        });
    }
}
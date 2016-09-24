export class ApiException implements ExceptionInformation{
    
    private message : string;
    public get Message() : string {
        return this.message;
    }

    constructor(message:string) {
        this.message = message;
    }
        
}
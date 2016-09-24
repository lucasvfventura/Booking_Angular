export class UserViewModel{   

    private firstName : string;
    public get FirstName() : string {
        return this.firstName;
    }
    public set FirstName(v : string) {
        this.firstName = v;
    }
    
    private middleName : string;
    public get MiddleName() : string {
        return this.middleName;
    }
    public set MiddleName(v : string) {
        this.middleName = v;
    }
    
    private lastName : string;
    public get LastName() : string {
        return this.lastName;
    }
    public set LastName(v : string) {
        this.lastName = v;
    }
    
    private birthDate : string;
    public get BirthDate() : string {
        return this.birthDate;
    }
    public set BirthDate(v : string) {
        this.birthDate = v;
    }
    
    private email : string;
    public get Email() : string {
        return this.email;
    }
    public set Email(v : string) {
        this.email = v;
    }
    
    private password : string;
    public get Password() : string {
        return this.password;
    }
    public set Password(v : string) {
        this.password = v;
    }
}
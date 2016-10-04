import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { RegisterViewModel } from '../../../models/register-view-model';

@Component({
    selector: 'app-register',
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

    private model: RegisterViewModel;
    private registrationForm: FormGroup;

    constructor(private formBuilder: FormBuilder) {
        this.model = new RegisterViewModel();

        this.registrationForm = this.formBuilder.group({
            'firstName': [this.model.firstName, [Validators.required, Validators.minLength(2), Validators.maxLength(10)]]
        });
    }

    ngOnInit() {
        
    }

    submit() {
        console.log(this.registrationForm.controls['firstName'].errors);
    }
}

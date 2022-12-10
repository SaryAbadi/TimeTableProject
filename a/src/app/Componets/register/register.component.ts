import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, FormControl, Validators, ValidatorFn, ValidationErrors } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerForm!: FormGroup;
  userList: any;
  flag!: boolean;
  hide = true;

  constructor(private fb: FormBuilder) {
    
   }

  ngOnInit(): void {
    this.registerForm = this.fb.group({

      'userName': new FormControl('', Validators.required),
      'userPassword': new FormControl('', Validators.required),
      'userPassword1': new FormControl('', [Validators.required, this.chek()])
    })
  }
  getErrorPassword() {

    if (this.registerForm.get('userPassword1')?.value == "")
      return 'שדה זה חובה';
    else if (this.registerForm.get('userPassword1')?.hasError('noMatch'))
      return 'אימות סיסמא אינו תואם לסיסמא'
      return null;

  }
  
  get userPassword1() {
    return this.registerForm.get('userPassword1');
  }
  register() {
    for (var i = 0; i < this.userList.length; i++) {
      if (this.userList[i].userName == this.registerForm.value.userName)
        this.flag = false;
    }
    // לוגיקה של הוספת משתמש

  }

  chek(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      let valid = true;
       if (control.value !== this.registerForm?.get("userPassword")?.value) {
        valid = false;
      }
      return valid ? null : { noMatch: true }
    };
  }
}
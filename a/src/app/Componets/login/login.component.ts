import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/Services/user.service';
import { FormBuilder, FormControl, Validators, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  connect = true;
  userList: any;
  loginForm!: FormGroup;
  flag2=false;
  hide=true;

  constructor(private userService: UserService, private fb: FormBuilder) { 
    
  }

  ngOnInit(): void {
    this.loginForm = this.fb.group({

      'userName': new FormControl('', Validators.required),
      'userPassword': new FormControl('', Validators.required),
      'userPassword1': new FormControl('',Validators.required//, chek('userPassword1')]
      )
    })
  

    // this.userService.getUsers().subscribe((data: any) => {
    //   this.userList = data;
      
    // });
    
  }
  

  onSubmit(): void { this.userService.login() }

  openRegister(){
    this.connect = false

  }

  // register() {
  //   this.connect = false
  // }
  toSignIn() {
    this.connect = true
  }
  login() {

    for (var i = 0; i < this.userList.length; i++) {
      if (this.userList[i].userName == this.loginForm.value.userName && this.userList[i].password == this.loginForm.value.password.value)
        this.flag2 = false; // כניסה
    }
    
      return 'המשתמש לא קיים';

  }}


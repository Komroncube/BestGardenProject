import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { Route, Router } from '@angular/router';
import { IAuthResponse } from '../../Interfaces/auth.interface';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {
  constructor(private authService: AuthService,
      private route: Router) { }

  response :IAuthResponse|undefined;
  /**
   * Submit login form
   */
  submit() {
    this.authService.login(this.loginForm.value).subscribe((response) => {
      this.response = response;
    });
    if (this.response) {
      this.route.navigate(['/home']);
      localStorage.setItem('auth_token', this.response.token);
    }
    else {
      window.alert('Invalid credentials');
    }
  }
  /**
   * Login form
   */
  loginForm: FormGroup = new FormGroup({
    email: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required),
  });
}

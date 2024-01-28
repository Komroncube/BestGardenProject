import { HttpClient } from "@angular/common/http";
import { AuthRequest, IAuthResponse } from "../Interfaces/auth.interface";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs/internal/Observable";
@Injectable({
    providedIn: 'root'
  })
export class AuthService {
    constructor(private http: HttpClient) { }
    authResponse? : IAuthResponse;
    /**
     * 
     * @param authReq 
     * @returns Observable<IAuthResponse|undefined>
     */
    login(authReq: AuthRequest) : Observable<IAuthResponse|undefined> {
        return this.http.post<IAuthResponse>('api/Users/authorize', authReq)
    }
}
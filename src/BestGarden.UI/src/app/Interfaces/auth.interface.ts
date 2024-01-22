export interface IAuthResponse {
    id:number;
    email: string;
    token: string;
}
export interface AuthRequest {
    email: string;
    password: string;
}
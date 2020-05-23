import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from 'src/environments/environment';
import { map } from "rxjs/operators";
import { Usuario } from '../model/usuario.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(
    private httpClient: HttpClient
  ) { }

  private readonly baseUrl = environment["endPoint"];


  getUser(){
    return this.httpClient
    .get<any>(`${this.baseUrl}/user/get-users`)
    .pipe(
      map(response => {
        if (response) {
          return response;
        } else {
          throw new Error(response.Error);
        }
      })
    );
  }

  createUser(user: Usuario) {
    return this.httpClient.post<any>(`${this.baseUrl}/user/create-user`, user);
  };

  updateUser(user: Usuario) {
    return this.httpClient.put<any>(`${this.baseUrl}/user/update-user`, user);
  };

  deleteUser(idUser) {
    return this.httpClient.delete<any>(`${this.baseUrl}/user/delete-user/${idUser}`);
  };

}

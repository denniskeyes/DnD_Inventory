import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataHandlerService {

  constructor(private http: HttpClient) { }

  options = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) }; 

  // Get weapons for given character
  getWeapons(character: string): Observable<Array<string>> {
    return this.http.get<Array<string>>(`./api/controller/get-weapons/{character}`);
  }

  // Get armor for given character
  getArmor(character: string): Observable<Array<string>> {
    return this.http.get<Array<string>>(`./api/controller/get-armor/{character}`);
  }

  // Get accessories for given character
  getAccessories(character: string): Observable<Array<string>> {
    return this.http.get<Array<string>>(`./api/controller/get-accessories/{character}`);
  }

  // Save/update weapon for given character
  saveAccessory(character: string, item: string): Observable<any> {
    return this.http.post<any>(`./api/controller/save-accessory/{character}`, this.options);
  }

  // Save/update weapon for given character
  saveArmor(character: string, item: string): Observable<any> {
    return this.http.post<any>(`./api/controller/save-armor/{character}`, this.options);
  }

  // Save/update weapon for given character
  saveWeapon(character: string, item: string): Observable<any> {
    return this.http.post<any>(`./api/controller/save-weapon/{character}`, this.options);
  }

  // Delete inventory for given character
  deleteData(character: string, item: string): Observable<any> {
    return this.http.delete<any>(`./api/controller/delete-data/{character}/{item}`);
  }
}

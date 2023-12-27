import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Grade } from '../models/grade';
import { environment } from 'src/environments/environment';

// The injectable decorator is used to designate a class one thatis in the DI
// sys we can inject into a class (dependency injection)
@Injectable({
  providedIn: 'root'
})
export class GradesService {

  private apiUrl = environment.baseApiUrl + '/v1/Grade'
  // HttpClient - performs http requests
  constructor(private http: HttpClient) { }

  getGrade(id: number) : Observable<Grade>{
    return this.http.get<Grade>(this.apiUrl +'/' + id);
  }
}

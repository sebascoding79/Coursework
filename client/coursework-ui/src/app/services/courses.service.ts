import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { course } from '../models/course';

@Injectable({
  providedIn: 'root'
})
export class CoursesService {

  private apiUrl = environment.baseApiUrl + '/v1/Courses';

  constructor(private http: HttpClient){
  }

  getCourse(id: number) : Observable<course>{
    return this.http.get<course>(this.apiUrl + '/' + id);
  }

  getCourses(): Observable<course[]>{
    return this.http.get<course[]>(this.apiUrl + '/');
  }
}

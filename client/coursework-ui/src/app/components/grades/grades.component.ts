import { Component, OnDestroy, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { GradesService } from 'src/app/services/grades.service';
import { Grade } from 'src/app/models/grade';
import { Observable, Subscription, of } from 'rxjs';

@Component({
  selector: 'grades',
  templateUrl: './grades.component.html',
  styleUrls: ['./grades.component.css']
})
export class GradesComponent implements OnInit, OnDestroy{
  // Define instance variables
  grade!: Grade | undefined; // ! = will assign later
  subscription!: Subscription | undefined;
  // $ -> means variable is an observable stream of values
  gradesSample$ = of(1,'344',34);
  // this above obseravable wont emit values until you subscribe to it

  // Here we need to inject the service
  constructor(private gradesService: GradesService){
  }

  ngOnInit(): void{
    this.loadGrade();
    this.testMethod();
  }

  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
  }

  loadGrade(): void{
    // when we subscribe we return a "Subscription" data type
    // FYI - the  {} is actually an observer object with the 
    // three properties with handlers: next, error, complete 
    this.subscription = this.gradesService.getGrade(1).subscribe({
        // The observable function getGrade is only called when we 
        // subscribe to that observable with the subscribe method
        // Whatever comes from the observable, what do we do with it {...}
        next : gradeFromService => this.grade = gradeFromService,
        error: err => console.log(err)
    });
  }

  testMethod(): void{
    this.gradesSample$.subscribe({
      next: num => console.log(num)
    })
  }
}

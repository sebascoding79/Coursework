import { Component } from '@angular/core';
import { course } from 'src/app/models/course';
import { CoursesService } from 'src/app/services/courses.service';
import { OnInit, OnDestroy, OnChanges } from '@angular/core';

@Component({
  selector: 'courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css']
})
export class CoursesComponent implements OnInit{
  courses!: course[];
  constructor(private courseService: CoursesService){  }

  ngOnInit(): void {
    this.courseService.getCourses().subscribe({
      next: courses => this.courses = courses,
      error: err => console.log(err)
    });
  }
}

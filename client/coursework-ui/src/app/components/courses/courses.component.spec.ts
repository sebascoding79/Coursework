import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { CoursesComponent } from './courses.component';
import { HttpClient } from '@angular/common/http';
import { course } from 'src/app/models/course';

describe('CoursesComponent', () => {
  let component: CoursesComponent;
  let fixture: ComponentFixture<CoursesComponent>;

  const courses: course[] = [
    {
      id: 1,
      cid: 'Test01',
      cname: 'Testing course 1',
      semester: 'Fall',
      year: 2023,
      grade: 'A'
    }
  ];

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CoursesComponent],
      imports: [HttpClientTestingModule]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CoursesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render one row', () => {
    component.courses = courses;
    fixture.detectChanges(); // To do the data binding

    const rows = fixture.nativeElement.querySelector('tbody tr');
    expect(rows.length).toBe(1);
  })
});

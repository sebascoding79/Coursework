import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SemesterComponent } from './components/semester/semester.component';

const routes: Routes = [
  {path: 'possible-semester', component: SemesterComponent}
];

// '' for path indicates an empty path so basically the landing page
// ** indicates the wildcard so pretty much any route that is not one
// of the routes in the defined route array

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

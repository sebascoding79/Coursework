import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GradesComponent } from './components/grades/grades.component';
import { HttpClientModule } from '@angular/common/http';
import { SemesterComponent } from './components/semester/semester.component';

// Declarations are for components we need to have at our disposal, pipes, directives
// Imports - for bringing in other modules (with their components) as needed
// and its children will need like the routing module and the httpclient module
@NgModule({
  declarations: [
    AppComponent,
    GradesComponent,
    SemesterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

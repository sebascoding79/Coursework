import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CoursesComponent } from './components/courses/courses.component';

// Declarations are for components we need to have at our disposal, pipes, directives
// Imports - for bringing in other modules (with their components) as needed
// and its children will need like the routing module and the httpclient module
@NgModule({
  declarations: [
    AppComponent,
    CoursesComponent,
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

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule}   from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DivisionPipe } from './division.pipe';
import { CustompipeComponent } from './custompipe/custompipe.component';
import { StrformatPipe } from './strformat.pipe';
import { RepeatPipe } from './repeat.pipe';
import { WordcountPipe } from './wordcount.pipe';
import { ToggleButtonComponent } from './toggle-button/toggle-button.component';

@NgModule({
  declarations: [
    AppComponent,
    DivisionPipe,
    CustompipeComponent,
    StrformatPipe,
    RepeatPipe,
    WordcountPipe,
    ToggleButtonComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

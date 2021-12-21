import { Component, OnInit,Output,EventEmitter } from '@angular/core';
import { Person } from '../person';
import { DivisionPipe } from '../division.pipe';


@Component({
  selector: 'app-custompipe',
  templateUrl: './custompipe.component.html',
  styleUrls: ['./custompipe.component.css']
})
export class CustompipeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  
  dividend : number = 23;
	divisor : number = 7;

  message: string = "My name is Mahesh";

  str:string='Manasi';
  customText: string = "Hello World.This is to Angular Custom Pipe Assignment .";

  person: Person = new Person(1, 'Ram', 30);

  
}

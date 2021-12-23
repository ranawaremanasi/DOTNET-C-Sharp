import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-toggle-button',
  templateUrl: './toggle-button.component.html',
  styleUrls: ['./toggle-button.component.css']
})
export class ToggleButtonComponent implements OnInit {

  person:any[];
color:any='black';
  constructor() {
    //this.car=[]
    this.person=[{Id:'CR2002',person_Name:'Aditi G.',person_City:'Banglore',Person_Salary:'5000000'},
    {Id:'CR2002',person_Name:'Aditi G.',person_City:'Mumbai',Person_Salary:'6000000' },
    {Id:'CR2002',person_Name:'Aditi G.',person_City:'Pune',Person_Salary:'9000000'}
  ]
   }
  ngOnInit(): void {
  }

  private selectedLink: string="On";        
  
    setradio(e: string): void   
  {  
  
        this.selectedLink = e;  
          
  }  
  
    isSelected(name: string): boolean   
  {  
  
        if (!this.selectedLink) { // if no radio button is selected, always return false so every nothing is shown  
            return false;  
  }  
  
        return (this.selectedLink === name); // if current radio button is selected, return true, else return false  
    }   
   
}

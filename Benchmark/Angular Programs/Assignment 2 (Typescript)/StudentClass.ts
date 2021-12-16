class Student
{
    rollno:number;
    stud_name:string;
    math:number;
    phy:number;
    che:number;
    per:number;
    constructor(rollno:number,sname:string,m1:number,m2:number,m3:number)
    {
        this.rollno=rollno;
        this.stud_name=sname;
        this.math=m1;
        this.phy=m2;
        this.che=m3;
    }

    calculate():void{
        this.per=(this.math+this.phy+this.che)/3;
       // console.log(this.per);
    }
    display():void{

       console.log("RollNo"+" "+"StudName"+" "+"Math"+" "+" PHY"+" "+"Che"+"   PER"); 
console.log(this.rollno+"     "+this.stud_name+"    "+this.math+"     "+this.phy+"    "+this.che+"     "+this.per)
    }

}

let stud=new Student(1,'Manasi',90,99,78);
stud.calculate();
stud.display();

function percentage():void{

let marks=[90,99,78];
 
let max_marks = marks.length * 100;
 
let total = 0;
 
        let grade = 'F';
   
        for (let i = 0; i < marks.length; i++) {
            total += marks[i];
        }
   
        let percentage
            = ((total) / max_marks) * 100;
   
        if (percentage >= 90) {
            grade = 'A';
        }
        else {
            if (percentage >= 80 && percentage <= 89) {
                grade = 'B';
            }
            else {
                if (percentage >= 60 && percentage <= 79) {
                    grade = 'C';
                }
                else {
                    if (percentage >= 33 && percentage <= 59) {
                        grade = 'D';
                    }
                    else {
                        grade = 'F';
                    }
                }
            }
        }console.log(percentage+" "+grade);
    }percentage();
         

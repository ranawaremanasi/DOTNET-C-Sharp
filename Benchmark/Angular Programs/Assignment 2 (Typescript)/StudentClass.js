var Student = /** @class */ (function () {
    function Student(rollno, sname, m1, m2, m3) {
        this.rollno = rollno;
        this.stud_name = sname;
        this.math = m1;
        this.phy = m2;
        this.che = m3;
    }
    Student.prototype.calculate = function () {
        this.per = (this.math + this.phy + this.che) / 3;
        // console.log(this.per);
    };
    Student.prototype.display = function () {
        console.log("RollNo" + " " + "StudName" + " " + "Math" + " " + " PHY" + " " + "Che" + "   PER");
        console.log(this.rollno + "     " + this.stud_name + "    " + this.math + "     " + this.phy + "    " + this.che + "     " + this.per);
    };
    return Student;
}());
var stud = new Student(1, 'Manasi', 90, 99, 78);
stud.calculate();
stud.display();
function percentage() {
    var marks = [90, 99, 78];
    var max_marks = marks.length * 100;
    var total = 0;
    var grade = 'F';
    for (var i = 0; i < marks.length; i++) {
        total += marks[i];
    }
    var percentage = ((total) / max_marks) * 100;
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
    }
    console.log(percentage + " " + grade);
}
percentage();

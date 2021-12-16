// 6)write a employee class with data constructor
// eid
// empname
// deptno
// salary
// HRA
// DA
// gross salary
// calculate gross salary on the base of
// if basic salary <20000 then HRA 20% and  DA  80%
// if basic salary   >20000 and<35000 then HRA 25% and DA 70%
var Employee = /** @class */ (function () {
    function Employee(eid, ename, deptno) {
        this.eid = eid;
        this.ename = ename;
        this.deptno = deptno;
    }
    Employee.prototype.display = function () {
        console.log("eid" + "  " + " eName" + "  " + "  deptno" + "   " + "   ");
        console.log(this.eid + "     " + this.ename + "    " + this.deptno + "     ");
    };
    Employee.prototype.calculatesal = function () {
        var bs = 5500, gs, da, hra;
        console.log("Enter basic salary\n" + bs + " ");
        if (bs < 20000) {
            hra = bs * 20 / 100;
            da = bs * 80 / 100;
        }
        else if (bs > 20000 && bs < 35000) {
            hra = bs * 25 / 100;
            da = bs * 70 / 100;
        }
        else {
            hra = 600;
            da = bs * 95 / 100;
        }
        gs = bs + da + hra;
        console.log("Gross Salary is Rs \n" + gs);
    };
    return Employee;
}());
var emp = new Employee(1, "Manasi", "1001_Management");
emp.display();
emp.calculatesal();

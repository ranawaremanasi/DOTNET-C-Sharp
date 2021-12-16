// 8)write a class product
// pid
// pname
// amount
// discount
// qty
// calculate discount  

class Product
{
    pid:number;
    pname:string;
    amount:number;
    discount:number;
    qty:number;
    calculate_discount:number;
    constructor(pid:number,pname:string,a:number,d:number,qty:number)
    {
        this.pid=pid;
        this.pname=pname;
        this.amount=a;
        this.discount=d;
        this.qty=qty;
    }

    display():void{

       console.log("pid"+"  "+" pName"+"  "+"  Amount"+"   "+"   discount"+" "+"   qty"+"  "); 
console.log(this.pid+"     "+this.pname+"    "+this.amount+"     "+this.discount+"    "+this.qty+"     ");
    }

}

let pro=new Product(1,'Aloevera',6000,0.05,6);
pro.display();

function calculateDiscount(amount:number):any{
var quantity:number=6;
var price:number=6000;
var discount:number;


	amount=quantity*price;

	if(amount>5000)

	{

		discount=amount*0.10;


	}
	
	else if(amount > 1000)
	{
		discount=amount*0.05;

	}
	else
	{
		discount=0;
	}
	console.log("Enter quantity and price:"+quantity+" "+price)
	amount = amount - discount;
	console.log("Final amount is"+amount);
	
	
}
calculateDiscount(6000);
// console.log(calculateDiscount(6000));
	
	
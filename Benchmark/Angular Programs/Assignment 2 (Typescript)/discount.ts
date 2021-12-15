//   //2) write function to calculate to find discountedbill from billamount as per given condition
//   If amount is <10000 the 5%
//   if amount is>10000 and  <20000 the 10%
//   if amount is >20000 and  <30000 the 15%
//    If amount is >30000 the 25%
 
  
  
    var amount:number=15000;
    var discount:number;
	
	if(amount>10000)

	{

		discount=amount*0.05;


	}
	
	else if(amount > 10000 && amount <20000)
	{
		discount=amount*0.10;

	}
    else if(amount > 20000 && amount <30000)
	{
		discount=amount*0.15;

	}
	else if (amount > 30000)
	{
		discount=amount*0.25;
	}
    else 
    {
        discount=0;
    }
	amount = amount - discount;
	console.log("amount is"+amount);
	
	
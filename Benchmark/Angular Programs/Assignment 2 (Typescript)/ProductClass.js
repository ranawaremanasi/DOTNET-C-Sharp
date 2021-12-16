// 8)write a class product
// pid
// pname
// amount
// discount
// qty
// calculate discount  
var Product = /** @class */ (function () {
    function Product(pid, pname, a, d, qty) {
        this.pid = pid;
        this.pname = pname;
        this.amount = a;
        this.discount = d;
        this.qty = qty;
    }
    Product.prototype.display = function () {
        console.log("pid" + "  " + " pName" + "  " + "  Amount" + "   " + "   discount" + " " + "   qty" + "  ");
        console.log(this.pid + "     " + this.pname + "    " + this.amount + "     " + this.discount + "    " + this.qty + "     ");
    };
    return Product;
}());
var pro = new Product(1, 'Aloevera', 6000, 0.05, 6);
pro.display();
function calculateDiscount(amount) {
    var quantity = 6;
    var price = 6000;
    var discount;
    amount = quantity * price;
    if (amount > 5000) {
        discount = amount * 0.10;
    }
    else if (amount > 1000) {
        discount = amount * 0.05;
    }
    else {
        discount = 0;
    }
    console.log("Enter quantity and price:" + quantity + " " + price);
    amount = amount - discount;
    console.log("amount is" + amount);
}
calculateDiscount(6000);
// console.log(calculateDiscount(6000));

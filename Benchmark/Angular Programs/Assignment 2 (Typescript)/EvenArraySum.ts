//5) find the Array even  element sum and return it.

function EvenArraySum(){
var arr=[5,10,15,20,25,30];
var i,oddSum=0,evenSum=0;
for(i=0; i<6; i++){
    if(arr[i]%2==0){
    evenSum=evenSum+arr[i];
    }
else{
         oddSum=oddSum+arr[i];
    }
}
console.log("The sum of odd numbers are: %d",oddSum);
console.log("\nThe sum of even numbers are: %d",evenSum);
}
EvenArraySum();


// function EvenArraySum(arr, n)
// {
//     let even = 0;
//     let odd = 0;
//     for (let i:number = 0; i < n; i++)
//     {
//         if (i % 2 == 0)
//             even += arr[i];
//         else
//             odd += arr[i];
//     }
 
//     console.log("Even index positions sum " + even);
//     console.log
//     console.log("<br>" + "Odd index positions sum " + odd);
// }
 
//     let arr = [ 1, 2, 3, 4, 5, 6 ];
//     let n = arr.length;
 
//     EvenArraySum(arr, n);
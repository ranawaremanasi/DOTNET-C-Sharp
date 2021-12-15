//4)write a function to find max of  array number function should take array as a parameter  and return max value

function getMaxOfArray(numArray:number[]) {
    return Math.max.apply(null, numArray);
  }

  var numArray=[1,33,3,4,54,3,1];
  console.log(getMaxOfArray(numArray));

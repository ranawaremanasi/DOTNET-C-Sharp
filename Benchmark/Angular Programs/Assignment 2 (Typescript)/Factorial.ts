//3)write a function to find a factorial of number

function factorial(num: number) : number {
    if (num == 0) return 1
    else return num * factorial(num - 1)
}

console.log(factorial(5))

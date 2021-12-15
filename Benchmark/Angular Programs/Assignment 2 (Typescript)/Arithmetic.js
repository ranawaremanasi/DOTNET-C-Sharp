function calculate(num1, num2, op) {
    if (op.charAt(0) == '+') {
        return num1 + num2;
    }
    else if (op.charAt(0) == '-') {
        return num1 - num2;
    }
    else if (op.charAt(0) == '*') {
        return num1 * num2;
    }
    else if (op.charAt(0) == '/') {
        if (num2 != 0) {
            return num1 / num2;
        }
        else {
            return 0;
        }
    }
    else {
        return 'invalid';
    }
}
console.log(calculate(6, 2, '/'));
console.log(calculate(2, 3, '+'));
console.log(calculate(6, 2, '-'));
console.log(calculate(6, 2, '*'));
console.log(calculate(6, 2, '('));

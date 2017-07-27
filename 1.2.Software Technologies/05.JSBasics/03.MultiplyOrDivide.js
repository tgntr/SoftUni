function solve(n) {
    let num1 = Number(n[0]);
    let num2 = Number(n[1]);
    if (num2 >= num1) {
        return num1 * num2;
    }
    else {
        return num1 / num2;
    }
}
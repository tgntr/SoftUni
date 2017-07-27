function solve(n) {
    let num = Number(n);
    let numbers = [];
    for (let i = num; i >= 1; i--) {
        numbers.push(i);
    }
    return numbers.join("\n");
}
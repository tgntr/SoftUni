function solve(n) {
    let num = Number(n[0]);
    let numbers = [];
    for (let i = 1; i <= num; i++) {
        numbers.push(i);
    }
    return numbers.join("\n");
}
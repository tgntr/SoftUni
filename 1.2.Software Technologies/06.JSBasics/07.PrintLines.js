function solve(n) {
    let index = 0;
    let numbers = [];
    while (n[index] !== "Stop") {
        numbers.push(n[index]);
        index ++;
    }
    return numbers.join("\n");
}
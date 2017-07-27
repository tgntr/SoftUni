function solve (n) {
    let negativeNums = n.map(Number).filter(x=> x <= 0);
    if (negativeNums.includes(0) || negativeNums.length % 2 === 0) {
        return "Positive";
    }
    else {
        return "Negative";
    }
}
function solve (n) {
    let a = Array.apply(null, Array(Number(n[0]))).map(function() { return 0 });
    for (let i = 1; i < n.length; i ++) {
        let input = n[i].split(" - ").map(Number);
        a[input[0]] = input[1];
    }
    return a.join("\n");
}

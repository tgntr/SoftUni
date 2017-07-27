function solve (n) {
    let pairs = [];
    for (let i = 0; i < n.length - 1; i ++) {
        let input = n[i].split(" ");
        let key = input[0];
        let value = input[1];
        if (pairs.hasOwnProperty(key)) {
            pairs[key] += " " + value;
        }
        else {
            pairs[key] = value;
        }
    }
    let key = n[n.length - 1];
    if (pairs.hasOwnProperty(key)) {
        return pairs[key].split(" ").join("\n");
    }
    else return "None";
}


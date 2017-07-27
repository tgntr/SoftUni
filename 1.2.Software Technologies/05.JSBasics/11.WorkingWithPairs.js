function solve (n) {
let pairs = [];
for (let i = 0; i < n.length - 1; i ++) {
        let input = n[i].split(" ");
        pairs[input[0]] = input[1];
    }
    let key = n[n.length - 1];
    if (pairs.hasOwnProperty(key)) {
        return pairs[key];
    }
    else return "None";;
}


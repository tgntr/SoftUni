function solve (n) {
    let obj = {};
    for (let i = 0; i< n.length; i++) {
        let pair = n[i].split(" -> ");
        if (pair[0] === "age" || pair[0] === "grade") {
            obj[pair[0]] = Number(pair[1]);
        }
        else {
            obj[pair[0]] = pair[1];
        }
    }
    return JSON.stringify(obj);
}
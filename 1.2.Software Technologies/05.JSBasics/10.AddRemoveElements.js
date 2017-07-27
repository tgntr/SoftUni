function solve (n) {
    let elements = [];
    for (let i = 0; i < n.length; i ++) {
        let input = n[i].split(" ");
        if (input[0] === "add"){
            elements.push(input[1]);
        }
        else {
            let index = Number(input[1]);
            if (index >= 0 && index < elements.length) {
                elements.splice(index, 1);
            }
        }
    }
    return elements.join("\n");
}
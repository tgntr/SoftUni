function solve (n) {
    for (let i = 0; i< n.length; i++) {
        let obj = JSON.parse(n[i]);
        console.log("Name: " + obj['name'] + "\nAge: " + obj['age'] +  "\nDate: "+ obj['date']);

    }
}
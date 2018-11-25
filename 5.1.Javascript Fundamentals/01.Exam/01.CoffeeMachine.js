function coffeeMachine (arr) {
    let totalIncome = 0;
    for (let line of arr) {
        let currentLine = line.split(', ');
        let insertedMoney = +currentLine[0];
        let drink = currentLine[1];
        let price = 0;
        
        if (drink === "coffee") {
            let coffeeType = currentLine[2];
            if (coffeeType === "decaf") {
                price = 0.9;
            } else {
                price = 0.8;
            }
        } else {
            price = 0.8;
        }

        let milk = currentLine.indexOf("milk");
        let sugar = +currentLine.pop();
        
        if (milk >= 0) {
            price += +(price*0.1).toFixed(1);
        }

        if (sugar > 0) {
            price += 0.1;
        }

        if (insertedMoney >= price) {
            let change = (insertedMoney - price).toFixed(2);
            totalIncome += price;
            console.log(`You ordered ${drink}. Price: ${price.toFixed(2)}$ Change: ${change}$`);
        } else {
            let needMore = (price - insertedMoney).toFixed(2);
            console.log(`Not enough money for ${drink}. Need ${needMore}$ more.`)
        }
    }

    console.log(`Income Report: ${totalIncome.toFixed(2)}$`);
}

coffeeMachine (['1.00, coffee, caffeine, milk, 4', '0.40, tea, milk, 2',
'1.00, coffee, decaf, 0']
);
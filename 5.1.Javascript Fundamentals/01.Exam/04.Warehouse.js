function warehouse(arr) {
    let warehouse = new Map();
    for (let line of arr) {
        let [command, brand, coffee, date, quantity] = line.split(', ');;
        if (command === "IN") {
            if (!warehouse.has(brand)) {
                warehouse.set(brand, new Map());
            }
            if (!warehouse.get(brand).has(coffee)) {
                warehouse.get(brand).set(coffee, {"date": date, "quantity": quantity});
            } else {
                let currentCoffee = warehouse.get(brand).get(coffee);
                let currentDate = currentCoffee["date"];
                if (new Date(currentDate) < new Date(date)) {
                    currentCoffee["date"] = date;
                    currentCoffee["quantity"] = quantity;
                } else if(new Date(currentDate) === new Date(date)) {
                    currentCoffee["quantity"] += quantity;
                }
            }
        } else if (command === "OUT") {
            let currentCoffee = undefined;
            if (warehouse.has(brand)) {
                currentCoffee = warehouse.get(brand).get(coffee);
            }
            if (currentCoffee === undefined) {
                continue;
            }

            if (new Date(currentCoffee["date"]) > new Date(date) && currentCoffee["quantity"] >= quantity) {
                currentCoffee["quantity"] -= quantity;
            }


        } else if (command === "REPORT") {
            console.log(">>>>> REPORT! <<<<<");
            for (let [brand, coffees] of [...warehouse]) {
                console.log(`Brand: ${brand}:`);
                for (let coffee of [...coffees]) {
                    console.log(`-> ${coffee[0]} -> ${coffee[1]["date"]} -> ${coffee[1]["quantity"]}.`);
                }
            }

        } else {
            console.log(">>>>> INSPECTION! <<<<<");

            let sortedWarehouse = [...warehouse].sort((a,b) => a[0].localeCompare(b[0]));
            for (let [brand, coffees] of sortedWarehouse) {
                console.log(`Brand: ${brand}:`);

                let sortedCoffees = [...coffees].sort((a,b) => b[1]["quantity"] - a[1]["quantity"]);
                for (let coffee of sortedCoffees) {
                    console.log(`-> ${coffee[0]} -> ${coffee[1]["date"]} -> ${coffee[1]["quantity"]}.`);
                }
            }
        }
    }
}

warehouse([
    "IN, Batdorf & Bronson, Espresso, 2025-05-25, 20",
    "IN, Folgers, Black Silk, 2023-03-01, 14",
    "IN, Lavazza, Crema e Gusto, 2023-05-01, 5",
    "IN, Lavazza, Crema e Gusto, 2023-05-02, 5",
    "IN, Folgers, Black Silk, 2022-01-01, 10",
    "IN, Lavazza, Intenso, 2022-07-19, 20",
    "OUT, Dallmayr, Espresso, 2022-07-19, 5",
    "OUT, Dallmayr, Crema, 2022-07-19, 5",
    "OUT, Lavazza, Crema e Gusto, 2020-01-28, 2",
    "REPORT",
    "INSPECTION",
  ]
  
  )
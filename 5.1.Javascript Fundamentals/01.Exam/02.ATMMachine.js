function ATM (arr) {
    let banknotes = [0];

    for (let line of arr) {
        if (line.length > 2) {
            let inserted = line.reduce((a,b) => a+b);
            banknotes = banknotes.concat(line);
            let total = banknotes.reduce((a,b) => a+b);
            console.log(`Service Report: ${inserted}$ inserted. Current balance: ${total}$.`);
        } 
        else if (line.length === 2) {
            let [currentBalance, withdrawAmount] = line;
            if (currentBalance < withdrawAmount) {
                console.log(`Not enough money in your account. Account balance: ${currentBalance}$.`);
                continue;
            }
            
            let atmBalance = banknotes.map(Number).reduce((a,b) => a+b);

            if (withdrawAmount > atmBalance) {
                console.log(`ATM machine is out of order!`);
                continue;
            }

            banknotes = banknotes.sort((a,b) => b-a);

            let leftToWithdraw = withdrawAmount;

            for (let index in banknotes) {
                if (leftToWithdraw >= banknotes[index] && banknotes[index] !== 0) {
                    leftToWithdraw -= banknotes[index];
                    banknotes[index] = 0;
                }
                if (!leftToWithdraw) { 
                    break;
                }
            }

            console.log(`You get ${withdrawAmount}$. Account balance: ${currentBalance - withdrawAmount}$. Thank you!`)
        } else {
            let [banknoteToReport] = line;

            let amountAvalailable = banknotes.filter(a => a === banknoteToReport).length;
            console.log(`Service Report: Banknotes from ${banknoteToReport}$: ${amountAvalailable}.`)
        }
    }
}

ATM([[20, 5, 100, 20, 1],
    [457, 25],
    [1],
    [10, 10, 5, 20, 50, 20, 10, 5, 2, 100, 20],
    [20, 85],
    [5000, 4500],
   ]
   );
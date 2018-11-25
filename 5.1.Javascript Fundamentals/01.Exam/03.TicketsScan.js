function ticketsScan (input, info) { 
    let namePattern = /\s[A-Z][A-Za-z]*-[A-Z][A-Za-z]*(\.-[A-Z][A-Za-z]*)?\s/;
    let airportPattern = /\s[A-Z]{3}\/[A-Z]{3}\s/;
    let flightPattern = /\s[A-Z]{1,3}[0-9]{1,5}\s/;
    let companyPattern = /-\s([A-Z][A-Za-z]*)\*([A-Z][A-Za-z]*)\s/;

    if (info === "name") {
        let name = input.match(namePattern)[0].trim().split('-').join(' ');
        console.log(`Mr/Ms, ${name}, have a nice flight!`);
    } else if (info === "flight") {
        let flightNumber = input.match(flightPattern)[0].trim();
        let [departureAirport, arrivalAirport] = input.match(airportPattern)[0].trim().split('/');
        console.log(`Your flight number ${flightNumber} is from ${departureAirport} to ${arrivalAirport}.`);
    } else if (info === "company") {
        let company = input.match(companyPattern);
        let companyName = company[1] + " " + company[2];
       console.log(`Have a nice flight with ${companyName}.`);
    } else {
        let name = input.match(namePattern)[0].trim().split('-').join(' ');
        let flightNumber = input.match(flightPattern)[0].trim();
        let [departureAirport, arrivalAirport] = input.match(airportPattern)[0].trim().split('/');
        let company = input.match(companyPattern);
        let companyName = company[1] + " " + company[2];
        console.log(`Mr/Ms, ${name}, your flight number ${flightNumber} is from ${departureAirport} to ${arrivalAirport}. Have a nice flight with ${companyName}.`)
    }
}
ticketsScan('ahah Second-Testov )*))&&ba SOF/VAR ela** FB973 - Bulgaria*Air -opFB900 pa-SOF/VAr//_- T12G12 STD08:45  STA09:35 ', 'all');
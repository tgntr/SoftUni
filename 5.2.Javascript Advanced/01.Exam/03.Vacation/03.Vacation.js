class Vacation {
    constructor(organizer, destination, budget) { 
        this.organizer = organizer;
        this.destination = destination;
        this.budget = budget;
        this.kids = {};
    }

    registerChild(name, grade, budget) {
        if (!this.kids.hasOwnProperty(grade)) {
            this.kids[grade] = [];
        }

        if (budget < this.budget) { 
            return `${name}'s money is not enough to go on vacation to ${this.destination}.`
        }

        let gradeContainsKid = this.kids[grade].filter(k=>k.split('-')[0] === name);

        if (gradeContainsKid.length > 0) {
            return `${name} is already in the list for this ${this.destination} vacation.`
        }

        this.kids[grade].push(`${name}-${budget}`);

        return this.kids[grade];
    }

    removeChild(name, grade) {
        let gradeContainsKid = this.kids[grade].filter(k=>k.split('-')[0] === name);

        if (gradeContainsKid.length === 0) { 
            return `We couldn't find ${name} in ${grade} grade.`;
        }

        this.kids[grade] = this.kids[grade].filter(k=>k.split('-')[0] !== name);

        return this.kids[grade];
    }

    toString() {
        if (Object.keys(this.kids).length === 0) {
            return `No children are enrolled for the trip and the organization of ${this.organizer} falls out...`;
        }

        let output = `${this.organizer} will take ${this.numberOfChildren} children on trip to ${this.destination}\n`

        Object.keys(this.kids).sort((a,b)=> a-b).forEach(grade=> {
            output += `Grade: ${grade}`;

            let currentKidNumber = 1;

            this.kids[grade].forEach(kid=> {
                output += `\n${currentKidNumber++}. ${kid}`;
            })
            output += '\n';
        })

        return output;
    }

    get numberOfChildren() {
        let count = 0;
        Object.keys(this.kids).forEach(g=>count += this.kids[g].length);

        return count;
    }
}

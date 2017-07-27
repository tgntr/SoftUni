function solve (n) {
    function student (name, age, grade) {
        return console.log("Name: " + name + "\nAge: " + age +  "\nGrade: "+ grade);
    }
    for (let i = 0; i<n.length; i++) {
        let studentInfo = n[i].split(" -> ");
        student(studentInfo[0], studentInfo[1], studentInfo[2]);
    }
}



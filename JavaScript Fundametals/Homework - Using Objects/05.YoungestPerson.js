function solve(args) {
    var data = args;
    var dataLength = data.length;
    var people = [];

    for (var i = 0; i < dataLength; i += 3) {
        people.push({
            firstName: data[i],
            lastName: data[i + 1],
            age: +data[i + 2]
        });
    }

    people.sort(function(p1, p2) {
        return p1.age - p2.age;
    });

    console.log(people[0].firstName + " " + people[0].lastName);
}

//solve(['Gosho', 'Petrov', '56', 'Bay', 'Ivan', '81', 'John', 'Doe', '42']);
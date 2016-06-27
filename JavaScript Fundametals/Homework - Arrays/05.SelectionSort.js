function solve(args) {
    var numbers = args[0].split("\n").map(Number);
    var position = 0;
    var smallest = Number.MAX_VALUE;
    //debugger;


    for (var j = 0; j < numbers.length; j += 1) {
        for (var k = j + 1; k < numbers.length; k += 1) {
            if (numbers[k] < smallest) {
                smallest = numbers[k];
                position = k;
            }
        }
        numbers.splice(position, 1);
        numbers.unshift(smallest);
        smallest = Number.MAX_VALUE;
    }
    numbers.shift();
    numbers.reverse();
    console.log(numbers.join('\n'));
}

//solve(['6\n3\n4\n1\n5\n2\n6']);
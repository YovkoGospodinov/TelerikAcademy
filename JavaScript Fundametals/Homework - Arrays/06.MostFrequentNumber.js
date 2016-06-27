function solve(args) {
    var input = args[0].split("\n");
    var length = input[0];
    var numbers = [];

    var lengthFrequence = 1;
    var maxFrequentNumber;
    var currentFrequence = 1;

    for (var i = 0; i < length; i += 1) {
        numbers.push(parseInt(input[i + 1]));
    }

    for (var i = 0; i < length; i += 1) {
        var currentNumber = numbers[i];
        for (var j = i + 1; j < length; j += 1) {
            if (currentNumber === numbers[j]) {
                currentFrequence += 1;
            }
        }
        if (currentFrequence > lengthFrequence) {
            lengthFrequence = currentFrequence;
            maxFrequentNumber = currentNumber;
        }
        currentFrequence = 1;
    }
    //debugger;

    return maxFrequentNumber + " (" + lengthFrequence + " times)";
}

//solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);
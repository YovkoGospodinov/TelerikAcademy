function solve(args) {
    var numbers = args[0].split("\n");
    var lenght = +numbers[0];
    var currentSequence = 1;
    var maxSequence = 1;

    for (var i = 1; i < lenght; i += 1) {
        if (parseInt(numbers[i]) < parseInt(numbers[i + 1])) {
            currentSequence += 1;
        } else {
            currentSequence = 1;
        }

        if (currentSequence > maxSequence) {
            maxSequence = currentSequence;
        }
    }

    return maxSequence;
}
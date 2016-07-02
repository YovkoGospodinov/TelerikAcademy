function solve(args) {
    var input = args[0];
    var openningBracket = 0;
    var closingBracket = 0;

    var indexOfOpenningBracket = input.indexOf("(");
    var indexOfClosingBracket = input.indexOf(")");



    for (var index in input) {
        if (input[index] === "(") {
            openningBracket += 1;
        } else if (input[index] === ")") {
            closingBracket += 1;
        }
    }
    if (openningBracket === closingBracket &&
        indexOfOpenningBracket < indexOfClosingBracket) {
        return "Correct";
    } else {
        return "Incorrect";
    }
}
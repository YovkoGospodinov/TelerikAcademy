function GetMax(args) {
    var input = args[0].split(" ").map(Number);
    var firstNumber = input[0];
    var secondNumber = input[1];
    var thirdNumber = input[2];
    
    var biggerNumber;

    if (firstNumber > secondNumber && firstNumber >thirdNumber) {
        biggerNumber = firstNumber;
    }
    else if (secondNumber > firstNumber && secondNumber > thirdNumber) {
        biggerNumber = secondNumber;
    }
    else {
        biggerNumber = thirdNumber;
    }

    return biggerNumber;
}
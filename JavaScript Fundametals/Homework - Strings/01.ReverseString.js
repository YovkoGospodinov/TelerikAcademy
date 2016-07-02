function solve(args) {
    var input = args[0];
    var reversedInput = "";

    for(var index in input) {
        reversedInput = input[index] + reversedInput;
    }

    return reversedInput;
}
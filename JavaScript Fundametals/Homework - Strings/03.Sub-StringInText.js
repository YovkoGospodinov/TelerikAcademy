function solve(args) {
    var searchedString = args[0].toLowerCase();
    var searchedStringLength = searchedString.length;
    var string = args[1].toLowerCase();
    var stringLength = string.length;

    var count = 0;

    for (var i = 0; i < stringLength; i += 1) {
        var element = string.substr(i, searchedStringLength);
        if (element === searchedString) {
            count += 1;
            //i += searchedStringLength;
        }
    }
    return count;
}
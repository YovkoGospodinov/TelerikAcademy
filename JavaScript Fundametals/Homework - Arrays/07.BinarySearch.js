function solve(args) {
    var input = args[0].split("\n");
    var length = +input[0];
    var numbers = [];
    var searchedNumber = +input[input.length - 1];
    var index;

    for (var i = 0; i < length; i += 1) {
        numbers.push(parseInt(input[i + 1]));
    }
    //debugger;
    //numbers.sort();

    index = numbers.indexOf(searchedNumber);
    if (index) {
        return index;
    } else {
        return -1;
    }
}

//solve(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']);
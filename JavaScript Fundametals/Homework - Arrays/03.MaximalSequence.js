function solve(args) {
    var data = args[0].split("\n");
    var size = +data[0];
    var array = [];
    var maxSequence = 1;
    var currentSequence = 1;

    for (var i = 0; i < size; i += 1) {
        var el = parseInt(data[i + 1]);
        array.push(el);
    }

    for (var j = 1; j < size; j += 1) {
        if (parseInt(array[j - 1]) === parseInt(array[j])) {
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

//solve(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);
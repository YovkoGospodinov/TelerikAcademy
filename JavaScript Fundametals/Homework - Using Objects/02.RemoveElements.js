function solve(args) {
    var element = args[0];

    //debugger;
    var result = args.filter(function(el) {
        return el !== element;
    });

    result.forEach(function(el) {
        console.log(el);
    });

    // for(var index in result) {
    //     console.log(result[index]);
    // }
}

//solve([1,2,3,4,1,5,1,5,6,1,9,1]);
function solve(args) {

    var min = +args[0];
    var max = +args[0];
    var sum = 0;

    for (var i = 0; i < args.length; i += 1) {
        var element = +args[i];
        sum += element;
        if (element > max) {
            max = element;
        }
        if (element < min) {
            min = element;
        }
    }

    // var min = +args[0];
    // var max = +args[0];
    // var sum = 0;
    // var avarage = 0;

    // for (var i = 0; i < args.length; i++) {
    //     var element = +args[i];
    //     if (element > max) {
    //         max = element;
    //     }

    //     if (element < min) {
    //         min = element;
    //     }

    //     sum+=element;
    // }

    var avarage = sum / args.length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avarage.toFixed(2));
}
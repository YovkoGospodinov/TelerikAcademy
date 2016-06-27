function solve(args) {
    var size = +args[0];
    var array = new Array(size);

    for (var i = 0; i < size; i += 1) {
        array.push(i * 5);
    }

    for (var item in array) {
        console.log(array[item]);
    }
}

// function solve(args) {
//     var size = +args[0];

//     for(var i = 0; i < size; i += 1) {
//         console.log(i * 5);
//     }
// }
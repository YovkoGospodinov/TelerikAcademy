function solve(args) {
    var arr = args[0].split("\n");
    var firstString = arr[0];
    var secondString = arr[1];

    if (firstString > secondString) {
        console.log(">");
    } else if (firstString < secondString) {
        console.log("<");
    }
    //else if (firstString === secondString) {
    else {
        console.log("=");
    }
}


//solve(['food', 'food']);
function solve(args) {
    var input = parseInt(args[0]);
    var isPrime = true;
    var maxDevisor = Math.sqrt(input);
    if (input > 1 && input <= 100) {
        for (var i = 2; i < maxDevisor; i += 1) {
            if (input % i === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            console.log("true");
        } else {
            console.log("false");
        }
    } else {
        console.log("false");
    }
}

solve([3]);

// function isPrime(value) {
//     for(var i = 2; i < value; i++) {
//         if(value % i === 0) {
//             return false;
//         }
//     }
//     return value > 1;
// }

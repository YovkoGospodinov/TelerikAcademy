function solve(args) {
    var input = args[0] | 0;
    
    var result = ((input / 100)%10) | 0;

    if ( result === 7) {
        console.log("true");
    }
    else{
        console.log("false " + result);
    }
}
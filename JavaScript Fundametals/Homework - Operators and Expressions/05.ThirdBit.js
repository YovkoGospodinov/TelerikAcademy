function solve(args) {
    var input = args[0] | 0;

    var result = input & (1 << 3);

    result = result >> 3;

    console.log(result);
}
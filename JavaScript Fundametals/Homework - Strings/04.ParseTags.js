function solve(args) {
    var input = args[0];

    var result = input.replace(/<.*?>/g, "");

    return result;
}
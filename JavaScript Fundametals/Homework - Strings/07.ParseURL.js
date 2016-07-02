function solve(args) {
    var input = args[0];
    //debugger;
    var start = 0;
    var end = input.indexOf(":");

    var protocol = input.substring(start, end);

    start = input.indexOf("//") + 2;
    end = input.indexOf("/", start);

    var server = input.substring(start, end);

    var resource = input.substring(end);

    console.log("protocol: " + protocol);
    console.log("server: " + server);
    console.log("resource: " + resource);
}

//solve(['http://telerikacademy.com/Courses/Courses/Details/239']);
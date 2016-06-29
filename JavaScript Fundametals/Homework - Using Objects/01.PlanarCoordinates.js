function solve(args) {
    var numbers = args.map(Number);

    var line1StartX = numbers[0];
    var line1StartY = numbers[1];
    var line1EndX = numbers[2];
    var line1EndY = numbers[3];
    var line1Length = Math.sqrt((line1EndX - line1StartX) * (line1EndX - line1StartX) + (line1EndY - line1StartY) * (line1EndY - line1StartY));


    var line2StartX = numbers[4];
    var line2StartY = numbers[5];
    var line2EndX = numbers[6];
    var line2EndY = numbers[7];
    var line2Length = Math.sqrt((line2EndX - line2StartX) * (line2EndX - line2StartX) + (line2EndY - line2StartY) * (line2EndY - line2StartY));

    var line3StartX = numbers[8];
    var line3StartY = numbers[9];
    var line3EndX = numbers[10];
    var line3EndY = numbers[11];
    var line3Length = Math.sqrt((line3EndX - line3StartX) * (line3EndX - line3StartX) + (line3EndY - line3StartY) * (line3EndY - line3StartY));


    console.log(line1Length.toFixed(2));
    console.log(line2Length.toFixed(2));
    console.log(line3Length.toFixed(2));

    if (line1Length + line2Length > line3Length &&
        line1Length + line3Length > line2Length &&
        line2Length + line3Length > line1Length) {
        
        console.log("Triangle can be built");
    }
    else {
        console.log("Triangle can not be built");
    }
}

//solve(['5 6 7 8 1 2 3 4 9 10 11 12']);
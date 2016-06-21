function solve(args) {
    //var input = [];

    var pointX = parseFloat(args[0]);
    var pointY = parseFloat(args[1]);
    var isInsideCircle = true;
    var radius = 1.5;

    var distance = Math.sqrt((pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1));

    if (distance > radius) {
        isInsideCircle = false;
    }

    if (isInsideCircle) {
        if ((pointX <= 5) && (pointX >= -1) && (pointY >= -1) && (pointY <= 1)) {
            //inside rectangle
            console.log("inside circle inside rectangle");
        } else {
            console.log("inside circle outside rectangle");
        }
    } else {
        if ((pointX <= 5) && (pointX >= -1) && (pointY >= -1) && (pointY <= 1)) {
            //inside rectangle
            console.log("outside circle inside rectangle");
        } else {
            console.log("outside circle outside rectangle");
        }
    }
}
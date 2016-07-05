function solve(args) {
    let elements = args;
    let result = "";

    for (let i = 0; i < elements.length; i += 1) {
        result += elements[i].replace(/<.*?>/gi, "").trim();
    }

    console.log(result);
}

// var elements = args[0];
// var arrayLength = elements.length;
// var concat = "";
// var result = "";

// for (var i = 0; i < arrayLength; i += 1) {
//     var el = elements[i].trim();
//     concat += el;

//result = concat.replace(/<.*?>/g, "");

// for(var i = 0; i < arrayLength; i += 1) {
//     var el = elements[i].trim();

//     var start = el.indexOf(">");
//     var end = el.indexOf("</");
//     if (start < end) {
//         result += el.substring(start + 1, end);
//     }
//     else if (start < 0 && end < 0) {
// 	    result += el;
//     }
//     else if (start > 0 && end < 0 && el.length > start) {
//         result += el.substring(start + 1);
//     }
// }

//return result;
//}

//solve(["<html>", "<head>", "<title>Sample site</title>", "</head>", "<body>", "<div>text", "<div>more text</div>", "      and more...", "   </div>", "  in body", " </body>", "</html>"]);
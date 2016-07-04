function solve(args) {
    var result,
        text = args[0],
        offset = args[1],
        CONSTANTS = {
            ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
        };
    var alphabet = "abcdefghijklmnopqrstuvwxyz";
    var offsetAlpshabet = alphabet.substr(26 - offset, offset) + alphabet.substr(0, 26 - offset);


    var result1 = "";
    var count = 1;
    var currentSymbol;

    for (var i = 1; i < text.length; i += 1) {
        currentSymbol = text[i - 1];
        if (text[i] === text[i - 1]) {
            count += 1;
        } else {
            if (count === 1) {
                result1 += text[i - 1];
            } else if (count === 2) {
                result1 += text[i - 1] + text[i - 1];
                count = 1;
            } else if (count > 2) {
                result1 += count + text[i - 1];
                count = 1;
            }
        }
    }
    if (count === 1) {
        result1 += currentSymbol;
    } else if (count === 2) {
        result1 += currentSymbol + currentSymbol;
        count = 1;
    } else if (count > 2) {
        result1 += count + currentSymbol;
        count = 1;
    }

    //console.log(result1);
    var result2 = "";
    for (var j = 0; j < result1.length; j += 1) {
        if (!isNaN(result1[j])) {
            result2 += result1[j];
        } else {
            //var sym = alphabet[];
            var index = alphabet.indexOf(result1[j]);
            var temp = offsetAlpshabet[index];

            var el1 = result1[j].charCodeAt();
            var el2 = temp.charCodeAt();
            result2 += (el1 ^ el2);
        }
    }
    //console.log(result2);

    var sum = 0;
    var product = 1;

    for (var l = 0; l < result2.length; l += 1) {
        if (+(result2[l] % 2 === 0)) {
            sum += +(result2[l]);
        } else {
            product *= +(result2[l]);
        }
    }
    console.log(sum);
    console.log(product);
}

//solve(["", "0"]);
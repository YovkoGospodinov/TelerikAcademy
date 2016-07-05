function solve(args) {
    const upOpen = 'upcase',
        upClose = '/upcase',
        lowOpen = 'lowcase',
        lowClose = '/lowcase',
        orgOpen = 'orgcase',
        orgClose = '/orgcase',
        upScope = 'up',
        lowScope = 'low',
        orgScope = 'initial';

    let isTag = false,
        scopeStack = [],
        currentScope = orgScope,
        strLength = args[0].length,
        currentTag = '',
        output = '';

    for (let i = 0; i < strLength; i += 1) {
        let c = args[0][i] + '';

        if (c === '<') {
            isTag = true;
        } else if (c === '>') {
            isTag = false;
            // Evaluate Tag
            if (currentTag === upOpen) {
                scopeStack.push(currentScope);
                currentScope = upScope;
            } else if (currentTag === lowOpen) {
                scopeStack.push(currentScope);
                currentScope = lowScope;
            } else if (currentTag === orgOpen) {
                scopeStack.push(currentScope);
                currentScope = orgScope;
            } else if (currentTag === upClose) {
                currentScope = scopeStack.pop();
            } else if (currentTag === lowClose) {
                currentScope = scopeStack.pop();
            } else if (currentTag === orgClose) {
                currentScope = scopeStack.pop();
            } else {
                output += currentTag;
            }
            currentTag = '';
        } else if (isTag) {
            currentTag += c;
        } else if (!isTag) {
            if (currentScope === upScope) {
                output += c.toUpperCase();
            } else if (currentScope === lowScope) {
                output += c.toLowerCase();
            } else {
                output += c;
            }
        }
    }
    console.log(output);
}

// function solve(args) {
//     var input = args[0];

//     var result = input.replace(/<.*?>/g, "");

//     return result;
// }

// function solve(args) {
//     let elements = args[0];
//     let arrayLength = elements.length;
//     let result = "";

//     let upcase = "<upcase>";
//     let lowcase = "<lowcase>";
//     let orgcase = "<orgcase>";

//     for (let i = 0; i < arrayLength; i += 1) {
//         if (elements[i] !== "<") {
//             result += elements[i];
//         } else {
//             if (elements.substr(i, 8) === upcase) {
//                 let tempIndex = elements.indexOf(">", i);
//                 let temp2 = elements.indexOf("</", tempIndex + 1);
//                 let tempString = elements.substring(i + 8, temp2).toUpperCase();
//                 result += tempString;
//                 i = temp2 + 8;
//             } else if (elements.substr(i, 9) === lowcase) {
//                 let tempIndex = elements.indexOf(">", i);
//                 let temp2 = elements.indexOf("</", tempIndex + 1);
//                 let tempString = elements.substring(i + 9, temp2).toLowerCase();
//                 result += tempString;
//                 i = temp2 + 9;
//             } else if (elements.substr(i, 9) === orgcase) {
//                 let tempIndex = elements.indexOf(">", i);
//                 let temp2 = elements.indexOf("</", tempIndex + 1);
//                 let tempString = elements.substring(i + 9, temp2);
//                 result += tempString;
//                 i = temp2 + 9;
//             }
//         }
//     }

//     console.log(result);
// }



//solve(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.']);
function solve(args) {
    let data = args;
    //data = data.split("\n");

    let enums = [];
    let isBeginningTag = true;
    let isShared = true;
    let enumName = "";
    let count = 0;
    let ordinaryEnumerations = [];
    let sharedEnumerations = [];
    let sharedCount = 0;

    for (let i = 0; i < data.length; i += 1) {
        if (data[i].indexOf("<") === 0) {
            isBeginningTag = true;
            if (data[i].indexOf("</") === 0) {
                isBeginningTag = false;
                ordinaryEnumerations = [];
                enumName = "";
                count = 0;
                continue;
            }
            if (isBeginningTag) {
                enumName = data[i].substring(1, data[i].length - 1);
                if (enumName.indexOf("@") > -1) {
                    isShared = true;
                    enumName = data[i].substring(2, data[i].length - 1);
                }
            }

        } else {
            let enumValue = "";
            let ownPosition = -1;
            let temp = data[i].trim();
            if (temp.indexOf("=") > -1) {
                temp = temp.split(" ").filter(Boolean);
                enumValue = temp[0];
                ownPosition = +(temp[2].substring(0, temp[2].length - 1));

            } else {
                enumValue = temp.substring(0, temp.length - 1);

            }

            if (ownPosition > -1) {

                enums.push({
                    name: enumName,
                    value: enumValue,
                    enumeration: ownPosition
                });
                ordinaryEnumerations.push(ownPosition);
            } else {
                if (ordinaryEnumerations.indexOf(count) > -1) {
                    count += 1;
                }
                enums.push({
                    name: enumName,
                    value: enumValue,
                    enumeration: count
                });

                ordinaryEnumerations.push(count);
                count += 1;
            }
        }
    }

    enums.sort(function(o1, o2) {
        return o1.value > o2.value;
    });
    console.log();

    for (const o of enums) {
        console.log(o.value + " = " + o.enumeration + " :: " + o.name + ";");
    }
}
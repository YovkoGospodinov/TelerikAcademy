function sum(arr) {
    const numbers = arr;
    let result = 0;

    if (numbers === undefined) {
        throw new Error("Error");
    } else if (numbers.length === 0) {
        return null;
    }

    for (let number of numbers) {
        if (!isNaN(number)) { //typeof number === "number"   //typeof Number(number)
            result += +number;
        } else {
            throw new Error("Error");
        }
    }

    return result;
}

module.exports = sum;
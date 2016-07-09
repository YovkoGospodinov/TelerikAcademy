function solve(args) {
    let heights = args[0].split(" ").map(Number);

    let result = 0;

    var peaks = [];

    for (let i = 1; i < heights.length - 1; i += 1) {
        if (isGreaterThanNeighbours(i, heights)) {
            peaks.push(i);
        }
    }

    //code belongs to the wrong understanding of problem
    // for (let j = 0; j < peaks.length - 1; j += 1) {
    //     for (let k = 0; k < (peaks[j + 1] - peaks[j]) - 1; k += 1) {
    //         result += heights[peaks[k + j] + 1];
    //     }
    // }

    for (let j = 0; j < peaks.length - 1; j += 1) {
        if (peaks[j] + 2 === peaks[j + 1]) {
            result += heights[peaks[j] + 1];
        }
    }

    console.log(result);


    function isGreaterThanNeighbours(index, arr) {
        return arr[index - 1] < arr[index] &&
            arr[index + 1] < arr[index];
    }
}

//solve(["53 20 1 30 2 40 3 3 10 1"]);
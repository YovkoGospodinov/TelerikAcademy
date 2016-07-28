function solve() {

    return function(element, contents) {

        var docFrag = document.createDocumentFragment();

        if (element === null || contents === null || !Array.isArray(contents)) {
            throw new ExceptionInformation("Exception");
        }

        for (var i = 0; i < contents.length; i += 1) {
            if (typeof contents[i] !== "string" && typeof contents[i] !== "number") {
                throw new ExceptionInformation("Exception");
            }
        }

        if (typeof element === "string") {
            element = document.getElementById(element);
            if (element === null) {
                throw new ExceptionInformation("Exception");
            }

        } else if (element instanceof HTMLElement) {
            element = element;
        } else {
            throw new ExceptionInformation("Exception");
        }

        element.innerHTML = "";
        var div = document.createElement("div");

        for (var j = 0; j < contents.length; j += 1) {
            var el = contents[j];
            var divToAdd = div.cloneNode(true);
            divToAdd.innerHTML = el;
            docFrag.appendChild(divToAdd);
        }

        element.appendChild(docFrag);
    };
}

//module.exports = solve();
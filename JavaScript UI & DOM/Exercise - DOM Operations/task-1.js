function solve() {

    return function(element, contents) {

        var docFrag = document.createDocumentFragment();

        if (element === null || contents === null) {
            throw new ExceptionInformation("Exception");
        }

        if (typeof element === "string") {
            element = document.getElementById(element);

        } else if (element instanceof HTMLElement) {
            element = element;
        } else {
            throw new ExceptionInformation("Exception");
        }

        element.innerHTML = "";
        var div = document.createElement("div");

        for (var i = 0; i < contents.length; i += 1) {
            var el = contents[i];
            var divToAdd = div.cloneNode(true);
            divToAdd.innerHTML = el;
            docFrag.appendChild(divToAdd);
        }

        element.appendChild(docFrag);
    };
}

//module.exports = solve();
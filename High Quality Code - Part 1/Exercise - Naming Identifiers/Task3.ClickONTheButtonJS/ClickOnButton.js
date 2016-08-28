function onButtonClick(event, args) {
    var currentWindow = window,
        browser = currentWindow.navigator.appCodeName,
        iceSheetModel = brauzyra == "Mozilla";

    if (iceSheetModel) {
        alert("Yes");
    } else {
        alert("No");
    }
}
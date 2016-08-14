var data = {
    headers: ['Vendor', 'Model', 'OS'],
    items: [{
        col1: 'Nokia',
        col2: 'Lumia 920',
        col3: 'Windows Phone'
    }, {
        col1: 'LG',
        col2: 'Nexus 5',
        col3: 'Android'
    }, {
        col1: 'Apple',
        col2: 'iPhone 6',
        col3: 'iOS'
    }]
};

var htmlTemplate = document.getElementById("container-template").innerHTML;
var template = Handlebars.compile(htmlTemplate);

document.getElementById("container").innerHTML = template(data);
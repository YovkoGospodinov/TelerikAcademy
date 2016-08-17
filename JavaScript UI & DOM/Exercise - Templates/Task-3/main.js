var $this = $(this),
    templateSelector = '#' + $this.attr('data-template'),
    templateHtml = $(templateSelector).html(),
    template = handlebars.compile(templateHtml),
    i, len;

for (i = 0, len = data.length; i < len; i += 1) {
    $this.append(template(data[i]));
}

var htmlTemplate = document.getElementById("container-template").innerHTML;
var template = Handlebars.compile(htmlTemplate);

document.getElementById("container").innerHTML = template(data);
let homeController = {

    all(context) {
        templates.get("info")
            .then(function(template) {
                context.$element().html(template());
            });
    }
};
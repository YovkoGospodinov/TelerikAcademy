let materialsController = {
    all(context) {
        var materials;
        data.materials.all()
            .then(function(resMaterials) {
                materials = resMaterials.result;
                return templates.get("materials");
            })
            .then(function(template) {
                context.$element().html(template(materials));
            });
    }
};
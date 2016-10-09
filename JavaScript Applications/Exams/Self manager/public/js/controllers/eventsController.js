var eventsController = function() {

    function all(context) {
        data.events.get()
            .then(function(resEvents) {
                events = resEvents.result;
                return templates.get("events");
            })
            .then(function(template) {
                context.$element().html(template(events));
            });
    }

    function add(context) {
        templates.get("event-add")
            .then(function(template) {
                context.$element().html(template());

                $("#btn-event-add").on("click", function() {
                    var $title = $("#tb-event-title").val();
                    var $category = $("#tb-event-category").val();
                    var $description = $("#tb-event-description").val();
                    var $user = $("#tb-event-user").val();

                    var event = {
                        title: $title,
                        category: $category,
                        description: $description,
                        user: $user
                    };

                    data.events.add(event)
                        .then(function(event) {
                            toastr.success(`Event "${event.title}" added!`);
                            context.redirect("#/events");
                        });
                });
                return data.categories.get();
            }).then(function(categories) {
                $("#tb-events-category").autocomplete({
                    source: categories.result
                });
            });
    }

    return {
        all: all,
        add: add
    };
}();
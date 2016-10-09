var todosController = function() {

    function all(context) {
        var todos;
        var category = context.params.category;

        if (category) {
            category = category.toLowerCase();
        }

        data.todos.get()
            .then(function(resTodos) {
                todos = resTodos.result;
                return templates.get("todos");
            })
            .then(function(template) {
                var groups = _.chain(todos)
                    .groupBy("category")
                    .map(function(todos, categoryName) {
                        return {
                            category: categoryName,
                            todos: todos
                        };
                    })
                    .filter(function(group) {
                        return !category || group.category.toLowerCase() === category;
                    })
                    .value();

                context.$element().html(template(groups));
                $(".todo-state").on("change", function() {
                    var id = $(this).parents(".todo-item").attr("data-id");
                    var state = !!$(this).prop("checked");
                    data.todos.updateState(id, state)
                        .then(function() {
                            toastr.info("State updated!");
                        });
                });
            });
    }

    function add(context) {
        templates.get("todo-add")
            .then(function(template) {
                context.$element().html(template());

                $("#btn-todo-add").on("click", function() {
                    var $text = $("#tb-todo-text").val();
                    var $category = $("#tb-todo-category").val();

                    var todo = {
                        text: $text,
                        category: $category
                    };

                    data.todos.add(todo)
                        .then(function(todo) {
                            todo = todo.result;
                            toastr.success(`TODO "${todo.text}" added!`);
                            context.redirect("#/todos");
                        });
                });
                return data.categories.get();
            }).then(function(categories) {
                $("#tb-todo-category").autocomplete({
                    source: categories.result
                });
            });
    }

    return {
        all: all,
        add: add
    };
}();
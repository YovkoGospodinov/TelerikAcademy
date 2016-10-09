var usersController = (function() {

    function login(context) {

    }

    function register(context) {
        templates.get("register")
            .then(function(template) {
                context.$element().html(template());

                $("#btn-register").on("click", function() {
                    var $userName = $("#tb-username").val();
                    var $passWord = $("#tb-password").val();
                    var user = {
                        username: $userName,
                        password: $passWord
                    };

                    data.users.register(user)
                        .then(function() {
                            console.log("user registered");
                            toastr.success(`User "${user.username}" successfully registered!`);
                        });
                });

                $("#btn-login").on("click", function() {
                    var $userName = $("#tb-username").val();
                    var $passWord = $("#tb-password").val();
                    var user = {
                        username: $userName,
                        password: $passWord
                    };

                    data.users.login(user)
                        .then(function() {
                            toastr.success(`User "${user.username}" logged in!`);
                            context.redirect("#/");
                        });
                });
            });
    }

    return {
        login: login,
        register: register
    };
}());
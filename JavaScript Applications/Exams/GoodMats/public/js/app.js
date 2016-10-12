(function() {
    var sammyApp = Sammy("#content", function() {

        this.get("#/", function() {
            this.redirect("#/home");
        });

        this.get("#/home", materialsController.all);

        this.get("#/info", homeController.all);

        this.get("#/register", usersController.register);

        this.get("#/login", usersController.login);

        this.get("#/users", usersController.all);

        this.get("#/materials", materialsController.all);


    });

    $(function() {
        sammyApp.run("#/");
    });


    let isUserLogged = data.users.isLoggedIn();
    // console.log(isUserLogged);
    if (isUserLogged) {
        let username = data.users.getCurrentUser();
        // console.log(username);

        $("#username-value").parent("li").removeClass("hidden");
        $("#username-value").html("Hello, " + username);
        $("#btn-nav-login").addClass("hidden");
        $("#btn-nav-register").addClass("hidden");
        $("#user-logout").parent('li').removeClass("hidden");
    }

    $("#user-logout").on("click", function() {
        data.users.logout();
    });

}());
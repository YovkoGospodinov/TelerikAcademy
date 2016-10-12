var usersController = (function() {

    const minStringLength = 6,
        maxStringLength = 30;

    const userNameSymbols = /[a-zA-Z0-9._]*/;
    const passWordSymbols = /[a-zA-Z0-9]*/;

    function login(context) {
        templates.get("login")
            .then(function(template) {
                context.$element().html(template());

                $("#btn-login").on("click", function() {
                    var userName = $("#tb-username").val();
                    var passWord = $("#tb-password").val();

                    if (userName.length < minStringLength || maxStringLength < userName.length) {
                        updateUI.showMsg(`Username should be between ${minStringLength} and ${maxStringLength} symbols!`, 'alert-danger');
                        return;
                    }

                    if (passWord.length < minStringLength || maxStringLength < passWord.length) {
                        updateUI.showMsg(`Password should be between ${minStringLength} and ${maxStringLength} symbols!`, 'alert-danger');
                        return;
                    }

                    if (!((userNameSymbols).test(userName))) {
                        updateUI.showMsg(`Username should contain only Latin letters, digits and the characters '_' and '.'!`, 'alert-danger');
                        return;
                    }

                    if (!((passWordSymbols).test(passWord))) {
                        updateUI.showMsg(`Password should contain only Latin letters and digits!`, 'alert-danger');
                        return;
                    }

                    var user = {
                        "username": userName,
                        "password": passWord
                    };

                    console.log(user);

                    data.users.login(user)
                        .catch((error) => {
                            if (error.status === 404) {
                                updateUI.showMsg("Incorrect username or password!", "alert-danger");
                            }
                        })
                        .then((respUser) => {

                            console.log(respUser);

                            if (!respUser.result.err) {
                                localStorage.setItem("username", respUser.result.username);
                                localStorage.setItem("authKey", respUser.result.authKey);


                                console.log("user logged in");
                                toastr.success(`User "${user.username}" logged in!`);

                                $("#username-value").parent("li").removeClass("hidden");
                                $("#username-value").html("Hello, " + user.username);
                                $("#btn-nav-login").addClass("hidden");
                                $("#btn-nav-register").addClass("hidden");
                                $("#user-logout").parent('li').removeClass("hidden");

                                context.redirect("#/materials");
                            } else {
                                updateUI.showMsg(`${respUser.result.err}`, "alert-danger");
                            }

                        });
                });
            });
    }

    function register(context) {
        templates.get("register")
            .then(function(template) {
                context.$element().html(template());

                $("#btn-register").on("click", function() {
                    var userName = $("#tb-username").val();
                    var passWord = $("#tb-password").val();

                    if (userName.length < minStringLength || maxStringLength < userName.length) {
                        updateUI.showMsg("Username should be between minStringLength and maxStringLength symbols!", "alert-danger");
                        return;
                    }

                    if (passWord.length < minStringLength || maxStringLength < passWord.length) {
                        updateUI.showMsg("Password should be between minStringLength and maxStringLength symbols!", "alert-danger");
                        return;
                    }

                    if (!((userNameSymbols).test(userName))) {
                        updateUI.showMsg(`Username should contain only Latin letters, digits and the characters '_' and '.'!`, 'alert-danger');
                        return;
                    }

                    if (!((passWordSymbols).test(passWord))) {
                        updateUI.showMsg(`Password should contain only Latin letters and digits!`, 'alert-danger');
                        return;
                    }

                    var user = {
                        "username": userName,
                        "password": passWord
                    };

                    data.users.register(user)
                        .catch((error) => {
                            if (error.status >= 400) {
                                updateUI.showMsg("Incorrect username or password!", "alert-danger");
                            }
                        })
                        .then((respUser) => {
                            data.users.login(user);
                            console.log("user registered");
                            toastr.success(`User "${respUser.result.username}" successfully registered!`);

                            $("#username-value").parent("li").removeClass("hidden");
                            $("#username-value").html(`Hello, ${respUser.result.username}`);
                            $("#btn-nav-login").addClass("hidden");
                            $("#btn-nav-register").addClass("hidden");
                            $("#user-logout").parent('li').removeClass("hidden");

                            context.redirect("#/materials");
                        });
                });
            });
    }

    function all(context) {
        var users;
        data.users.all()
            .then(function(resUsers) {
                users = resUsers.result;
                return templates.get("users");
            })
            .then(function(template) {
                context.$element().html(template(users));
            });
    }

    return {
        login: login,
        register: register,
        all: all
    };
}());
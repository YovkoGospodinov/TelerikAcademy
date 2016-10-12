var data = function() {
    const LOCAL_STORAGE_AUTH_KEY = "";

    const HTTP_HEADER_KEY = "x-auth-key",
        KEY_STORAGE_USERNAME = "username",
        KEY_STORAGE_AUTH_KEY = "authKey";

    /* Users */
    function login(user) {
        var result = requester.putJSON("api/users/auth/", user);
        return result;
    }

    function register(user) {
        return requester.postJSON("api/users", user);
    }

    function all() {
        return requester.getJSON("api/users");
    }

    function isLoggedIn() {
        return !!localStorage.getItem("username");
    }

    function getCurrentUser() {
        return localStorage.getItem("username");
    }

    function logout() {
        return Promise.resolve()
            .then(() => {
                localStorage.removeItem("username");
                localStorage.removeItem("authKey");

                $("#btn-nav-login").removeClass("hidden");
                $("#btn-nav-register").removeClass("hidden");
                $("#user-logout").parent("li").addClass("hidden");
                $("#username-value").parent("li").addClass("hidden");
            });
    }

    /* Materials */

    function allMaterials() {
        return requester.getJSON("/api/materials");
    }

    return {
        users: {
            login: login,
            register: register,
            all: all,
            logout: logout,
            isLoggedIn: isLoggedIn,
            getCurrentUser: getCurrentUser
        },
        materials: {
            all: allMaterials
        }
    };
}();
var data = (function() {
    const LOCAL_STORAGE_AUTH_KEY = "";

    /* Users */
    function login(user) {
        var promise = new Promise(function(resolve, reject) {
            var url = "api/users/auth";

            $.ajax(url, {
                type: "PUT",
                contentType: "application/json",
                data: JSON.stringify(user),
                success: function(res) {
                    localStorage.setItem(LOCAL_STORAGE_AUTH_KEY, res.result.authKey);
                    resolve(res);
                }
            });
        });
        return promise;
    }

    function register(user) {
        var promise = new Promise(function(resolve, reject) {
            var url = "api/users";

            $.ajax(url, {
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify(user),
                success: function(res) {
                    resolve(res);
                }
            });
        });
        return promise;
    }

    /* TODOs */

    function todosGet() {
        var promise = new Promise(function(resolve, reject) {
            var url = "api/todos";
            $.ajax(url, {
                type: "GET",
                contentType: "application/json",
                headers: {
                    "x-auth-key": localStorage.getItem(LOCAL_STORAGE_AUTH_KEY)
                },
                success: function(res) {
                    resolve(res);
                }
            });
        });
        return promise;
    }

    function todosAdd(todo) {
        var promise = new Promise(function(resolve, reject) {
            var url = "api/todos";

            $.ajax(url, {
                type: "POST",
                contentType: "application/json",
                headers: {
                    "x-auth-key": localStorage.getItem(LOCAL_STORAGE_AUTH_KEY)
                },
                data: JSON.stringify(todo),
                success: function(res) {
                    resolve(res);
                },
                error: function(err) {
                    reject(err);
                }
            });
        });
        return promise;
    }

    function updateStateTODO(id, state) {
        var promise = new Promise(function(resolve, reject) {
            var url = "api/todos/" + id;

            $.ajax(url, {
                type: "PUT",
                contentType: "application/json",
                headers: {
                    "x-auth-key": localStorage.getItem(LOCAL_STORAGE_AUTH_KEY)
                },
                data: JSON.stringify({ state: state }),
                success: function(res) {
                    resolve(res);
                },
                error: function(err) {
                    reject(err);
                }
            });
        });
        return promise;
    }

    /* Events */
    function eventsGet() {
        var promise = new Promise(function(resolve, reject) {
            var url = "api/events";
            $.ajax(url, {
                type: "GET",
                contentType: "application/json",
                headers: {
                    "x-auth-key": localStorage.getItem(LOCAL_STORAGE_AUTH_KEY)
                },
                success: function(res) {
                    resolve(res);
                }
            });
        });
        return promise;
    }

    function eventsAdd(event) {
        var promise = new Promise(function(resolve, reject) {
            var url = "api/events";

            $.ajax(url, {
                type: "POST",
                contentType: "application/json",
                headers: {
                    "x-auth-key": localStorage.getItem(LOCAL_STORAGE_AUTH_KEY)
                },
                data: JSON.stringify(event),
                success: function(res) {
                    resolve(res);
                },
                error: function(err) {
                    reject(err);
                }
            });
        });
        return promise;
    }

    /* Categories */
    function categoriesGet() {
        var promise = new Promise(function(resolve, reject) {
            var url = "api/categories";
            $.ajax(url, {
                type: "GET",
                contentType: "application/json",
                headers: {
                    "x-auth-key": localStorage.getItem(LOCAL_STORAGE_AUTH_KEY)
                },
                success: function(res) {
                    resolve(res);
                }
            });
        });
        return promise;
    }

    return {
        users: {
            login: login,
            register: register
        },
        todos: {
            get: todosGet,
            add: todosAdd,
            updateState: updateStateTODO
        },
        events: {
            get: eventsGet,
            add: eventsAdd
        },
        categories: {
            get: categoriesGet
        }
    };
}());
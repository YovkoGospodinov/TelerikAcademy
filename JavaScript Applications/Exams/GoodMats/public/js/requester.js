let requester = {
    get(url) {
        let promise = new Promise((resolve, reject) => {
            $.ajax({
                url,
                method: "GET",
                success: function(response) {
                    resolve(response);
                },
                error(response) {
                    reject(response);
                }
            });
        });

        return promise;
    },

    putJSON(url, body, options = {}) {
        return new Promise((resolve, reject) => {
            var headers = options.headers || {};
            $.ajax({
                url,
                headers,
                method: "PUT",
                contentType: "application/json",
                data: JSON.stringify(body),
                success(response) {
                    resolve(response);
                },
                error(response) {
                    reject(response);
                }
            });
        });
    },

    postJSON(url, body, options = {}) {
        let promise = new Promise((resolve, reject) => {
            var headers = options.headers || {};
            $.ajax({
                url,
                headers,
                method: "POST",
                contentType: "application/json",
                data: JSON.stringify(body),
                success(response) {
                    resolve(response);
                },
                error(response) {
                    reject(response);
                }
            });
        });
        return promise;
    },

    getJSON(url) {
        let promise = new Promise((resolve, reject) => {
            $.getJSON(url)
                .done(resolve)
                .fail(reject);
        });

        return promise;
    }
};
var url = "http://localhost:8886/api/people";

$("#btn-show").on("click", function() {
    requester(url, "GET", null);
});

$("#btn-post").on("click", function() {
    var name = $("#name").val();
    var age = +$("#age").val();
    var person = { name, age };
    requester(url, "POST", person);
});

function requester(serviceUrl, method, body) {
    $.ajax({
            url: serviceUrl,
            type: method,
            contentType: "application/json",
            data: JSON.stringify(body)
        })
        .done(function(response) {
            if (method === "GET") {
                showPeople(response.data);
            }
        })
        .fail(function(error) {
            console.log(error);
        });
}

function showPeople(people) {
    var list = document.createElement("ul");
    var itemTemplate = document.createElement("li");

    people.forEach(person => {
        var li = itemTemplate.cloneNode(true);
        li.innerHTML = `Name: ${person.name} at age: ${person.age}`;
        list.appendChild(li);
    });

    document.getElementById("print").appendChild(list);
}
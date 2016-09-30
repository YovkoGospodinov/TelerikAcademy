var url = "http://localhost:8886/api/people";

$("#btn-show").on("click", function() {
    getAll(url);
});

$("#btn-post").on("click", function() {
    var name = $("#name").val();
    var age = +($("#age").val());
    var currentPerson = { name, age };
    postPerson(url, currentPerson);
});


function postPerson(url, person) {
    $.ajax({
        url: url,
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify(person),
    });
}

function getAll(url) {
    $.ajax({
        url: url,
        type: "GET",
        contentType: "application/json",
        success: function(response) {
            console.log("It Works");
            console.log(response.data);

            var people = response.data;
            showPeople(people);

        },
        error: function(error) {
            console.log(error);
        }
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
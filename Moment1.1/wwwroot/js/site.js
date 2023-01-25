
const input = document.getElementById("js-input");
const submit = document.getElementById("js-submit");
const list = document.getElementById("js-list");
const message = document.getElementById("js-message");

let listArray = [];


submit.disabled = true;



input.addEventListener("keyup", function (event) {

    if (event.target.value.length < 5) {
        message.innerHTML = "Minst 5 bokstäver"
    } else {
        message.innerHTML = ""
        submit.disabled = false;
    }
})

submit.addEventListener("click", function (event) {

    let item = input.value;

    listArray.push(item);

    list.innerHTML = "";

    for (var i = 0; i < listArray.length; i++) {

        var li = document.createElement("li");
        li.innerHTML = listArray[i];
        list.appendChild(li);
    }

    input.value = "";
    submit.disabled = true;


})


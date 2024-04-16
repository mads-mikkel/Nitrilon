var eventId = 1;

var greenPressed = document.querySelector("#green");
var yellowPressed = document.querySelector("#yellow");
var redPressed = document.querySelector("#red");

greenPressed.addEventListener("click", sendToServer(1));
yellowPressed.addEventListener("click", sendToServer(2));
redPressed.addEventListener("click", sendToServer(3));

function sendToServer(rating) {
    // let apiUrl = `https://localhost:7123/api/EventRatings?eventId=${eventId}&ratingId=${rating}`
    // const requestOptions = {
    //     method: 'POST',
    //     headers: {
    //         'Content-Type': 'application/json',
    //     }
    // };

    fetch(`https://localhost:7123/api/EventRatings?eventId=${eventId}&ratingId=${rating}`,
        {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
        }
    );

    // fetch(`https://localhost:7123/api/EventRatings?eventId=${eventId}&ratingId=${rating}`, {
    //     method: 'POST',
    //     headers: {
    //         'Content-Type': 'application/json',
    //     })
    //     .then(response => {
    //         if (!response.ok) {
    //             throw new Error('Network response was not ok');
    //         }
    //         return response.json();
    //     })
    //     // .then(data => {
    //     //     outputElement.textContent = JSON.stringify(data, null, 2);
    //     // })
    //     .catch(error => {
    //         console.error('Error: ', error);
    //     });
}
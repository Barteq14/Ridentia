// The data/time we want to countdown to
var countDownDate = new Date(document.getElementById("expireData").innerHTML).getTime();


// Run myfunc every second
var myfunc = setInterval(function () {

    var now = new Date().getTime();
    var timeleft = countDownDate - now;
    var strdays = ""; var strhours = "";

    // Calculating the days, hours, minutes and seconds left
    var days = Math.floor(timeleft / (1000 * 60 * 60 * 24));
    var hours = Math.floor((timeleft % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    var minutes = Math.floor((timeleft % (1000 * 60 * 60)) / (1000 * 60));
    var seconds = Math.floor((timeleft % (1000 * 60)) / 1000);

    // Result is output to the specific element
    if (days > 0) {
        document.getElementById("dateCount").innerHTML = "Będziesz mógł pracować za " + days + " dni, " + hours + " godzin, " + minutes + " minut i " + seconds + " sekund";
    }
    if (days == 0 && hours > 0) {
        document.getElementById("dateCount").innerHTML = "Będziesz mógł pracować za " + hours + " godzin, " + minutes + " minut i " + seconds + " sekund";
    }
    else if (days == 0 && hours == 0 && minutes > 0) {
        document.getElementById("dateCount").innerHTML = "Będziesz mógł pracować za " + minutes + " minut i " + seconds + " sekund";
    }
    else if (days == 0 && hours == 0 && minutes == 0) {
        document.getElementById("dateCount").innerHTML = "Będziesz mógł pracować za " + seconds + " sekund";
    }
    else {
        document.getElementById("dateCount").innerHTML = "Będziesz mógł pracować za " + days + " dni, " + hours + " godzin, " + minutes + " minut i " + seconds + " sekund";
    }

    // Display the message when countdown is over
    if (timeleft < 0) {
        clearInterval(myfunc);
        document.getElementById("dateCount").innerHTML = "Możesz już pracować. Następuje przekierowanie."
        window.location.href = '/Work/Index';
    }


}, 1000);
function myFunction(x) {

    var str = x.innerHTML;
    var res = str.split(">");
    var tekst2 = "" + res;
    var res2 = tekst2.split("<");
   

    var test = x.textContent;
    
    document.getElementById("choosework").innerHTML = "Pracuj jako: " + res2[1].substring(23);
    document.getElementById("chooseworkinput").value = res2[1].substring(23);

    //console.log(res2[5].substring(23));

    document.getElementById("selectElementId").innerHTML = "";

    var min = 1,
        max = res2[5].substring(23),
        select = document.getElementById('selectElementId');

    for (var i = min; i <= max; i++) {
        var opt = document.createElement('option');
        opt.value = i;
        if (i == 1) {
            opt.innerHTML = i + " godzina";
        }
        else if (i == 2 || i == 3 || i == 4) {
            opt.innerHTML = i + " godziny";
        }
        else if(i > 4) {
            opt.innerHTML = i + " godzin";
        }
        
        select.appendChild(opt);
    }

}




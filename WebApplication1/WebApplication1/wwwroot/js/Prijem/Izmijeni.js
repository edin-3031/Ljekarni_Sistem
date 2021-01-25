function check() {
    document.getElementById("snimi").disabled = true;

    var datum = document.getElementById("datum").value;
    var pacijent = document.getElementById("pacijent").value;
    var ljekar = document.getElementById("ljekar").value;

    var prvi = false;

    if (datum == "" || datum == null) {
        prvi = false;
        document.getElementById("datum").classList.add("err");
        document.getElementById("span_datum").innerText = "Obavezno polje";
    }
    else {

        var patt = /(?:(?:31(\/|-|\. |\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\. |\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\. |\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\. |\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})/;

        if (patt.test(datum)) {
            prvi = true;
            document.getElementById("datum").classList.remove("err");
            document.getElementById("span_datum").innerText = "";
        }
        else {
            prvi = false;
            document.getElementById("datum").classList.add("err");
            document.getElementById("span_datum").innerText = "Molimo da unesete ispravan format (DD.MM.YYYY. HH:MM:SS)";
        }
    }

    if (prvi) {
        document.getElementById("snimi").disabled = false;
    }
}

function enable() {
    document.getElementById("snimi").disabled = false;
}
function check() {
    document.getElementById("snimi").disabled = true;

    var datum = document.getElementById("datum").value;
    var pacijent = document.getElementById("pacijent").value;
    var ljekar = document.getElementById("ljekar").value;

    var prvi = drugi = treci = false;

    function checkDate(dat) {
        var godina = parseInt(dat.substring(0, 4));
        var mjesec = parseInt(dat.substring(5, 7));
        var dan = parseInt(dat.substring(8, 10));
        var sat = parseInt(dat.substring(11, 13));
        var minuta = parseInt(dat.substring(14, 16));

        var trenutno = new Date();
        var trenutnaGodina = parseInt(trenutno.getFullYear());
        var trenutniMjesec = parseInt(trenutno.getMonth());
        var trenutniDan = parseInt(trenutno.getDate());
        var trenutnoSati = parseInt(trenutno.getHours());
        var trenutnoMinuta = parseInt(trenutno.getMinutes());

        trenutniMjesec++;

        if (godina > trenutnaGodina)
            return true;
        if (godina == trenutnaGodina && mjesec > trenutniMjesec)
            return true;
        if (godina == trenutnaGodina && mjesec == trenutniMjesec && dan>=trenutniDan)
            return true;

        return false;
    }

    if (datum == "" || datum == null) {
        prvi = false;
        document.getElementById("datum").classList.add("err");
    }
    else {
        if (!checkDate(datum)) {
            prvi = false;
            document.getElementById("datum").classList.add("err");
            document.getElementById("span_datum").innerText = "Datum i vrijeme može biti trenutno ili starije od trenutnog";
        }
        else {
            prvi = true;
            document.getElementById("datum").classList.remove("err");
            document.getElementById("span_datum").innerText = "";
        }
    }

    if (pacijent == 0) {
        drugi = false;
        document.getElementById("pacijent").classList.add("err");
        document.getElementById("span_pacijent").innerText = "Obavezno polje";
    }
    else {
        drugi = true;
        document.getElementById("pacijent").classList.remove("err");
        document.getElementById("span_pacijent").innerText = "";
    }

    if (ljekar == 0) {
        treci = false;
        document.getElementById("ljekar").classList.add("err");
        document.getElementById("span_ljekar").innerText = "Obavezno polje";
    }
    else {
        treci = true;
        document.getElementById("ljekar").classList.remove("err");
        document.getElementById("span_ljekar").innerText = "";
    }
    if (prvi && drugi && treci) {
        document.getElementById("snimi").disabled = false;
    }
}

function enable() {
    document.getElementById("snimi").disabled = false;
}
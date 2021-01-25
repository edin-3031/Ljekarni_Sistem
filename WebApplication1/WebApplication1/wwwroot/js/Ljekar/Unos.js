var prvi = drugi = treci = cetvrti = false;

var ime;
var prezime;
var sifra;
var titula;

function check() {
    ime = document.getElementById("ime").value;
    prezime = document.getElementById("prezime").value;
    sifra = document.getElementById("sifra").value;
    titula = document.getElementById("titula").value;

    if (ime != "" && ime != null) {
        prvi = true;
        document.getElementById("ime").classList.remove("err");
        document.getElementById("span_ime").innerText = "";
    }
    else {
        prvi = false;
        document.getElementById("ime").classList.add("err");
        document.getElementById("span_ime").innerText = "Obavezno polje";
    }
    if (prezime != "" && prezime != null) {
        drugi = true;
        document.getElementById("prezime").classList.remove("err");
        document.getElementById("span_prezime").innerText = "";
    }
    else {
        drugi = false;
        document.getElementById("prezime").classList.add("err");
        document.getElementById("span_prezime").innerText = "Obavezno polje";

    }
    if (sifra != "" && sifra != null) {
        treci = true;
        document.getElementById("sifra").classList.remove("err");
        document.getElementById("span_sifra").innerText = "";
    }
    else {
        document.getElementById("sifra").classList.add("err");
        treci = false;
        document.getElementById("span_sifra").innerText = "Obavezno polje";
    }
    if (titula != 0) {
        cetvrti = true;
        document.getElementById("titula").classList.remove("err");
        document.getElementById("span_titula").innerText = "";
    }
    else {
        cetvrti = false;
        document.getElementById("titula").classList.add("err");
        document.getElementById("span_titula").innerText = "Obavezno polje";
    }
    if (!prvi || !drugi || !treci || !cetvrti)
        document.getElementById("snimi").disabled = true;
}
function enable() {
    document.getElementById("snimi").disabled = false;
}
function valid() {
    var ime = document.getElementById("ime").value;
    var prezime = document.getElementById("prezime").value;
    var datum = document.getElementById("datum").value;
    var spol = document.getElementById("spol").value;
    var adresa = document.getElementById("adresa").value;
    var telefon = document.getElementById("telefon").value;

    var prvi = drugi = treci = cetvrti = false;

    if (ime == "" || ime == null) {
        document.getElementById("ime").classList.add("err");
        prvi = false;
        document.getElementById("ime_span").innerText = "Obavezno polje";
    }
    else {
        document.getElementById("ime").classList.remove("err");
        prvi = true;
        document.getElementById("ime_span").innerText = "";
    }

    if (prezime == "" || prezime == null) {
        document.getElementById("prezime").classList.add("err");
        drugi = false;
        document.getElementById("prezime_span").innerText = "Obavezno polje";
    }
    else {
        document.getElementById("prezime").classList.remove("err");
        drugi = true;
        document.getElementById("prezime_span").innerText = "";
    }

    if (datum == "" || datum == null) {
        document.getElementById("datum").classList.add("err");
        treci = false;
        document.getElementById("datum_span").innerText = "Obavezno polje";
    }
    else {
        document.getElementById("datum").classList.remove("err");
        treci = true;
        document.getElementById("datum_span").innerText = "";
    }

    if (spol == 0) {
        document.getElementById("spol").classList.add("err");
        cetvrti = false;
        document.getElementById("spol_span").innerText = "Morate odabrati";
    }
    else {
        document.getElementById("spol").classList.remove("err");
        cetvrti = true;
        document.getElementById("spol_span").innerText = "";
    }
    if (prvi && drugi && treci && cetvrti) {
        window.location.href = "/Pacijent/UnosSnimi?ime=" + ime + "&&prezime=" + prezime + "&&datum_rodjenja=" + datum + "&&spol=" + spol + "&&adresa=" + adresa + "&&telefon=" + telefon;
    }
}
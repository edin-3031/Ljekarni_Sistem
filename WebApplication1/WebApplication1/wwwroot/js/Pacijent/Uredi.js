function test() {
    var prvi = drugi = treci = cetvrti = false;

    var id = document.getElementById("id").value;
    var ime = document.getElementById("ime").value;
    var prezime = document.getElementById("prezime").value;
    var datum = document.getElementById("datum_rodjenja").value;
    var spol = document.getElementById("spol").value;
    var adresa = document.getElementById("adresa").value;
    var telefon = document.getElementById("telefon").value;

    if (ime == null || ime == "") {
        document.getElementById("ime").classList.add("err");
        prvi = false;
        document.getElementById("span_ime").innerText = "Obavezno polje";
    }
    else {
        document.getElementById("ime").classList.remove("err");
        prvi = true;
        document.getElementById("span_ime").innerText = "";
    }

    if (prezime == null || prezime == "") {
        document.getElementById("prezime").classList.add("err");
        drugi = false;
        document.getElementById("span_prezime").innerText = "Obavezno polje";

    }
    else {
        document.getElementById("prezime").classList.remove("err");
        drugi = true
        document.getElementById("span_prezime").innerText = "";
    }

    if (datum == null || datum == "") {
        document.getElementById("datum_rodjenja").classList.add("err");
        treci = false;
        document.getElementById("span_datum").innerText = "Obavezno polje";
    }
    else {
        document.getElementById("datum_rodjenja").classList.remove("err");
        treci = true;
        document.getElementById("span_datum").innerText = "";
    }
    if (spol == 0) {
        document.getElementById("spol").classList.add("err");
        cetvrti = false;
    }
    else {
        document.getElementById("spol").classList.remove("err");
        cetvrti = true;
    }
    if (prvi && drugi && treci && cetvrti) {
        window.location.href = "/Pacijent/UrediSnimi?id=" + id + "&&ime=" + ime + "&&prezime=" + prezime + "&&datum_rodjenja=" + datum + "&&spol=" + spol + "&&adresa=" + adresa + "&&telefon=" + telefon;
    }
}
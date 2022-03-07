function chkcontrol1(j) {
    var total = 0;
    for (var i = 0; i < document.armar.sabor.length; i++) {
        if (document.armar.sabor[i].checked) {
            total = total + 1;
        }
        if (total > 2) {
            document.armar.sabor[j].checked = false;
            return false;
        }
    }
}

function chkcontrol2(j) {
    var total = 0;
    for (var i = 0; i < document.armar.adorno.length; i++) {
        if (document.armar.adorno[i].checked) {
            total = total + 1;
        }
        if (total > 2) {
            document.armar.adorno[j].checked = false;
            return false;
        }
    }
}
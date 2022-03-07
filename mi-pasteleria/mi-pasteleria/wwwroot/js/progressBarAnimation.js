var step = 50;
document.getElementById('end').style.display = 'none';
setInterval(function () {
    if (step >= 200) {
        document.getElementById('end').style.display = 'block';
    }
    if (step <= 200) {
        var widthProgressBar = step + "px";
        document.getElementById("progress").style.width = widthProgressBar;
        step += 50
    }
}, 500);
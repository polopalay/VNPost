$("#contact").click(function (event) {
    event.preventDefault();
    $("#mss").css("display", "flex");
    $("#contact").css("display", "none");
})
$("#mss-close").click(function () {
    $("#mss").css("display", "none");
    $("#contact").css("display", "flex");
})
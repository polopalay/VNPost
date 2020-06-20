function GetURLParameter(sParam) {
    $.urlParam = function (name) {
        const results = new RegExp("[?&]" + name + "=([^&#]*)").exec(
            window.location.href
        );
        return results != null ? results[1] : null;
    };
    return $.urlParam(sParam);
}
const menuBarAccessory = $("#menu-bar-accessory");
const menuBar = $("#menu-bar");
const hamburgerBar = $("#hamburger");
const LinkBar = $("#link-bar");

menuBarAccessory.click(function () {
    if (menuBar.css("display") === "none" || menuBar.css("display") === undefined) {
        menuBar.css("display", "flex")
    } else {
        menuBar.css("display", "none")
    }
});
hamburgerBar.click(function () {
    if (LinkBar.css("display") === "none" || LinkBar.css("display") === undefined) {
        LinkBar.css("display", "flex")
    } else {
        LinkBar.css("display", "none")
    }
});
window.onresize = function () {
    if (window.innerWidth >= 860) {
        LinkBar.css("display", "flex")
    } else {
        LinkBar.css("display", "none")
    }
};

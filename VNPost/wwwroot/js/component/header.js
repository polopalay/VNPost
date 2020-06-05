const menuBarAccessory = document.getElementById("menu-bar-accessory");
const menuBar = document.getElementById("menu-bar");
const hamburgerBar = document.getElementById("hamburger");
const LinkBar = document.getElementById("link-bar");

menuBarAccessory.addEventListener("click", () => {
    console.log(menuBar.style.display);
    if (menuBar.style.display === "none" || menuBar.style.display === "") {
        menuBar.style.display = "flex";
    } else {
        menuBar.style.display = "none";
    }
});
hamburgerBar.addEventListener("click", () => {
    console.log(LinkBar.style.display);
    if (LinkBar.style.display === "none" || LinkBar.style.display === "") {
        LinkBar.style.display = "flex";
    } else {
        LinkBar.style.display = "none";
    }
});
window.onresize = function (event) {
    console.log(window.innerWidth);
    if (window.innerWidth >= 860) {
        LinkBar.style.display = "flex";
    } else {
        LinkBar.style.display = "none";
    }
};

const index = GetURLParameter("id");

let columnist;
let columnistItem;

function fillData() {
    $.ajax({
        type: "GET",
        url: "/Posts/Write/GetColumnistItem"
    }).done(function (response) {
        columnistItem = response;
        $.ajax({
            type: "GET",
            url: "/Posts/Write/GetColumnist"
        }).done(function (response) {
            columnist = response;
            response.forEach(item => {
                const link = $("<option></option>", {
                    value: item.id,
                    text: item.name,
                });
                $("#comlumnist").append(link);
            });
            loadColumnist();
        });
    });
}

function loadColumnist() {
    $("#comlumnistItem").empty();
    if (columnistItem != null) {
        columnistItem.filter(c => c.columnistId == $("#comlumnist").val()).forEach(item => {
            const link = $("<option></option>", {
                value: item.id,
                text: item.name,
            });
            $("#comlumnistItem").append(link);
        });
    }
}

function loadForm() {
    $('#content').summernote({
        tabsize: 2,
        height: 500,
    });
    $("#comlumnist").change(function () {
        loadColumnist();
    });
    $("#submit").click(function () {
        let content = $('#content').summernote('code');
        let imgs = $.parseHTML($('#content').summernote('code'));
        const link = $("<div></div>");
        link.append(imgs[0]);
        console.log(link.find('img'));
    });
}

fillData();
loadForm();
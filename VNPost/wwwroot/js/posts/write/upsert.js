const id = GetURLParameter("id");

let columnistItemId;
let columnist;
let columnistItem;

//get data of article from server
function getData() {
    let url = (id == null) ? "/api/articles/0" : "/api/articles/" + id
    $.ajax({
        type: "GET",
        url: url,
    }).done(function (response) {
        if (response != undefined) {
            $("#title").val(response.title);
            $("#description").val(response.description);
            $("#author").val(response.author);
            columnistItemId = response.columnistItemId;
            $('#content').summernote('code', response.content);
            //after get article data, load data to select tag
            $.ajax({
                type: "GET",
                url: "/api/columnistItems"
            }).done(function (response) {
                columnistItem = response;
                columnistItem.forEach(citem => {
                    if (citem.id == columnistItemId) {
                        loadColumnistItem(citem);
                    }
                });
            });
        }
        else {
            $.ajax({
                type: "GET",
                url: "/api/columnistItems"
            }).done(function (response) {
                columnistItem = response;
                loadColumnistItem(0);
            });
        }
    });
}

//load data to columnist item
function loadColumnistItem(citem) {
    $.ajax({
        type: "GET",
        url: "/api/columnists"
    }).done(function (response) {
        columnist = response;
        response.forEach(c => {
            const link = $("<option></option>", {
                value: c.id,
                text: c.name,
                selected: citem.columnistId == c.id ? true : false,
            });
            $("#comlumnist").append(link);
        });
        loadColumnist();
    });
}

//load data to columnist
function loadColumnist() {
    $("#comlumnistItem").empty();
    if (columnistItem != null) {
        columnistItem.filter(c => c.columnistId == $("#comlumnist").val()).forEach(item => {
            const link = $("<option></option>", {
                value: item.id,
                text: item.name,
                selected: columnistItemId == item.id ? true : false,
            });
            $("#comlumnistItem").append(link);
        });
    }
}


//load data to form 
function loadForm() {
    getData();
    $('#content').summernote({
        tabsize: 2,
        height: 500,
    });
    $("#comlumnist").change(function () {
        loadColumnist();
    });
    //send data to server
    $("#submit").click(function () {
        let content = $('#content').summernote('code');
        let element = $.parseHTML($('#content').summernote('code'));
        const link = $("<div></div>");
        link.append(element);

        let title = $("#title").val();
        let description = $("#description").val();
        let author = $("#author").val();
        let comlumnistItemId = $("#comlumnistItem").val();
        let descriptionImg;

        //if content don't have image, use default image
        if (link.find('img').length == 0) {
            descriptionImg = "http://www.vnpost.vn/Portals/_default/Skins/VNPost.Skins.FrontEnd//img/vnpost-logo.png";
        } else {
            let firstImg = link.find('img').attr('src');
            descriptionImg = (firstImg);
        }

        let article = {
            Title: title,
            Description: description,
            Author: author,
            DescriptionImg: descriptionImg,
            Content: content,
        }

        let url = (id == null)
            ? "/api/articles?comlumnistItemId=" + comlumnistItemId
            : "/api/articles/" + id + "?comlumnistItemId=" + comlumnistItemId;
        let method = (id == null) ? "POST" : "PUT";
        $.ajax({
            type: method,
            data: JSON.stringify(article),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            url: url,
        }).done(function (data) {
            if (data.success) {
                toastr.success(data.message);
                if (id == null) {
                    $('#content').summernote('code', "")
                    $("#title").val("");
                    $("#description").val("");
                    $("#author").val("");
                }
            }
            else {
                toastr.error(data.message);
            }
        });
    });
}

loadForm();
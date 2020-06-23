const id = GetURLParameter("id");

let columnistItemId;
let columnist;
let columnistItem;

/*get data of article from server*/
function getData() {
    let url = (id == null) ? "/api/articles/0" : "/api/articles/" + id
    $.ajax({
        type: "GET",
        url: url,
    }).done(function (response) {
        /*if article from server not null, fill data of article to form.
         else create new article*/
        if (response != undefined) {
            $("#title").val(response.title);
            $("#description").val(response.description);
            $("#author").val(response.author);
            columnistItemId = response.columnistItemId;
            $('#content').summernote('code', response.content);
            /*after get article data, load data to select tag*/
            $.ajax({
                type: "GET",
                url: "/api/columnistItems"
            }).done(function (response) {
                columnistItem = response;
                /*if columnist item id equal columnist item id of article, generate columnist item*/
                columnistItem.forEach(citem => {
                    if (citem.id == columnistItemId) {
                        loadColumnists(citem);
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
                loadColumnists(0);
            });
        }
    });
}

/*load data to columnist*/
function loadColumnists(citem) {
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
        loadColumnistItem();
    });
}

/*load data to columnist item*/
function loadColumnistItem() {
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


/*load data to form */
function loadForm() {
    getData();
    $('#content').summernote({
        tabsize: 2,
    });
    $(function () {
        $('#content').each(function () {
            $(this).height($(this).prop('scrollHeight'));
        });
    });
    $("#comlumnist").change(function () {
        loadColumnistItem();
    });
    /*send data to server*/
    $("#submit").click(function () {
        /*get src code from textarea*/
        let content = $('#content').summernote('code');
        /*generate src code to html element*/
        let element = $.parseHTML($('#content').summernote('code'));
        /*create a div to contain element had been generated*/
        const link = $("<div></div>");
        link.append(element);

        let title = $("#title").val();
        let description = $("#description").val();
        let author = $("#author").val();
        let comlumnistItemId = $("#comlumnistItem").val();
        let descriptionImg;

        /*if content don't have image, use default image*/
        if (link.find('img').length == 0) {
            descriptionImg = "http://www.vnpost.vn/Portals/_default/Skins/VNPost.Skins.FrontEnd//img/vnpost-logo.png";
        } else {
            /*get fist image found from div contain all element from textarea*/
            let firstImg = link.find('img').attr('src');
            descriptionImg = (firstImg);
        }
        /*generate article */
        let article = {
            Title: title,
            Description: description,
            Author: author,
            DescriptionImg: descriptionImg,
            Content: content,
        }

        /*select url to send to server */
        let url = (id == null)
            ? "/api/articles?comlumnistItemId=" + comlumnistItemId
            : "/api/articles/" + id + "?comlumnistItemId=" + comlumnistItemId;
        /*select method to send to server */
        let method = (id == null) ? "POST" : "PUT";
        /*send data to server and show message from server */
        $.ajax({
            type: method,
            data: JSON.stringify(article),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            url: url,
        }).done(function (data) {
            if (data.success) {
                toastr.success(data.message);
                /*if generate new article clean all input*/
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
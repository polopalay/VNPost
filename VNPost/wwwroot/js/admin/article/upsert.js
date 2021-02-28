const id = GetURLParameter("id");
let userId;
let columnistItemId;
let columnist;
let columnistItem;
let editor;

function getData() {
    if (id != null) {
        fetch("/api/articles/" + id).then(rs => rs.json()).then(response => {
            fetch("/api/User?getId=true").then(rs => rs.text()).then(result => {
                userId = result;
                $("#title").val(response.title);
                $("#description").val(response.description);
                $("#author").val(response.author);
                columnistItemId = response.columnistItemId;
                editor.setData(response.content)
                fetch("/api/columnists/" + userId).then(rs => rs.json()).then((rs) => {
                    columnist = rs;
                    columnistItem.forEach(citem => {
                        if (citem.id == columnistItemId) {
                            loadColumnists(citem);
                        }
                    });
                })
            })
        })
    }
    else {
        fetch("/api/User?getId=true").then(rs => rs.text()).then(result => {
            userId = result;
            fetch("/api/columnists/" + userId).then(rs => rs.json()).then((rs) => {
                columnist = rs;
                loadColumnists(0);
            })
        })
    }
}

function loadColumnists(citem) {
    if (columnist != null) {
        $("#comlumnist").empty();
        columnist.filter(cl => cl.fatherId == 0).forEach(c => {
            const link = $("<option></option>", {
                value: c.id,
                text: c.name,
                selected: citem.fatherId == c.id ? true : false,
            });
            $("#comlumnist").append(link);
        });
        loadColumnistItem();
    }
}

function loadColumnistItem() {
    if (columnist != null) {
        $("#comlumnistItem").empty();
        columnist.filter(cl => cl.fatherId == $("#comlumnist").val()).forEach(item => {
            const link = $("<option></option>", {
                value: item.id,
                text: item.name,
                selected: columnistItemId == item.id ? true : false,
            });
            $("#comlumnistItem").append(link);
        });
    }
}


function loadForm() {
    getData();
    ClassicEditor.create(document.querySelector('#content'))
        .then(newEditor => {
            editor = newEditor;
        })
    $(function () {
        $('#content').each(function () {
            $(this).height($(this).prop('scrollHeight'));
        });
    });
    $("#comlumnist").change(function () {
        loadColumnistItem();
    });

    $("#submit").click(function () {
        let content = editor.getData()
        let element = $.parseHTML(editor.getData());
        const link = $("<div></div>");
        link.append(element);

        let title = $("#title").val();
        let description = $("#description").val();
        let author = $("#author").val();
        let comlumnistItemId = $("#comlumnistItem").val();
        let descriptionImg;

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
                    editor.setData("")
                    $("#title").val("");
                    $("#description").val("");
                    $("#author").val("");
                }
            }
            else {
                toastr.error(data.message);
            }
        })
    });
}

loadForm();
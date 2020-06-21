const id = GetURLParameter("id");

function getArticle() {
    $.ajax({
        type: "GET",
        url: "/api/articles/" + id,
    }).done(function (result) {
        let title = $("<h2></h2>", {
            text: result.title,
        })
        let dateCreate = $("<p></p>", {
            text: dateDMY(result.dateCreate),
        })
        let content = $("<div></div>", {
            class: "content",
        })
        content.append(result.content);
        let info = $("<div></div>", {
            class: "info",
        })
        let view = $("<i></i>", {
            class: "fas fa-eye",
            text: "Lượt xem:" + result.view,
        })
        let author = $("<span></span>", {
            text: result.author,
        })
        info.append(view);
        info.append(author);
        $("#right").append(title);
        $("#right").append(dateCreate);
        $("#right").append(content);
        $("#right").append(info);
        getMostNew();
    });
}

function getMostNew() {
    $.ajax({
        type: "GET",
        url: "/api/articles?getLatest=true",
    }).done(function (result) {
        let otherArticle = $("<h1></h1>", {
            text: "Các tin khác",
        });
        let mostNew = $("<div></div>", {
            class: "most-new",
        });
        let list = $("<ul></ul>");
        for (let i = 0; i < result.length; i++) {
            let item = $("<li></li>", {
                class: "fas fa-angle-right",
            });
            let link = $("<a></a>", {
                href: "/Posts/Article/ArticleDetail?id=" + result[i].id,
                text: result[i].title,
            })
            let date = $("<span></span>", {
                text: dateDMY(result[i].dateCreate),
            })
            let img = $("<img></img>", {
                src: "http://www.vnpost.vn/Portals/_default/Skins/VNPost.Skins.FrontEnd/img/new-icon.png",
            });
            item.append(link);
            item.append(date);
            if (i == 0) {
                item.append(img);
            }
            list.append(item);
        }
        mostNew.append(list);
        $("#right").append(otherArticle);
        $("#right").append(mostNew);
    });
}
getArticle();
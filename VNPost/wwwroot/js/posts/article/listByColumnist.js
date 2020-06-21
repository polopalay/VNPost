const columnistId = (GetURLParameter("columnistId") == null || !/^\d+$/.test(GetURLParameter("columnistId")))
    ? 0 : GetURLParameter("columnistId");
const columnistItemId = (GetURLParameter("columnistItemId") == null || !/^\d+$/.test(GetURLParameter("columnistItemId")))
    ? 0 : GetURLParameter("columnistItemId");
const index = GetURLParameter("index") == null ? 1 : GetURLParameter("index");

$.ajax({
    type: "GET",
    "url": "/api/articles?numberPostInPage=6&columnistId=" + columnistId + "&columnistItemId=" + columnistItemId + "&index=" + index,
}).done(function (result) {
    result.forEach(item => {
        let container = $("<div></div>");
        let title = $("<a></a>", {
            href: "/Posts/Article/ArticleDetail/" + item.id,
            text: item.title,
        });

        let contentContainer = $("<div></div>");
        let imgContainer = $("<div></div>", {
            class: "img-container",
        });
        let img = $("<img></img>", {
            src: item.descriptionImg,
        });
        let descriptionContainer = $("<div></div>", {
            class: "des-container",
        });
        let dateCreate = $("<span></span>", {
            text: item.dateCreate,
        });
        let description = $("<p></p>", {
            text: softDescription(item.description),
        });
        descriptionContainer.append(dateCreate);
        descriptionContainer.append(description);

        container.append(title);
        imgContainer.append(img);
        contentContainer.append(imgContainer);
        contentContainer.append(descriptionContainer);
        container.append(contentContainer);
        $("#listArticle").append(container);
    });
});


$.ajax({
    type: "GET",
    "url": "/api/articles?numberPostInPage=6&getPagination=true&columnistId=" + columnistId + "&columnistItemId=" + columnistItemId + "&index=" + index,
}).done(function (data) {
    $("#pagination").empty();
    for (let i = data.begin; i <= data.end; i++) {
        const link = $("<a></a>", {
            class: i == index ? "current-page" : "",
            href: "/Posts/Article/ListColumnist?columnistId=" + columnistId + "&columnistItemId=" + columnistItemId + "&index=" + i,
            text: i,
        });
        $("#pagination").append(link);
    }
});
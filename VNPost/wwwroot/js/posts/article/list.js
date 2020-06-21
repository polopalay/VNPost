function generateMenuBar(item, columnistItems) {
    let containList = $("<div></div>", {
        class: "article-columnist",
    });
    let unorderList = $("<ul></ul>");
    let element = $("<li></li>", {
    });

    let link = $("<a></a>", {
        text: item.name,
        class: "link-columnist",
        href: "/Posts/Article/ListColumnist?columnistId=" + item.id,
    });
    /*add li with link to columnist to ul*/
    element.append(link);
    unorderList.append(element);

    const listColumnistItem = columnistItems.filter(c => c.columnistId == item.id);
    /*if number of item larger than 1 create a list to link to columnist item*/
    if (listColumnistItem.length > 1) {
        listColumnistItem.forEach(c => {
            let elementItem = $("<li></li>", {
            });

            let linkItem = $("<a></a>", {
                text: c.name,
                class: "link-columnistItem",
                href: "/Posts/Article/ListColumnist?columnistItemId=" + c.id,
            });
            /*add li with link to columnist item to ul*/
            elementItem.append(linkItem);
            unorderList.append(elementItem);
        })
    }

    /*add add element to right div*/
    containList.append(unorderList);
    $("#right").append(containList);
}

function generateListArtile(item) {
    /*create a gallery to contain 3 div*/
    let containArticle = $("<div></div>", {
        class: "article-list",
    });
    /*div contain latest article*/
    let containArticleTop1 = $("<div></div>", {
        class: "article-description",
    });
    /*div contain top 4 latest article*/
    let containArticleList = $("<div></div>", {
        class: "article-soft-list",
    });
    /*div contain most view article*/
    let containArticleMostView = $("<div></div>", {
        class: "article-right",
    });

    $.ajax({
        type: "GET",
        "url": "/api/articles?getTop5ByDate=true",
    }).done(function (data) {
        /*find article by columnist*/
        const listArticle = data.filter(a => a.columnistItem.columnistId == item.id);
        /*create latest article*/
        if (listArticle.length > 0) {
            /*create title*/
            let title = $("<h5></h5>");
            let titleLink = $("<a></a>", {
                text: listArticle[0].title,
                href: "/Posts/Article/ArticleDetail/" + listArticle[0].id,
            });
            /*create image*/
            let img = $("<img></img>", {
                src: listArticle[0].descriptionImg,
            });
            /*create descripstion */
            let descripstion = $("<p></p>", {
                text: softDescription(listArticle[0].description),
            });
            /*add article to div*/
            title.append(titleLink);
            containArticleTop1.append(title);
            containArticleTop1.append(img);
            containArticleTop1.append(descripstion);
            listArticle.shift();
        }
        /*create top 4 latest article*/
        listArticle.forEach(article => {
            let top4Link = $("<a></a>", {
                text: article.title,
                href: "/Posts/Article/ArticleDetail/" + article.id,
            });
            containArticleList.append(top4Link);
        });
    });
    /*create most view article*/
    $.ajax({
        type: "GET",
        url: "/api/articles?getTop1ByView=true",
    }).done(function (data) {
        /*find article by columnist*/
        const listMostViewArticle = data.filter(a => a.columnistItem.columnistId == item.id);
        if (listMostViewArticle.length > 0) {
            let img = $("<img></img>", {
                src: listMostViewArticle[0].descriptionImg,
            });
            let title = $("<h5></h5>");
            let titleLink = $("<a></a>", {
                text: listMostViewArticle[0].title,
                href: "/Posts/Article/ArticleDetail/" + listMostViewArticle[0].id,
            });
            title.append(titleLink);
            containArticleMostView.append(img);
            containArticleMostView.append(title);
        }
    });

    /*add add element created to right*/
    containArticle.append(containArticleTop1);
    containArticle.append(containArticleList);
    containArticle.append(containArticleMostView);
    $("#right").append(containArticle);
}

$.ajax({
    type: "GET",
    "url": "/api/columnists",
}).done(function (columnists) {
    $.ajax({
        type: "GET",
        "url": "/api/columnistItems",
    }).done(function (columnistItems) {
        columnists.forEach(item => {
            generateMenuBar(item, columnistItems);
            generateListArtile(item);
        });
    })
})
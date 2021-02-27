const index = GetURLParameter("index") == null ? 1 : GetURLParameter("index");
const numberPostInPage = 100;
let table;

function loadTbl() {
    table = $('#tblData').DataTable({
        "paging": true,
        "info": true,
        "order": [2, "desc"],
        "lengthMenu": [10, 5, 1],
        "ajax": {
            type: "GET",
            url: "/api/articles?getByUSer=true&fillToDataTable=true&numberPostInPage=" + numberPostInPage + "&index=" + index,
        },
        "columns": [
            { "data": "Title", "width": "30%" },
            { "data": "IdentityUser.UserName", "width": "20%" },
            {
                "data": "DateCreate",
                "render": function (data) {
                    return dateDMY(data);
                }, "width": "20%"
            },
            { "data": "ColumnistItem.Name", "width": "20%" },
            {
                "data": "Id",
                "render": function (data) {
                    return `
                                    <div class="text-center">
                                        <a href="/Admin/Article/Upsert?id=${data}" class="btn btn-success" style="cursor:pointer">
                                            <i class="fas fa-edit"></i>
                                        </a>
                                        <button onclick=Delete("/api/articles/${data}") class="btn btn-danger" style="cursor:pointer">
                                            <i class="fas fa-trash-alt"></i>
                                        </button>
                                    </div>
                                   `;
                }, "width": "10%"
            }
        ]
    });
}

function loadPaging() {
    $.ajax({
        type: "GET",
        "url": "/api/articles?getByUSer=true&fillToDataTable=true&numberPostInPage=" + numberPostInPage + "&getPagination=true&index=" + index,
    }).done(function (data) {
        $("#pagination").empty();
        for (let i = data.begin; i <= data.end; i++) {
            const list = $("<li></li>", {
                class: i == index ? "page-item disabled" : "page-item",
            });
            const link = $("<a></a>", {
                class: "page-link",
                href: "/Posts/Write/Index?index=" + i,
                text: i,
            });
            list.append(link);
            $("#pagination").append(list);
        }
    }).fail(function () {
        toastr.error("Error to send request to server");
    });
}

function Delete(url) {
    $.ajax({
        type: "DELETE",
        url: url,
    }).done(function (data) {
        if (data.success) {
            toastr.success(data.message);
            table.ajax.reload();
        }
        else {
            toastr.error(data.message);
        }
    }).fail(function () {
        toastr.error("Error to send request to server");
    });
}

function load() {
    loadTbl();
    loadPaging();
}

load();
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
                                        <a href="/Admin/Article/Upsert?id=${data}" class="btn btn-success text-white" style="cursor:pointer">
                                            <i class="fas fa-edit"></i>
                                        </a>
                                        <button onclick=Delete("/api/articles/${data}") class="btn btn-danger text-white" style="cursor:pointer">
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

function checkPermision() {
    $.ajax({
        type: "GET",
        url: "/api/user",
    }).done(function (data) {
        if (data) {
            let link = $("<a></a>", {
                href: "/Admin/Manager",
                class: "btn btn-warning text-white",
            })
            let i = $("<i></i>", {
                class: "fas fa-tasks",
            });
            link.append(i);
            link.append(" Quản lý loại người dùng");
            $("#user").append(link);
            link = $("<a></a>", {
                href: "/Admin/RegisterTypeUser",
                class: "btn btn-primary text-white ml-1",
            })
            i = $("<i></i>", {
                class: "fas fa-user-plus",
            });
            link.append(i);
            link.append(" Quản lý người dùng");
            $("#user").append(link);
        }
        loadType();
    }).fail(function () {
        toastr.error("Error to send request to server");
    });
}

function loadType() {
    $.ajax({
        type: "GET",
        url: "/api/user?getType=true",
    }).done(function (data) {
        let link = $("<a></a>", {
            class: "btn btn-secondary text-white ml-1",
        });
        let i;
        if (data == "Admin") {
            i = $("<i></i>", {
                class: "fas fa-user-cog",
            });
        }
        else {
            i = $("<i></i>", {
                class: "fas fa-user",
            });
        }
        link.append(i);
        data = (data == null ? "Không có quyền hạn" : data);
        link.append(" " + data);
        $("#user").append(link);
        loadName();
    }).fail(function () {
        toastr.error("Error to send request to server");
    });
}

function loadName() {
    $.ajax({
        type: "GET",
        url: "/api/user?getName=true",
    }).done(function (data) {
        let link = $("<a></a>", {
            class: "btn btn-info text-white ml-1",
        });
        let i = $("<i></i>", {
            class: "fas fa-signature",
        });
        link.append(i);
        data = (data == null ? "Vô danh" : data);
        link.append(" " + data);
        $("#user").append(link);
    }).fail(function () {
        toastr.error("Error to send request to server");
    });
}

load();
checkPermision();
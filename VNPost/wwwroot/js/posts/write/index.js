﻿const index = GetURLParameter("index") == null ? 1 : GetURLParameter("index");
let table;

function loadTbl() {
    table = $('#tblData').DataTable({
        "paging": true,
        "info": true,
        "order": [2, "desc"],
        "lengthMenu": [8, 6, 4, 2, 1],
        "ajax": {
            type: "GET",
            url: "/api/articles?getAll=true&fillToDataTable=true&numberPostInPage=8&index=" + index,
        },
        "columns": [
            { "data": "Title", "width": "50%" },
            { "data": "Author", "width": "20%" },
            { "data": "DateCreate", "width": "20%" },
            {
                "data": "Id",
                "render": function (data) {
                    return `
                                    <div class="text-center">
                                        <a href="/Posts/Write/Upsert?id=${data}" class="btn btn-success text-white" style="cursor:pointer">
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
        "url": "/api/articles?getAll=true&fillToDataTable=true&numberPostInPage=8&getPagination=true&index=" + index,
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
    })
}

function Delete(url) {
    $.ajax({
        type: "DELETE",
        url: url,
        success: function (data) {
            if (data.success) {
                toastr.success(data.message);
                table.ajax.reload();
            }
            else {
                toastr.error(data.message);
            }
        }
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
        let link = $("<a></a>", {
            href: "/Admin/Manager",
            class: "btn btn-warning text-white",
        })
        let i = $("<i></i>", {
            class: "fas fa-tasks",
        });
        link.append(i);
        link.append(" Quản lý người dùng");
        if (data) {
            $("#user").append(link);
        }
        loadType();
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
        data = (data == null ? "No type" : data);
        link.append(" " + data);
        $("#user").append(link);
    });
}

load();
checkPermision();
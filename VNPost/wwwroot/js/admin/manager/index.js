const index = GetURLParameter("index") == null ? 1 : GetURLParameter("index");
const numberPostInPage = 100;
let table;

function loadTbl() {
    table = $('#tblData').DataTable({
        "paging": true,
        "info": true,
        "lengthMenu": [10, 5],
        "ajax": {
            type: "GET",
            url: "/api/permision?numberPostInPage=" + numberPostInPage + "&index=" + index,
        },
        "columns": [
            { "data": "Name", "width": "50%" },
            {
                "data": "Id",
                "render": function (data) {
                    return `
                                    <div class="text-center">
                                        <a href="/Admin/Manager/Upsert?id=${data}" class="btn btn-success text-white" style="cursor:pointer">
                                            <i class="fas fa-edit"></i>
                                        </a>
                                        <button onclick=Delete("/api/permision/${data}") class="btn btn-danger text-white" style="cursor:pointer">
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
        "url": "/api/permision?getPagination=true&numberPostInPage=" + numberPostInPage + "&index=" + index,
    }).done(function (data) {
        $("#pagination").empty();
        for (let i = data.begin; i <= data.end; i++) {
            const list = $("<li></li>", {
                class: i == index ? "page-item disabled" : "page-item",
            });
            const link = $("<a></a>", {
                class: "page-link",
                href: "/Admin/Manager/Index?getPagination=true&numberPostInPage=" + numberPostInPage + "&index=" + i,
                text: i,
            });
            list.append(link);
            $("#pagination").append(list);
        }
    })
}

function load() {
    loadTbl();
    loadPaging();
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

load();
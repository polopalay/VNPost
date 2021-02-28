const index = GetURLParameter("index") == null ? 1 : GetURLParameter("index");
let table;

function loadTbl() {
    table = $('#tblData').DataTable({
        "paging": true,
        "info": true,
        "order": [2, "desc"],
        "lengthMenu": [10, 5, 1],
        "ajax": {
            type: "GET",
            url: "/api/articles",
        },
        "columns": [
            { "data": "title", "width": "30%" },
            { "data": "author", "width": "20%" },
            {
                "data": "dateCreate",
                "render": function (data) {
                    return dateDMY(data);
                }, "width": "20%"
            },
            { "data": "columnist.name", "width": "20%" },
            {
                "data": "id",
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
}

load();
const index = GetURLParameter("index") == null ? 1 : GetURLParameter("index");
let table;

function loadTbl(data) {
    table=$('#tblData').DataTable({
        "paging": true,
        "info": true,
        "order": [2, "desc"],
        "lengthMenu": [4, 8, 16],
        "aaData": data.listT,
        "columns": [
            { "data": "title", "width": "50%" },
            { "data": "author", "width": "20%" },
            { "data": "dateCreate", "width": "20%" },
            {
                "data": "id",
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
function loadPaging(data) {
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
}

function load() {
    $.ajax({
        type: "GET",
        "url": "/api/articles?index=" + index,
    }).done(function (data) {
        loadTbl(data);
        loadPaging(data);
    })
}

function Delete(url) {
    $.ajax({
        type: "DELETE",
        url: url,
        success: function (data) {
            if (data.success) {
                toastr.success(data.message);
                table.destroy();
                load();
            }
            else {
                toastr.error(data.message);
            }
        }
    });
}

load();
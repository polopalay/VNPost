const index = GetURLParameter("index") == null ? 1 : GetURLParameter("index");

function loadTbl(data) {
    $('#tblData').DataTable({
        "paging": false,
        "info": false,
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
                                        <button onclick=Delete("/Admin/Category/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">
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
        "url": "/Posts/Write/GetAll?index=" + index,
    }).done(function (data) {
        loadTbl(data);
        loadPaging(data);
    })
}

load();
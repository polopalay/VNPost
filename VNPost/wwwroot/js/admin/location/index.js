let table;

function loadTbl() {
    table = $('#tblData').DataTable({
        "paging": true,
        "info": true,
        "lengthMenu": [10, 5, 1],
        "ajax": {
            type: "GET",
            url: "/api/location/province",
        },
        "columns": [
            { "data": "name", "width": "40%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                                    <div class="text-center">
                                        <a href="/Admin/Location/District/${data}" class="btn btn-info" style="cursor:pointer">
                                            <i class="fas fa-list-ul"></i>
                                        </a>
                                    </div>
                                   `;
                }, "width": "20%"
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                                    <div class="text-center">
                                        <button onclick=updateProvince(${data}) class="btn btn-warning" style="cursor:pointer">
                                            <i class="fas fa-pencil-alt"></i>
                                        </button>
                                    </div>
                                   `;
                }, "width": "20%"
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                                    <div class="text-center">
                                        <button onclick=deleteProvince("/api/location/province/${data}") class="btn btn-danger" style="cursor:pointer">
                                            <i class="fas fa-trash"></i>
                                        </button>
                                    </div>
                                   `;
                }, "width": "20%"
            }
        ]
    });
}
function addProvince() {
    document.getElementById('addProvince').onclick = () => {
        swal("Enter name:", {
            content: "input",
        }).then((value) => {
            const myHeaders = new Headers();
            myHeaders.append("Content-Type", "application/json");
            const raw = JSON.stringify({ name: value });
            const requestOptions = {
                method: "PUT",
                headers: myHeaders,
                body: raw,
                redirect: "follow",
            };
            fetch("/api/location/province", requestOptions)
                .then((response) => response.text())
                .then((result) => {
                    swal(result);
                    table.ajax.reload();
                });
        });
    }
}
function deleteProvince(url) {
    const requestOptions = {
        method: "DELETE",
        redirect: "follow",
    };
    fetch(url, requestOptions).then(rs => rs.text()).then(rs => {
        swal(rs);
        table.ajax.reload();
    })
}
function updateProvince(id) {
    swal("Enter name:", {
        content: "input",
    }).then((value) => {
        const myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");
        const raw = JSON.stringify({ id: id, name: value });
        const requestOptions = {
            method: "POST",
            headers: myHeaders,
            body: raw,
            redirect: "follow",
        };
        fetch("/api/location/province", requestOptions)
            .then((response) => response.text())
            .then((result) => {
                swal(result);
                table.ajax.reload();
            });
    });
}
loadTbl();
addProvince();
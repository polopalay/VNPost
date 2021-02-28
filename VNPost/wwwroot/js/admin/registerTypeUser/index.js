let table;
function loadData() {
    $.ajax({
        type: "GET",
        url: "/api/role?dontPaging=true",
    }).done(function (result) {
        loadTbl(result);
    }).fail(function () {
        toastr.error("Error to send request to server");
    });
}

function loadTbl(permision) {
    table = $('#tblData').DataTable({
        "paging": true,
        "info": true,
        "order": [0, "desc"],
        "lengthMenu": [10, 5, 1],
        "ajax": {
            type: "GET",
            url: "/api/user?getAll=true",
        },
        "columns": [
            { "data": "IdentityUser.UserName", "width": "35%" },
            {
                "data": "IdentityRole",
                "render": function (data) {
                    return data == null ? "Không có quyền hạn" : data.Name;
                }
                , "width": "20%"
            },
            {
                "data": {},
                "render": function (data) {
                    if (data.IdentityRole == null) {
                        let select = `<select id="select${data.IdentityUser.Id}" onchange=change("${data.IdentityUser.Id}") class="form-control w-75">`;
                        select += `<option value="">Không có quyền hạn</option>`;
                        permision.forEach(item => {
                            select += `<option value="${item.id}">${item.name}</option>`;
                        });
                        select += `</select>`;
                        return select;
                    }
                    else if (permision.filter(x => x.id == data.IdentityRole.Id).length == 0) {
                        return data.IdentityRole.Name;
                    }
                    else {
                        let select = `<select id="select${data.IdentityUser.Id}" onchange=change("${data.IdentityUser.Id}") class="form-control w-75">`;
                        select += `<option value="">Không có quyền hạn</option>`;
                        permision.forEach(item => {
                            let selected = item.id == data.IdentityRole.Id ? "selected" : "";
                            select += `<option value="${item.id}" ${selected}>${item.name}</option>`;
                        });
                        select += `</select>`;
                        return select;
                    }
                }, "width": "35%"
            },
            {
                "data": {},
                "render": function (data) {
                    if (data.IdentityRole != null && permision.filter(x => x.id == data.IdentityRole.Id).length == 0) {
                        return "";
                    }
                    else {
                        return `
                                    <div class="text-center">
                                        <button id="btn${data.IdentityUser.Id}" onclick=save("${data.IdentityUser.Id}") class="btn btn-success text-white" style="cursor:pointer">
                                            <i class="fas fa-save"></i>
                                        </button>
                                        <button onclick=remove("${data.IdentityUser.Id}") class="btn btn-danger text-white" style="cursor:pointer">
                                           <i class="fas fa-trash-alt"></i>
                                        </button>
                                   `;
                    }
                }, "width": "10%"
            }
        ]
    });
}

function save(data) {
    $.ajax({
        type: "POST",
        url: "/api/user/" + data,
        data: JSON.stringify($("#select" + data).val()),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
    }).done(function (result) {
        if (result.success) {
            table.ajax.reload();
            $("#btn" + data).attr("class", "btn btn-success text-white");
            toastr.success(result.message);
        }
        else {
            toastr.error(result.message);
        }
    }).fail(function () {
        toastr.error("Error to send request to server");
    });
}
function remove(data) {
    $.ajax({
        type: "DELETE",
        url: "/api/user/" + data,
    }).done(function (result) {
        if (result.success) {
            table.ajax.reload();
            toastr.success(result.message);
        }
        else {
            toastr.error(result.message);
        }
    }).fail(function () {
        toastr.error("Error to send request to server");
    });
}

function change(data) {
    $("#btn" + data).attr("class", "btn btn-warning text-white");
}

loadData();
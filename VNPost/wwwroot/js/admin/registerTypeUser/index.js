let s;
$.ajax({
    type:"GET",
    url:"/api/permision?dontPaging=true",
}).done(function (result) {
    result.forEach(item => {
        $("#select").append($("<option></option>", {
            text: item.name,
            value:item.id,
        }));
    });
});

$("#button").click(function () {
    const data = $("#select").val();
    let rs;
    $.ajax({
        type:"POST",
        url: "/api/user",
        data: JSON.stringify(data.toString()),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
    }).done(function (result) {
        rs = result;
        if (rs.success) {
            toastr.success(rs.message);
        }
        else {
            toastr.error(rs.message);
        }
    });
})

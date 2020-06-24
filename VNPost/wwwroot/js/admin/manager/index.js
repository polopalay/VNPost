let columnists;
let columnistItems;
let permisions = [];
let curd;

function loadDataToCheckBox() {
    $.ajax({
        type: "GET",
        url: "/api/columnists",
    }).done(function (c) {
        columnists = c;
        $.ajax({
            type: "GET",
            url: "/api/columnistItems",
        }).done(function (ci) {
            columnistItems = ci;
            /*all list checkbox for columnist*/
            c.forEach(citem => {
                const columnistsLi = $("<li></li>");
                const containOption = $("<label></label>");
                const cko = $("<input></input>", {
                    type: "checkbox",
                    value: citem.id,
                    id: "c" + citem.id,
                });
                containOption.append(cko);
                containOption.append(citem.name);
                columnistsLi.append(containOption);

                const columnistItemsContainer = $("<ul></ul>");
                /*add list checkbox for columnist item by columnist*/
                ci.filter(x => x.columnistId == citem.id).forEach(ciitem => {
                    const columnistItemsLi = $("<li></li>");
                    const containItemOption = $("<label></label>");
                    const cko = $("<input></input>", {
                        type: "checkbox",
                        value: ciitem.id,
                        id: "ci" + ciitem.id,
                    });
                    containItemOption.append(cko);
                    containItemOption.append(ciitem.name);
                    columnistItemsLi.append(containItemOption);
                    columnistItemsContainer.append(columnistItemsLi);
                });
                columnistsLi.append(columnistItemsContainer);
                $("#columnistContainer").append(columnistsLi);
            });
            addActionToCheckBoxColumnist();
            addActionToCheckBoxColumnistItem();
            /*add action to list permistsions*/
            $("#listColumnist").change(function () {
                changeOption();
            });
        });
    });
}

function addActionToCheckBoxColumnistItem() {
    columnistItems.forEach(columnistItem => {
        $("#ci" + columnistItem.id).change(function (event) {
            /*if columnist item checked or uncheked,remove or add item in permisions*/
            if ($(this).is(':checked')) {
                let listCurd = [];
                curd.forEach(curdItem => {
                    let checked = { id: curdItem.id, state: true, };
                    listCurd.push(checked);
                });
                /*item to add permision*/
                const item = {
                    id: columnistItem.id,
                    name: columnistItem.name,
                    cid: columnistItem.columnistId,
                    curd: listCurd,
                };
                /*if columnist contain this item don't check, check it*/
                if (permisions.filter(x => x.id == columnistItem.id) == 0) {
                    permisions.push(item);
                    $("#c" + columnistItem.columnistId).prop("checked", true);
                }
            } else {
                /*remove permision to list permision*/
                permisions = permisions.filter(x => x.id != columnistItem.id);
                /*un check columnist if columnist don't have item checked*/
                columnists.forEach(columnist => {
                    if (permisions.filter(x => x.cid == columnist.id) == 0) {
                        $("#c" + columnist.id).prop("checked", false);
                    }
                });
            }
            addOption();
        });
    });
}

function addActionToCheckBoxColumnist() {
    columnists.forEach(columnist => {
        $("#c" + columnist.id).change(function (event) {
            /*if columnist cheked or unchecked, check or uncheck all item it cotain*/
            if ($(this).is(':checked')) {
                columnistItems.filter(x => x.columnistId == columnist.id).forEach(citem => {
                    $("#ci" + citem.id).prop("checked", true);
                    let listCurd = [];
                    curd.forEach(curdItem => {
                        let checked = { id: curdItem.id, state: true, };
                        listCurd.push(checked);
                    });
                    const item = {
                        id: citem.id,
                        name: citem.name,
                        cid: columnist.id,
                        curd: listCurd,
                    };
                    if (permisions.filter(x => x.id == citem.id) == 0) {
                        permisions.push(item);
                    }
                });
            } else {
                columnistItems.filter(x => x.columnistId == columnist.id).forEach(citem => {
                    $("#ci" + citem.id).prop("checked", false);
                    permisions = permisions.filter(x => x.id != citem.id);
                });
            }
            addOption();
        });
    });
}

function addDataToCURD() {
    $.ajax({
        type: "GET",
        url: "/api/curd",
    }).done(function (result) {
        curd = result;
        /*add check box option update,create, delete*/
        result.forEach(item => {
            const inlist = $("<li></li>");
            const container = $("<label></label>");
            const checkbox = $("<input></input>", {
                type: "checkbox",
                value: item.id,
                id: "curd" + item.id,
            });
            container.append(checkbox);
            container.append(item.name);
            inlist.append(container);
            $("#curdContainer").append(inlist);
        });
        addOption();
        addOptionToCurd();
    });
}

function addOption() {
    $("#listColumnist").empty();
    permisions.forEach(data => {
        $("#listColumnist").append($("<option></option>", {
            value: data.id,
            text: data.name,
        }));
    });
    changeOption();
}

function changeOption() {
    if (permisions.filter(x => x.id == $("#listColumnist").val()).length > 0) {
        let firstColumnist = permisions.filter(x => x.id == $("#listColumnist").val())[0];
        /*set state of check box curd by data of permision*/
        firstColumnist.curd.forEach(curdItem => {
            $("#curd" + curdItem.id).prop("checked", curdItem.state);
        });
    }
}

function addOptionToCurd() {
    curd.forEach(curdItem => {
        $("#curd" + curdItem.id).change(function () {
            if ($("#listColumnist").val() != null) {
                /*set state curd of permision by state of checkbox curd*/
                permisions.filter(x => x.id == $("#listColumnist").val())[0].curd.filter(x => x.id == curdItem.id)[0].state = $(this).is(':checked');
                let allIsFalse = false;
                permisions.filter(x => x.id == $("#listColumnist").val())[0].curd.forEach(curdState => {
                    if (curdState.state) {
                        allIsFalse = curdState.state;
                    }
                });
                /*if all checkbox curd is unchecked, uncheck columnist item*/
                if (!allIsFalse) {
                    permisions = permisions.filter(x => x.id != $("#listColumnist").val());
                    let currentNeedFalse = $("#listColumnist").val();
                    $("#ci" + currentNeedFalse).prop("checked", false);
                    columnists.forEach(columnist => {
                        if (permisions.filter(x => x.cid == columnist.id) == 0) {
                            $("#c" + columnist.id).prop("checked", false);
                        }
                    });
                    addOption();
                }
            }
        });
    });
}

function submit() {
    $.ajax({
        type: "POST",
        data: JSON.stringify(permisions),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: "/api/permision",
    }).done(function (data) {
        alert('done');
    });
}

loadDataToCheckBox();
addDataToCURD();
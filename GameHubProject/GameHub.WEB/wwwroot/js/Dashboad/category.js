var category = {} || category;
category.deleted = function (id, name) {
    var result = confirm("Do you want to delete " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/category/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                console.log(response);
                alert(name +" "+response.data.message + " !");
                category.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
$(document).ready(function () {
    category.init();
})
category.init = function () {
    category.drawTable();
}
category.drawTable = function () {
    $('#categoryTable').empty();
    $.ajax({
        beforeSend: function () {   
            $('.ajax-loader').css("visibility", "visible");
        },
        url: "/Category/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            console.log(data);
            $.each(data.result, function (i, v) {
                var action = "";
                if (v.statusName == "Active") {
                    action = `<a href="javascripts:;"
                                       onclick="category.get(${v.categoryId})"><i class="fas fa-edit"></i></a>
                            <a href="javascripts:;"
                                        onclick="category.deleted(${v.categoryId}, '${v.categoryName}')"><i class="fas fa-trash"></i></a>`
                }
                else {
                    action = `
                            <a href="javascripts:;"
                                        onclick="category.deleted(${v.categoryId}, '${v.categoryName}')"><i class="fas fa-check-circle"></i></a>`
                }
                $('#categoryTable').append(
                    `<tr>
                        <td>${v.categoryId}</td>
                        <td>${v.categoryName}</td>
                        <td>${v.statusName}</td>
                        <td>
                            ${action}
                        </td>
                    </tr>`
                );
            });
        },
        complete: function () {
            $('.ajax-loader').css("visibility", "hidden");
        }
    });
}
category.openModal = function () {
    $('#CategoryName').val('');
    $('#addEditCategoryModal').modal('show');
    document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
}
category.get = function (id) {
    $.ajax({
        url: `/category/get/${id}`,
        method: "get",
        dataType: "json",
        success: function (response) {
            $('#CategoryName').val(response.result.categoryName);
            document.getElementById('CategoryId').value = response.result.categoryId;
            $('#addEditCategoryModal').modal('show');
            document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
        }
    });
    
}
category.save = function () {
    if ($('#frmAddEditCategory').valid()) {
        var saveObj = {};
        saveObj.categoryId = parseInt($('#CategoryId').val());
        saveObj.categoryName = $('#CategoryName').val();
        $.ajax({
            url: '/category/save',
            method: 'POST',
            dataType: 'JSON',
            contentType: 'application/json',
            data: JSON.stringify(saveObj),
            success: function (response) {
                console.log(response);
                bootbox.alert(response.data.message);
                if (response.data.categoryId > 0) {
                    $('#addEditCategoryModal').modal('hide');
                    category.drawTable();
                }
            }
        });
    }
}

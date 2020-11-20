var category = {} || category;

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
            $.each(data.result, function (i, v) {
                $('#categoryTable').append(
                    `<tr>
                        <td>${v.categoryId}</td>
                        <td>${v.categoryName}</td>
                        <td>
                            <a href="javascripts:;"
                                       onclick="category.get(${v.categoryId})"><i class="fas fa-edit"></i></a> 
                            <a href="javascripts:;"
                                        onclick="category.delete(${v.categoryId}, '${v.categoryName}')"><i class="fas fa-trash"></i></a>
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
                debugger;
                bootbox.alert(response.data.message);
                if (response.data.categoryId > 0) {
                    $('#addEditCategoryModal').modal('hide');
                    category.drawTable();
                }
            }
        });
    }
}

var brand = {} || brand;
brand.deleted = function (id, name) {
    var result = confirm("Do you want to delete " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/brand/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                console.log(response);
                alert(name + " " + response.data.message + " !");
                brand.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
brand.actived = function (id, name) {
    var result = confirm("Do you want to active " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/brand/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                console.log(response);
                alert(name + " " + response.data.message + " !");
                brand.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
$(document).ready(function () {
    brand.init();
})
brand.init = function () {
    brand.drawTable();
}
brand.drawTable = function () {
    $('#brandTable').empty();
    $.ajax({
        beforeSend: function () {
            $('.ajax-loader').css("visibility", "visible");
        },
        url: "/Brand/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data.result, function (i, v) {
                var action = "";
                if (v.statusName == "active") {
                    action = `<a href="javascripts:;"
                                       onclick="brand.get(${v.brandId})"><i class="fas fa-edit"></i></a>
                            <a href="javascripts:;"
                                        onclick="brand.deleted(${v.brandId}, '${v.brandName}')"><i class="fas fa-trash"></i></a>`
                }
                else {
                    action = `
                            <a href="javascripts:;"
                                        onclick="brand.actived(${v.brandId}, '${v.brandName}')"><i class="fas fa-check-circle"></i></a>`
                }
                $('#brandTable').append(
                    `<tr>
                        <td>${v.brandId}</td>
                        <td>${v.brandName}</td>
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
brand.openModal = function () {
    $('#BrandName').val('');
    $('#addEditCategoryModal').modal('show');
    document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
}
brand.save = function () {
    if ($('#frmAddEditCategory').valid()) {
        var saveObj = {};
        saveObj.brandId = parseInt($('#BrandId').val());
        saveObj.brandName = $('#BrandName').val();
        $.ajax({
            url: '/brand/save',
            method: 'POST',
            dataType: 'JSON',
            contentType: 'application/json',
            data: JSON.stringify(saveObj),
            success: function (response) {
                debugger;
                console.log(response);
                bootbox.alert(response.data.message);
                if (response.data.brandId > 0) {
                    $('#addEditCategoryModal').modal('hide');
                    brand.drawTable();
                }
            }
        });
    }
}

brand.get = function (id) {
    $.ajax({
        url: `/Brand/get/${id}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            $('#BrandName').val(response.data.brandName);
            document.getElementById('BrandId').value = response.data.brandId;
            $('#addEditCategoryModal').modal('show');
            document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
        }
    });
}
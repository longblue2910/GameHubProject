$(document).ready(function () {
    $('.js-example-basic-multiple').select2();
    $('#Description').summernote();
});

var game = {} || game;
game.deleted = function (id, name) {
    var result = confirm("Do you want to delete " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/game/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                console.log(response);
                alert(name + " " + response.data.message + " !");
                game.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
$(document).ready(function () {
    game.init();
})
game.init = function () {
    game.drawTable();
}
game.drawTable = function () {
    $('#gameTable').empty();
    $.ajax({
        beforeSend: function () {
            $('.ajax-loader').css("visibility", "visible");
        },
        url: "/game/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            console.log(data);
            $.each(data.result, function (i, v) {
                var action = "";
                if (v.statusName == "Active") {
                    action = `<a href="javascripts:;"
                                       onclick="game.get(${v.gameId})"><i class="fas fa-edit"></i></a>
                            <a href="javascripts:;"
                                        onclick="game.deleted(${v.gameId}, '${v.gameName}')"><i class="fas fa-trash"></i></a>`
                }
                else {
                    action = `<a href="javascripts:;"
                                       onclick="game.get(${v.gameId})"><i class="fas fa-edit"></i></a>
                            <a href="javascripts:;"
                                        onclick="game.deleted(${v.gameId}, '${v.gameName}')"><i class="fas fa-trash"></i></a>`
                }
                $('#gameTable').append(
                    `<tr>
                        <td>${v.gameId}</td>
                        <td>${v.gameName}</td>
                        <td><img src="/images/${v.pathImage}" alt="Error" /></td>
                        <td>${v.brandId}</td>
                        <td>${v.createDate}</td>
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
game.openModal = function () {
    $('#gameName').val('');
    $('#addEditgameModal').modal('show');
    document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
}
game.get = function (id) {
    $.ajax({
        url: `/game/get/${id}`,
        method: "get",
        dataType: "json",
        success: function (response) {
            console.log(response.data);
            $('#GameName').val(response.data.gameName);
            $('#GameId').val(response.data.gameId);
            $('#Categorys').val(response.data.categorys.toString());

            $('#BrandId').val(response.data.brandId);
            $('#Description').val(response.data.desciption);
            $('#addEditgameModal').modal('show');
            document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
        }
    });
}
game.save = function () {
    var saveObj = {};
    saveObj.images = "";
    var tam = $('#Images').val();
    debugger;
    $.ajax({
        url: '/game/saveImg',
        method: 'POST',
        data: tam,
        success: function (string) {
                saveObj.images = string;
                alert('success');
        }
    });
    if ($('#GameId').val() != undefined) {
        saveObj.gameId = parseInt($('#GameId').val());
    }
    else {
        saveObj.gameId = 0;
    }
    saveObj.gameName = $('#GameName').val();
    saveObj.categorys = $('#CategoryId').val().toString();
    saveObj.brandId = $('#BrandId').val();
    saveObj.description = $('#Description').val();
    saveObj.userId = "116b7110-897e-4a9d-abe8-5744b95a915b";
    debugger;
    $.ajax({
        url: '/game/save',
        method: 'POST',
        data: saveObj,
        success: function (response) {
            console.log(response);
            bootbox.alert(response.data.message);
            if (response.data.gameId > 0) {
                alert('success');
            }
        }
    });
};
$(document).ready(function () {
    $.ajax({
        url: `/brand/gets`,
        method: "get",
        data: "json",
        success: function (response) {
            $.each(response.result, function (i, v) {
                $('#BrandId').append(`
                <option value="${v.brandId}">${v.brandName}</option>`);
            })
        }
    });
    $.ajax({
        url: `/category/gets`,
        method: "get",
        data: "json",
        success: function (response) {
            console.log(response);
            $.each(response.result, function (i, v) {
                $('#CategoryId').append(`
                <option value="${v.categoryId}">${v.categoryName}</option>`);
            })
        }
    });
});

window.preview = function (input) {
    $('#previewImg').empty();
    if (input.files && input.files[0]) {

        $(input.files).each(function (i, value) {
            var reader = new FileReader();
            reader.readAsDataURL(this);
            reader.onload = function (e) {
                if (e != null) {
                    $("#previewImg").append("<div class='row' id='p" + i + "' style='margin:10px;'><img style='width: 100px' class='thumb'  src='" + e.target.result + "'><div><i class='fas fa-times-circle' onclick='xoa(" + i + ");'></i></div></div>");
                }
            }
        });
    }
}
function xoa(i) { $(`#p${i}`).remove(); }


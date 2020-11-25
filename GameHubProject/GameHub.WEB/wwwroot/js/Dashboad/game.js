$(document).ready(function () {
    $('.js-example-basic-multiple').select2();
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
                    action = `
                            <a href="javascripts:;"
                                        onclick="game.deleted(${v.gameId}, '${v.gameName}')"><i class="fas fa-trash"></i></a>`
                }
                $('#gameTable').append(
                    `<tr>
                        <td>${v.gameId}</td>
                        <td>${v.gameName}</td>
                        <td>${v.images}</td>
                        <td>${v.categorys}</td>
                        <td>${v.brandId}</td>
                        <td>${v.createDate}</td>
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
            $('#gameName').val(response.result.gameName);
            document.getElementById('gameId').value = response.result.gameId;
            $('#addEditgameModal').modal('show');
            document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
        }
    });

}
game.save = function () {
    if ($('#frmAddEditgame').valid()) {
        var saveObj = {};
        saveObj.gameId = parseInt($('#gameId').val());
        saveObj.gameName = $('#gameName').val();
        saveObj.images = $('#images').val();
        saveObj.categorys = $('#categorys').val();
        saveObj.brandId = $('#brandId').val();
        saveObj.description = $('#description').val();
        $.ajax({
            url: '/game/save',
            method: 'POST',
            dataType: 'JSON',
            contentType: 'application/json',
            data: JSON.stringify(saveObj),
            success: function (response) {
                console.log(response);
                bootbox.alert(response.data.message);
                if (response.data.gameId > 0) {
                    $('#addEditgameModal').modal('hide');
                    game.drawTable();
                }
            }
        });
    }
}

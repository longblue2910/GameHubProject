var CategoryId = parseInt(document.getElementById('gameid1').value);
var GameId = parseInt(document.getElementById('Gameid').value);
var UserId = document.getElementById('UserId').value;
var GetGameByCategory = function (id) {
    $.ajax({
        url: `/game/getbycategory/${id}`,
        method: 'GET',
        dataType: 'JSON',
        success: function (response) {
            var dem = 0;
            $.each(response.result, function (i, v) {
                dem++;
                console.log(v);
                if (dem > response.result.length - 3) {
                    $('.recent-posts').append(`
                            <div class="recent-posts-info">
                                <div class="posts-left sngl-img">
                                    <a href="/Home/Details/${v.gameId}"> <img style="height:120px;width:155px;" src="/images/${v.pathImage}" class="img-responsive zoom-img" alt="" /> </a>
                                </div>
                                <div class="posts-right">
                                     <h4><a href="/Home/Details/${v.gameId}">${v.gameName}</a></h4>
                                    <a href="/Home/Details/${v.gameId}" class="btn btn-primary hvr-rectangle-in">Read More</a>
                                </div>
                                <div class="clearfix"> </div>
                            </div>
                                `);
                }

            })
        }
    });
};
$("#Post").click(function () {
    var saveObj = {};
    saveObj.text = $('#text').val();
    saveObj.gameId = parseInt($('#Gameid').val());
    saveObj.userId = $('#UserId').val();
    debugger;
    $.ajax({
        url: '/Post/save',
        method: 'POST',
        data: saveObj,
        success: function (response) {
            console.log(response);
            bootbox.alert(response.data.message);
        }
    });
});
var GetComment = function (id) {
    $.ajax({
        url: `/Post/Gets/${id}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            console.log(response);
            $.each(response.result, function (i, v) {
                $("#add").append(`
                            <div class="media response-info">
                                <div class="media-left response-text-left">
                                        <a href="#">
                                            <img class="media-object" src="/template/images/icon1.png" alt="error" />
                                        </a>
                                        <h5><a href="#">Admin</a></h5>
                                    </div>
                                        <div class="media-body response-text-right">
                                            <p>
                                                ${v.text}
                                            </p>
                                            <ul>
                                                <li>MARCH 21, 2013</li>
                                                <li><a onclick="Reply()">Reply</a></li>
                                            </ul>
                                        </div>
                                        <div class="coment-form" id="repCmt"></div>
                                        <div class="clearfix"> </div>
                            </div>
                            `);
            });
        }
    });
}
var vote = 0;
$(document).ready(function () {
    GetGameByCategory(CategoryId);
    GetComment(GameId);
    checkRate(GameId, UserId);
});
function onmove(id) {
    if (id >= 1) {
        for (let i = 1; i <= id; i++) {
            document.getElementById(i).style.color = "orange";
        }
        for (let i = id + 1; i <= 5; i++) {
            document.getElementById(i).style.color = "black";
        }
    }
    vote = id;
}
function click(id) {
    var Obj = {};
    Obj.userId = $('#UserId').val();
    Obj.gameId = GameId;
    Obj.vote = parseInt(id);
    $.ajax({
        url: '/Rate/saveVote',
        method: 'POST',
        data: Obj,
        success: function () {
            alert("Success Rate! thanks");
            $("#addcheck").empty();
            $("#addcheck").append(`
                        <button class="btn btn-success" onclick="changeRate()">Checked</button>
                    `);
        }
    });
}
var checkRate = function (GameId, UserId) {
    $.ajax({
        url: `/Post/CheckVote/${GameId}/${UserId}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            console.log(response.result);
            $("#addcheck").empty();
            if (response.result.check = 0) {
                $("#addcheck").append(`
                        <span id="1" onmousemove="onmove(1)" onclick="click(1)" class="fa fa-star checked"></span>
                        <span id="2" onmousemove="onmove(2)" onclick="click(2)" class="fa fa-star checked"></span>
                        <span id="3" onmousemove="onmove(3)" onclick="click(3)" class="fa fa-star"></span>
                        <span id="4" onmousemove="onmove(4)" onclick="click(4)" class="fa fa-star"></span>
                        <span id="5" onmousemove="onmove(5)" onclick="click(5)" class="fa fa-star"></span>
                    `);
            }
            else {
                $("#addcheck").append(`
                        <button class="btn btn-success" onclick="changeRate()">Checked</button>
                    `);
            }
        }
    });
}
var changeRate = function () {
    $("#addcheck").empty();
    $("#addcheck").append(`
                        <span id="1" onmousemove="onmove(1)" onclick="click(1)" class="fa fa-star checked"></span>
                        <span id="2" onmousemove="onmove(2)" onclick="click(2)" class="fa fa-star checked"></span>
                        <span id="3" onmousemove="onmove(3)" onclick="click(3)" class="fa fa-star"></span>
                        <span id="4" onmousemove="onmove(4)" onclick="click(4)" class="fa fa-star"></span>
                        <span id="5" onmousemove="onmove(5)" onclick="click(5)" class="fa fa-star"></span>
                    `);
};
var Back = function () {
    $('#formRep').show();
    $('#repCmt').remove();
}
var Reply = function () {

    $('#repCmt').empty();
    $('#formRep').hide();
    $('#repCmt').append(
        `
                    </hr>
                    <h4>Phản hồi</h4>
                    <form>
                        <input type="text" value="Name" required="">
                        <input type="text" value="Subject " required="">
                        <input type="text" value="Email*" required="">
                        <textarea id="text" placeholder="Bình luận..."></textarea>
                        <input type="submit" value="Phản hồi" id="Post">
                        <a style="color: #838383;font-size: 14px; font-weight: 600;" onclick="Back()">Hủy</a>
                    </form>
                `
    )
}
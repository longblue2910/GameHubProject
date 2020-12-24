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
                                <div class="clearfix"></div>
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
    saveObj.commentId = $('#EditComment').val();
    saveObj.gameId = parseInt($('#Gameid').val());
    saveObj.userId = $('#UserId').val();
    debugger;
    $.ajax({
        url: '/Post/save',
        method: 'POST',
        data: saveObj,
        success: function (response) {
            bootbox.alert(response.data.message);
            $('#EditComment').val(0);
            GetComment(GameId);
        }
    });
});
var GetComment = function (id) {
    $.ajax({
        url: `/Post/Gets/${id}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            $("#add").empty();
            $.each(response.result, function (i, v) {
                var Edited = "";
                if (v.statusName == "Edited") {
                    Edited = 'Đã chỉnh sửa';
                }
                var Edit = "";
                var Delete = "";
                if (v.userId == UserId) {
                    Edit = `<a onclick="Edit(${v.commentId})" style="color: #a0a0a0; font-weight: 700; font-size:13px; text-rendering:auto;">Sửa</a>`;
                    Delete = `<a herf='#' onclick="DeleteComment(${v.commentId})">Delete</a>`;
                }
                var Time = "";
                var day = new Date();
                var month = v.time.substring(5, 7) - 1;
                var year = v.time.substring(0, 4);
                var dayy = v.time.substring(8, 10);
                var hours = v.time.substring(11, 13);
                var minute = v.time.substring(14, 16);
                var second = v.time.substring(17, 19);
                var day2 = new Date(year, month, dayy, hours, minute, second);
                if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 / 52 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 / 52) - 1} Năm Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7) - 1} Tuần Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24) - 1} Ngày Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60) - 1} Giờ Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60) - 1} Phút Trước`;
                }
                $("#add").append(`
                          <div class="media response-info">
                                    <div class="media-left response-text-left">
                                        <a href="#">
                                            <img class="media-object" src="/template/images/icon1.png" alt="error" />
                                        </a>
                                    </div>
                                    <div class="media-body response-text-right">
                                            <div style="display:flex">
									          <h5><a style="color: #212121; font-size: 14px; font-style: normal; font-weight: 700;" href="#">${v.userName}</a></h5>
									          &ensp;
									         <h5><a style="color: #a0a0a0; font-size: 12px;">${Time}</a></h5>
                                             &ensp;
                                             <h5><a style="color: #a0a0a0; font-size: 12px;">${Edited}</a></h5>
								    </div>
                                            <p>
                                                ${v.text}
                                            </p>
							      	<div style="display:flex">
									       <h5><a style="color: #a0a0a0; font-weight: 700; font-size: 13px; text-rendering: auto;" onclick="Reply(${v.commentId})">Trả lời</a></h5>
									       &ensp;
									       <h5>${Edit}</h5>
								    </div>
                                    </div>
                                        <div class="coment-form" id="showRep${v.commentId}"></div>
                                        <div class="coment-form" id="add${v.commentId}"></div>
                                        <div class="coment-form" id="repCmt${v.commentId}"></div>
                                        <div class="clearfix">
                                    </div>
                           </div>`
                );
                GetRep(v.commentId);
            });
        }
    });
}
var GetRep = function (id) {
    $.ajax({
        url: `/Reply/Gets/${id}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            $(`#showRep${id}`).empty();
            $.each(response.result, function (i, v) {
                var Edited = "";
                if (v.statusName == "Edited") {
                    Edited = 'Đã chỉnh sửa';
                }
                var Edit = "";
                var Delete = "";
                if (v.userId == UserId) {
                    Edit = `<a onclick="Edit(${v.repId})" style="color: #a0a0a0; font-weight: 700; font-size:13px; text-rendering:auto;">Sửa</a>`;
                    Delete = `<a herf='#' onclick="DeleteComment(${v.repId})">Delete</a>`;
                }
                var Time = "";
                var day = new Date();
                var month = v.time.substring(5, 7) - 1;
                var year = v.time.substring(0, 4);
                var dayy = v.time.substring(8, 10);
                var hours = v.time.substring(11, 13);
                var minute = v.time.substring(14, 16);
                var second = v.time.substring(17, 19);
                var day2 = new Date(year, month, dayy, hours, minute, second);
                if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 / 52 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 / 52) - 1} Năm Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7) - 1} Tuần Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24) - 1} Ngày Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60) - 1} Giờ Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60) - 1} Phút Trước`;
                }
                $(`#showRep${id}`).append(`
                            <div class="media response-info" style="margin-left:10%">
                                <div class="media-left response-text-left">
                                        <a href="#">
                                            <img class="media-object" src="/template/images/icon1.png" alt="error" />
                                        </a>
                                    </div>
                                        <div class="media-body response-text-right">
                                            <div style="display:flex">
									          <h5><a style="color: #212121; font-size: 14px; font-style: normal; font-weight: 700;" href="#">${v.userName}</a></h5>
									          &ensp;
									         <h5><a style="color: #a0a0a0; font-size: 12px;">${Time}</a></h5>
									          &ensp;
                                          
								    </div>
                                            <p>
                                                ${v.text}
                                            </p>
							      	<div style="display:flex">
									       &ensp;
									       <h5>${Edit}</h5>
								    </div>
                                        <div class="coment-form" id="showRep1${v.repId}"></div>
                                        <div class="coment-form" id="addRep${v.repId}"></div>
                                        <div class="coment-form" id="rep1Cmt${v.repId}"></div>
                                        <div class="clearfix"> </div>
                            </div>`);
            });
        }
    })
}
function Edit(commentId) {
    $.ajax({
        url: `/Post/Get/${commentId}`,
        method: 'Get',
        data: commentId,
        success: function (response) {
            $('#EditComment').val(response.result.commentId);
            $("#text").val(response.result.text);
            GetComment(GameId);
        }
    })
}
var CommentIdTam = 0;
var EditRepId = 0;
function EditRep(RepId) {
    $.ajax({
        url: `/Reply/Get/${RepId}`,
        method: 'Get',
        data: RepId,
        success: function (response) {
            CommentIdTam = (response.result.commentId);
            Reply(CommentIdTam);
            EditRepId = response.result.repId;
            $("#textRep").val(response.result.text);
        }
    });
}
function DeleteComment(commentId) {
    $.ajax({
        url: `/Post/delete/${commentId}`,
        method: 'Post',
        data: commentId,
        success: function (response) {
            alert(response.data.message);
            GetComment(GameId);
        }
    })
}
function DeleteRep(RepId) {
    $.ajax({
        url: `/Reply/delete/${RepId}`,
        method: 'Post',
        data: RepId,
        success: function (response) {
            alert(response.data.message);
            GetComment(GameId);
        }
    })
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
                        <span onclick="changeRate()"><i class="fas fa-check"></i></span>
                    `);
        }
    });
    $.ajax({
        url: `/Game/getAgame/${GameId}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            console.log(response);
            $("#addcheck").append(`
                        <strong>${response.avgRate} / 5</strong>
                        <span>( <strong>${response.countRate}</strong> bình chọn )<span>
                    `);
        }
    });
}
var checkRate = function (GameId, UserId) {
    $.ajax({
        url: `/Game/getAgame/${GameId}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            console.log(response);
                $("#addcheck").append(`
                        <strong>${response.avgRate} / 5</strong>
                        <span>( <strong>${response.countRate}</strong> bình chọn )<span>
                    `);
        }
    });
    $.ajax({
        url: `/Post/CheckVote/${GameId}/${UserId}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
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
                        <span onclick="changeRate()"><i class="fas fa-check"></i></span>
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
var Back = function (id) {
    $('#formRep').show();
    $(`#repCmt${id}`).remove();
    $(`#add${id}`).append(`<div class="coment-form" id="repCmt${id}"></div>`);
}
var Reply = function (id) {
    $(`#repCmt${id}`).empty();
    $('#formRep').hide();
    $(`#repCmt${id}`).append(
        `
                    </hr>
                    <h4>Phản hồi</h4>
                    <form>
                        <textarea id="textRep" placeholder="Bình luận..."></textarea>
                        <input type="submit" value="Phản hồi" onclick="PostReply(${id})">
                        <a style="color: #838383;font-size: 14px; font-weight: 600;" onclick="Back(${id})">Hủy</a>
                    </form>
        `)
}
var PostReply = function (id) {
    var saveObj = {};
    saveObj.text = $('#textRep').val();
    saveObj.commentId = id;
    saveObj.repId = EditRepId;
    saveObj.gameId = parseInt($('#Gameid').val());
    saveObj.userId = $('#UserId').val();
    debugger;
    $.ajax({
        url: '/Reply/save',
        method: 'POST',
        data: saveObj,
        success: function (response) {
            alert(response.data.message);
            GetComment(GameId);
            $('#RepId').val(0);
        }
    });
}
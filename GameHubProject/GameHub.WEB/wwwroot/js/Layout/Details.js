$(document).ready(function () {
    debugger;
    $.ajax({
        url: `/game/getbycategory/${id}`,
        method: 'POST',
        dataType: 'JSON',
        success: function (response) {
            console.log(response);
            $.each(response, function (i, v) {
                $('.recent-posts').append(`
                    <div class="recent-posts-info">
                        <div class="posts-left sngl-img">
                            <a href="#"> <img src="images/" class="img-responsive zoom-img" alt="" /> </a>
                        </div>
                        <div class="posts-right">
                            <label>March 5, 2015</label>
                            <h5><a href="single.html">Finibus Bonorum</a></h5>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing incididunt.</p>
                            <a href="single.html" class="btn btn-primary hvr-rectangle-in">Read More</a>
                        </div>
                        <div class="clearfix"> </div>
                    </div>
                `);
            })
        }
    });
    
});
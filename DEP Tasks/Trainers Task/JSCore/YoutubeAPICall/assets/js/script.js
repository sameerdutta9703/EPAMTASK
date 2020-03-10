function tplawesome(e, t) {
    res = e;
    for (var n = 0; n < t.length; n++) {
        res = res.replace(/\{\{(.*?)\}\}/g, function (e, r) {
            return t[n][r];
        })
    }
    return res;
}


$(function () {
    $("form").on("submit", function (e) {
        e.preventDefault();
        var request = gapi.client.youtube.search.list({
            part: "snippet",
            type: "video",
            q: encodeURIComponent($("#search").val()).replace(/%20/g, "+"),
            maxResults: 8,
            order: "viewCount",
        });
        request.execute(function (response) {
            var res = response.result;
            $("#res").html("");
            $.each(res.items, function (index, item) {
                $.get("./item.html", function (data) {
                    $("#results").append(tplawesome(data, [{ "title": item.snippet.title, "videoid": item.id.videoId }]));
                });
            });
            resetVideoHeight();
        });
    });
    $(window).on("resize", resetVideoHeight);
});

function resetVideoHeight() {
    $(".video ").css("height", $("#res").width() * 9 / 16);
}

function init() {
    gapi.client.setApiKey("AIzaSyCTmn2VL1-pni8B6M03bQHVvPV4zp0zUD4");
    gapi.client.load('youtube', 'v3', function () {
    });
}
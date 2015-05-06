// Namespaces
var Fifa = Fifa || {};
Fifa.Leaderboard = Fifa.Leaderboard || {};

$(document).ready(function() {
    $.get("/leaderboard", "", function (data) {
        var template = $('#leaderboard-table').html();
        var hbTemplate = Handlebars.compile(template);

        $(document.body).append(hbTemplate(data));
    }, "json");
});

$('#add-game').click(function() {

});


//Fifa.Leaderboard.loadAndBindLeaderboard = function () {
//    var self = this;

//    $.get("/leaderboard", "", function (data) {
//        var template = $('#leaderboard-table').html();
//        var hbTemplate = Handlebars.compile(template);

//        $(document.body).append(hbTemplate(data));
//    }, "json");
//};
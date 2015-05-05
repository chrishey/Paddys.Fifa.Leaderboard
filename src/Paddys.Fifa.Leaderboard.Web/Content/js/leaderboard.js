// Namespaces
var Fifa = Fifa || {};
Fifa.Leaderboard = Fifa.Leaderboard || {};


Fifa.Leaderboard.loadAndBindLeaderboard = function () {
    var self = this;

    $.get("/leaderboard", "", function (data) {
        var template = $('#leaderboard-table').html();
        var hbTemplate = Handlebars.compile(template);

        $(document.body).append(hbTemplate(data));
    }, "json");
};
// Namespaces
var Fifa = Fifa || {};
Fifa.Leaderboard = Fifa.Leaderboard || {};

$(document).ready(function() {
    $.get("/leaderboard", "", function (data) {
        var template = $('#leaderboard-table').html();
        var hbTemplate = Handlebars.compile(template);

        $(document.body).append(hbTemplate(data));
    }, "json");

    $('#add-game').click(function () {
    	$('#add-game-form').dialog({
    		width: 400,
    		modal: true,
    		close: function (event, ui) {
    			$('#add-game-form').remove();
    		}
    	});
    });

	$.get("/players", "", function(data) {
		var template = $('#players-list').html();
		var playerstemplate = Handlebars.compile(template);

		$(document.body).append(playerstemplate(data));
	}, "json");
});
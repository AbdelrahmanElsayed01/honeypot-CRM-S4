$(document).ready(function() {
	$('.toggle-btn').click(function() {
		$(this).toggleClass('active').siblings().removeClass('active');
	});
});
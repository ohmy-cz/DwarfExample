// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    var tablesCount = parseInt($('.jsTablesCount').val());
    var availableTables = tablesCount;
    $(document)
        .on('change', '.guestsCount', function (e) {
            var guestsCount = parseInt($(this).val());
            availableTables = tablesCount - Math.ceil(guestsCount / 2);
            $('.availableTables').text(availableTables);
            if (availableTables === 0) {
                $('.bookingTimes a').addClass('disabled');
            } else {
                $('.bookingTimes a').removeClass('disabled');
            }
        })
        .on('click', '.bookingTimes a', function (e) {
            e.preventDefault();
            if ($(this).hasClass('disabled')) {
                alert('You can\'t book this time.');
                return;
            } else {
                $(this).toggleClass('btn-outline-secondary btn-outline-success');
            }
        });
});

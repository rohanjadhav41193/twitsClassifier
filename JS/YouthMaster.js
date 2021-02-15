//jQuery(document).ready(function () {
//    jQuery('.tabs .tab-links a').on('click', function (e) {
//        var currentAttrValue = jQuery(this).attr('href');

//        // Show/Hide Tabs
//        jQuery('.tabs ' + currentAttrValue).show().siblings().hide();

//        // Change/remove current tab to active
//        jQuery(this).parent('li').addClass('active').siblings().removeClass('active');
//        jQuery('.tabs ' + currentAttrValue).fadeIn(400).siblings().hide();
//        e.preventDefault();
//    });
//});

$('.tabs').tabs({
    select: function (event, ui) {
        var url = $.data(ui.tab, 'load.tabs');
        location.href = url; // follow url
        return false; // to disable default handling
    }
});
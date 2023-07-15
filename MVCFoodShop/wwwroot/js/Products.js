window.onload = function () {
    GetProductList('');
    $("#all").addClass('active');
};

function GetProductList(element, category) {
    $('.filters_menu li').removeClass('active');
    $(element).addClass('active');
    $.ajax({
        url: "/Product/List/",
        type: "get",
        data: { categoryName: category },
        success: function (response) {
            $("#productList").html(response);
        }

    });
}
function GetMenuProducts(id) {
    $.ajax({
        url: "/Product/MenuProducts" + id,
        type: "get",
        success: function (response) {
            $("#menuProducts").html(response);
        }

    });
}


//$(window).on('load', function () {
//    $('.filters_menu li').click(function () {
        
//        $(this).addClass('active');

//        //var data = $(this).attr('data-filter');
//        //$grid.isotope({
//        //    filter: data
//        //})
//    });

//    //var $grid = $(".grid").isotope({
//    //    itemSelector: ".all",
//    //    percentPosition: false,
//    //    masonry: {
//    //        columnWidth: ".all"
//    //    }
//    //})
//});
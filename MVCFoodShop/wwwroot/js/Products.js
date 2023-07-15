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

//function AddShoppingCart(id) {     
//    $.ajax({
//        url: "/Product/FillShoppingCart/" + id,
//        type: "get",
//        success: function (response) {
//            $("#shoppingcart").html(response);
//        }

//    });
//}

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
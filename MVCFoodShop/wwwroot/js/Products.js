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

function AddToShoppingCart(productOrMenuID, typeName, count) {
    var elementAmountID = "elementAmount" + count;
    var elementAmount = document.getElementById(elementAmountID).value;

    let shoppingCartVM = {
        ProductOrMenuID: productOrMenuID,
        TypeName: typeName,
        ElementAmount: elementAmount
    }
    $.ajax({
        url: "/Product/FillShoppingCart",
        type: "post",
        data: shoppingCartVM,
        success: function (response) {
            $("#shoppingcart").html(response);
        }

    });
}


function AddMenuToShoppingCart(menuID,count2) {
    var elementAmount1 = document.getElementById('menuOrderCount' + count2).value;
    var menuType = document.getElementById('menuType' + count2).value;
    var menuCartElements = document.getElementsByName('menuCartElement' + count2);
    var selectedValues = [];
    for (var i = 0; i < menuCartElements.length; i++) {
        var selectedValue = menuCartElements[i].value;
        selectedValues.push(selectedValue);
    }

    let shoppingCartVM1 = {
        MenuID: menuID,
        TypeName: 'Menu',
        ElementAmount: elementAmount1,
        MenuCartsProductIDs: selectedValues, 
        MenuType: menuType 
    };

    $.ajax({
        url: "/Product/FillShoppingCart",
        type: "post",
        data: shoppingCartVM1,
        success: function (response) {
            $("#shoppingcart").html(response);
            $(".modal.fade.show")
                .removeClass("show")
                .removeAttr("aria-modal")
                .attr("aria-hidden", "true")
                .css("display", "none");
            $(".modal-backdrop.fade.show").remove();
            $("body").removeAttr("class").removeAttr("style");
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



//window.onload = function () {
//    GetProductList('');
//    $("#all").addClass('active');
//};



//function GetProductList(element, category) {
//    $('.filters_menu li').removeClass('active');
//    $(element).addClass('active');
//    $.ajax({
//        url: "/Product/List/",
//        type: "get",
//        data: { categoryName: category },
//        success: function (response) {
//            $("#productList").html(response);
//        }

//    });
//}
function RemoveProduct(id,type) {

    let removeProductVM = {
        Id: id,
        Type: type
    }
    $.ajax({
        type: 'POST',
        url: '/Product/RemoveProduct',
        data: removeProductVM,
        success: function (response) {
            if (response == "Ok") {
                GetProductList('');
                $("#all").addClass('active');
            }
        },
    });

}









function UpdateProduct(productID ,count) {
    /*var updateProductCoverImage = document.getElementById('updateProductCoverImage' + count).value;*/
    var updateProductName = document.getElementById('updateProductName' + count).value;
    var updateProductPrice = document.getElementById('updateProductPrice' + count).value;
    var updateCategoryID = document.getElementById('updateCategoryID' + count).value;
    var updateProductDeclaration = document.getElementById('updateProductDeclaration' + count).value;



    let updateProductVM = {
        ProductID: productID,
        ProductName: updateProductName,
        ProductPrice: updateProductPrice,
       /* ProductCoverImage: updateProductCoverImage,*/
        CategoryID: updateCategoryID,
        ProductDeclaration: updateProductDeclaration,

    }
    $.ajax({
        type: 'POST',
        url: '/Product/UpdateProduct',
        data: updateProductVM,
        success: function (response) {
            if (response == "Ok") {


                $(".modal.fade.show")
                    .removeClass("show")
                    .removeAttr("aria-modal")
                    .attr("aria-hidden", "true")
                    .css("display", "none");
                $(".modal-backdrop.fade.show").remove();
                $("body").removeAttr("class").removeAttr("style");

                GetProductList('');
                $("#all").addClass('active');
            }
        },
    });
}


function UpdateMenu(menuID, count) {
   /* var updateMenuCoverImage = document.getElementById('updateMenuCoverImage'+count).value;*/
    var updateMenuName = document.getElementById('updateMenuName'+count).value;
    var updateMenuPrice = document.getElementById('updateMenuPrice'+count).value;
    var updateMenuFoodCount = document.getElementById('updateMenuFoodCount'+count).value;
    var updateMenuBeverageCount = document.getElementById('updateMenuBeverageCount'+count).value;
    var updateMenuSauceCount = document.getElementById('updateMenuSauceCount'+count).value;
    var updateMenuDeclaration = document.getElementById('updateMenuDeclaration'+count).value;
    var updateSelectedProductsSTR = 'input[name="updateSelectedProducts' + count + '"]:checked';
    var updateSelectedProducts = $(updateSelectedProductsSTR).map(function () {
        return $(this).val();
    }).get()

    let updateMenuVM = {
        ID : menuID,
       /* MenuCoverImage: updateMenuCoverImage,*/
        MenuName: updateMenuName,
        UpdatedMenuPrice: updateMenuPrice,
        FoodCount: updateMenuFoodCount,
        BeverageCount: updateMenuBeverageCount,
        SauceCount: updateMenuSauceCount,
        MenuDeclaration: updateMenuDeclaration,
        SelectedProducts: updateSelectedProducts
    }
    $.ajax({
        type: 'POST',
        url: '/Product/UpdateMenu', 
        data: updateMenuVM,
        success: function (response) {
            if (response == "Ok") {

            
            $(".modal.fade.show")
                .removeClass("show")
                .removeAttr("aria-modal")
                .attr("aria-hidden", "true")
                .css("display", "none");
            $(".modal-backdrop.fade.show").remove();
            $("body").removeAttr("class").removeAttr("style");

            GetProductList('');
                $("#all").addClass('active');
            }
        },
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

            var shopppingCartProductCount = $("#shopppingCartProductCount");
            var currentValue = parseInt(shopppingCartProductCount.text());
            shopppingCartProductCount.text(currentValue + 1);
            //var updatedProductCount = currentValue + 1;
            //$.ajax({
            //    url: "/Base/SaveProductCount",
            //    type: "post",
            //    data: { productCount: updatedProductCount },

            //});
        }
    });
}


function AddMenuToShoppingCart(menuID, count2) {
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

    var menuButton = document.getElementById('menu');

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
            /*$("#ourProductsTitle").click();*/


            var shopppingCartProductCount = $("#shopppingCartProductCount");
            var currentValue = parseInt(shopppingCartProductCount.text());
            shopppingCartProductCount.text(currentValue + 1);
            //var updatedProductCount = currentValue + 1;
            //$.ajax({
            //    url: "/Base/SaveProductCount",
            //    type: "post",
            //    data: { productCount: updatedProductCount },
            //});
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



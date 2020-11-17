$().ready(function () {
    var list = listProduct(10);
    console.log(filterProductById_ES6(list, 5));
    console.log(filterProductByQuality_ES6(list));
    console.log(filterProductBySaleDate_ES6(list));
    console.log(totalProduct_ES6(list));
    console.log(isHaveProductInCategory_ES6(list, 1));
    console.log(filterProductBySaleDate2_ES6(list));
});
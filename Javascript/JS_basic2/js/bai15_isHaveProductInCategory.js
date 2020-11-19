function isHaveProductInCategory(listProduct, categoryId) {
    try {
        var result = listProduct.some(function (item) {
            return item.categoryId == categoryId;
        });
        return result;
    } catch (err) {
        alert(err.message);
    }
}


const isHaveProductInCategory_ES6 = (listProduct, categoryId) => {
    try {
        let result = listProduct.find(item => item.categoryId == categoryId);
        if(result) return true;
        return false;
    } catch (err) {
        alert(err.message);
    }
}
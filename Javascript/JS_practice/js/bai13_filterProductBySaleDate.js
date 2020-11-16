function filterProductBySaleDate(listProduct) {
    try {
        var date = new Date().toLocaleDateString();
        let pr = listProduct.filter(function (item) {
            return item.saleDate >= date && item.isDelete == false;
        });
        return pr;
    }
    catch (err) {
        alert(err.message);
    }
}

const filterProductBySaleDate_ES6 = (listProduct) => {
    try {
        var date = new Date().toLocaleDateString();
        let pr = listProduct.filter(item => {
            return item.saleDate >= date && item.isDelete == false;
        });
        return pr;
    }
    catch (err) {
        alert(err.message);
    }
}
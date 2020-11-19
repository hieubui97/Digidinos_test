function filterProductBySaleDate(listProduct) {
    try {
        var date = new Date().toLocaleDateString();
        var result = listProduct.filter(function (item) {
            return item.saleDate >= date && item.isDelete == false;
        });
        return result;
    }
    catch (err) {
        alert(err.message);
    }
}

const filterProductBySaleDate_ES6 = (listProduct) => {
    try {
        let result = [];
        let date = new Date().toLocaleDateString();
        listProduct.forEach(item => {
            if (item.saleDate>=date && item.isDelete ==false){
                result.push(item);
            }
        });
        return result;
    }
    catch (err) {
        alert(err.message);
    }
}
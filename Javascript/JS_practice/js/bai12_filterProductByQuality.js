function filterProductByQuality(listProduct) {
    try {
        var result = listProduct.filter(function (item) {
            return item.quality > 0 && item.isDelete == false;
        });
        return result;
    } catch (err) {
        alert(err.message);
    }
}

const filterProductByQuality_ES6 = (listProduct) => {
    try {
        let result = [];
        listProduct.forEach(item => {
            if (item.quality > 0 && item.isDelete == false) {
                result.push(item);
            }
        });
        return result;
    } catch (err) {
        alert(err.message);
    }
}
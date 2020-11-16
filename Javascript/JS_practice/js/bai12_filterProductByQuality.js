function filterProductByQuality(listProduct) {
    try {
        let pr = listProduct.filter(function (item) {
            return item.quality > 0 && item.isDelete == false;
        });
        return pr;
    } catch (err) {
        alert(err.message);
    }
}

const filterProductByQuality_ES6 = (listProduct) => {
    try {
        let pr = listProduct.filter((item) => {
            return item.quality > 0 && item.isDelete == false;
        });
        return pr;
    } catch (err) {
        alert(err.message);
    }
}
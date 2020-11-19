function filterProductBySaleDate2(listProduct) {
    try {
        var result = [];
        var date = new Date();

        listProduct.forEach(function (item) {
            if (item.quality > 15 && item.saleDate >= date.toLocaleDateString()) {
                var pr = [item.id, item.name];
                result.push(pr);
            }
        });
        return result;
    } catch (err) {
        alert(err.message);
    }
}


const filterProductBySaleDate2_ES6 = (listProduct) => {
    try {
        let date = new Date();
        let filterList = listProduct.filter(item => item.quality > 15 && item.saleDate >= date.toLocaleDateString());
        result = filterList.map(item=>[item.id, item.name]);
        return result;
    } catch (err) {
        alert(err.message);
    }
}

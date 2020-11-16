function filterProductBySaleDate2(listProduct) {
    try {
        let result = [];
        let date = new Date();

        listProduct.forEach(function (item) {
            if (item.quality > 0 && item.saleDate >= date.toLocaleDateString()) {
                let pr = [item.id, item.name];
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
        let result = [];
        let date = new Date();
        
        listProduct.forEach((item) => {
            if (item.quality > 0 && item.saleDate >= date.toLocaleDateString()) {
                let pr = [item.id, item.name ];
                result.push(pr);
            }
        });
        return result;
    } catch (err) {
        alert(err.message);
    }
}

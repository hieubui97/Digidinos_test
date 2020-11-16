function totalProduct(listProduct) {
    try {
        let total = listProduct.reduce(function (accumulator, currentValue) {
            return accumulator + currentValue.quality;
        }, 0);
        return total;
    }
    catch (err) {
        alert(err.message);
    }
}

const totalProduct_ES6 = (listProduct)=> {
    try {
        let total = 0;
        listProduct.forEach(item => {
            total += item.quality;
        });
        return total;
    }
    catch (err) {
        alert(err.message);
    }
}
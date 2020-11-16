function listProduct(count) {
    var list=[]; 
    try {
        // let i = 0;
        for (let i = 0; i < count; i++) {
            var pr = new Product(i, "Product" + i, i % 2 + 1, '11/16/2020', 10 + i, i % 2);
            list.push(pr);
        }
        console.log(list);
        return list;
    } catch (err) {
        alert(err.message);
    }
}
function listProduct(count) {
    var list=[]; 
    try {
        // let i = 0;
        for (let i = 0; i < count; i++) {
            var pr = new Product(i, "Product" + i, i % 2 + 1, new Date().toLocaleDateString(), 10 + i, i % 2);
            list.push(pr);
        }
        return list;
    } catch (err) {
        alert(err.message);
    }
}
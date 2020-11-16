function filterProductById(id, list) {
    try {
        let pr = list.filter(function (item) {
            return item.id == id;
        });
        return pr[0].name;
    } catch (err) {
        alert(err.message);
    }
}

// arrow function ES6
const filterProductById_ES6 = (id, list) => {
    try {
        let pr = list.filter((item) => {
            return item.id == id;
        });
        return pr[0].name;
    } catch (err) {
        alert(err.message);
    }
}
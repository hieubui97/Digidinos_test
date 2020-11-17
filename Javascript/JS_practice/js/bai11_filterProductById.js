function filterProductById(list, id) {
    try {
        var pr = list.filter(function (item) {
            return item.id == id;
        });
        return pr[0].name;
    } catch (err) {
        alert(err.message);
    }
}

// arrow function ES6
const filterProductById_ES6 = (list, id) => {
    try {
        let pr = list.find(item => item.id == id);
        return pr.name;
    } catch (err) {
        alert(err.message);
    }
}
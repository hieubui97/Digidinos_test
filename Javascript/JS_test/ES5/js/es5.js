"use strict";
$().ready(function () {
    // strim: loại bỏ khoảng trắng 2 đầu
    var str = "       Hello World!        ";
    console.log(str.trim());

    // isArray
    var fruits = ["Banana", "Orange", "Apple", "Mango"];

    console.log(Array.isArray(fruits));

    // forEach
    var txt = "";
    var numbers = [4, 9, 16, 25];
    numbers.forEach(function (item) {
        console.log(item);
    });

    // map()
    var numbers2 = numbers.map(function (item) {
        console.log(item * 2);
    });

    // Array.filter(): trả về mảng mới tm điều kiện
    console.log(numbers.filter(function (value) {
        return value > 9;
    }));

    // Array.reduce(): trừ các số trong mảng từ bên trái
    console.log(numbers.reduce(function (total, value) {
        return total + value;
    }))

    // Array.reduceRight(): trừ các số trong mảng bắt đầu từ bên phải
    console.log(numbers.reduceRight(function (total, value) {
        return total + value;
    }))

    // Array.every(): kiểm tra tất cả các ptu thoả mãn với điều kiện: true
    console.log(numbers.every(function (value) {
        return value > 9;
    }))

    // Array.some(): kiểm tra nếu bất kỳ ptu nào trong mảng thoả mãn: true
    console.log(numbers.some(function (value) {
        return value > 9;
    }))

    // indexOf: tìm chỉ số đầu
    var fruits = ["Apple", "Orange", "Apple", "Mango"];
    var a = fruits.indexOf("Apple");
    console.log(a)

    // lastIndexOf: tìm chỉ số cuối
    a = fruits.lastIndexOf("Apple");
    console.log(a);

    // JSON.parse: convert->obj
    var txt = '{"name":"John", "age":30, "city":"New York"}'
    var obj = JSON.parse(txt);
    console.log(obj);

    // JSON.stringfy: convert-> string: JSON
    var myJson = JSON.stringify(obj);
    console.log(myJson);

    // Thuộc tính getter and setter
    var person = {
        firstName: "Hieu",
        lastName: "Bui",
        language: "NO",
        get fullName() {
            return this.firstName + " " + this.lastName;
        },
        get lang() {
            return this.language;
        },
        set lang(value) {
            this.language = value;
        }
    };
    // Display data from the object using a getter:
    console.log(person.fullName);
    person.lang = "English";
    console.log(person.lang);

    // Change a Property:
    Object.defineProperty(person, "birthdate", {
        value: "1997",
        writable: true,
        enumerable: true,
        configurable: true
    });
    console.log(person.birthdate);

    Object.defineProperty(person, "name", {
        get: function () { return name },
        set: function (value) { name = value.toUpperCase() }
    });
    person.name = "abc";
    console.log(person.name);

    // charAt
    var str = "HELLO WORLD";
    console.log(str.charAt(0));            // returns H
    console.log(str[1]);

    // string nhiều dòng
    console.log("Hello \
Dolly!");
});
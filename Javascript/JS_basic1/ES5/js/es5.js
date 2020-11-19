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

    // map(): tạo 1 mảng mới với kết quả của việc gọi một hàm cho mọi phần tử của mảng, không thay đổi mảng ban đầu
    // map(): không thực thi hàm cho các phần tử mảng không có giá trị
    var numbers2 = numbers.map(Math.sqrt);
    console.log(numbers2);


    var persons = [
        { firstname: "Malcom", lastname: "Reynolds" },
        { firstname: "Kaylee", lastname: "Frye" },
        { firstname: "Jayne", lastname: "Cobb" }
    ];
    function getFullName(item) {
        var fullname = [item.firstname, item.lastname].join(" ");
        return fullname;
    }
    console.log(persons.map(getFullName));

    // Array.filter(): trả về mảng mới với các ptu tm điều kiện
    console.log(numbers.filter(function (value) {
        return value > 9;
    }));

    // Array.reduce(): thực thi 1 callback function được cung cấp cho mỗi giá trị của mảng từ trái sang phải, ko đổi giá trị mảng bd
    // Array.reduce(): bỏ qua những ptu không có giá trị
    // Array.reduce(callback,intialValue)
    // callback function nhận vào 4 tham số: accumulator, currentValue, currentIndex, arr
    // nếu initial value không được cung cấp: reduce sẽ thực thi callback bắt đầu từ index = 1: accumulator = arr[0], currentValue = arr[1]
    // nếu initial value được cung cấp: reduce sẽ thực thi callback từ index = 0: accumulator = initialValue, currentValue = arr[0]
    // giá trị của hàm được lưu trữ trong accumulator

    // không có initalValue
    var reduce = numbers.reduce(function (accumulator, currentValue) {
        return accumulator += currentValue;
    });
    console.log(reduce);
    // có initialValue
    reduce = numbers.reduce(function (accumulator, currentValue) {
        return accumulator += currentValue;
    }, 100);
    console.log(reduce);

    // Array.reduceRight(): reduce bắt đầu từ bên phải
    reduce = numbers.reduce(function (accumulator, currentValue) {
        return accumulator += currentValue;
    }, 1000);
    console.log(reduce);

    // Array.every(): kiểm tra tất cả các ptu thoả mãn với điều kiện
    // Kết quả trả về true/false nếu tm điều kiện khác filter trả về mảng mới gồm các ptu tm điều kiện
    console.log(numbers.every(function (value) {
        return value > 9;
    }));

    // Array.some(): kiểm tra nếu bất kỳ ptu nào trong mảng thoả mãn: true
    console.log(numbers.some(function (value) {
        return value > 9;
    }));

    // indexOf: tìm chỉ số đầu
    var fruits = ["Apple", "Orange", "Apple", "Mango"];
    var a = fruits.indexOf("Apple");
    console.log(a);

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
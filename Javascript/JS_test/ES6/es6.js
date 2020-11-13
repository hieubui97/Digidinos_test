$().ready(function () {
    // let: cho phép khai báo biến trong phạm vi 1  khối {}
    var x = 10; // Here x is 10
    console.log(x);
    {
        let x = 2;  // Here x is 2     
        console.log(x);
    }
    console.log(x); // Here x is 10


    // const: giống let nhưng k thể change value
    console.log(x);
    {
        const x = 2;  // Here x is 2     
        console.log(x);
    }
    console.log(x); // Here x is 10


    // Arrow function
    // ES5
    var f = function (x, y) {
        return x * y;
    }
    console.log(f(2, 4));
    // ES6
    const f2 = (x, y) => x * y; // sử dụng const vì biểu thức hàm luôn là 1 giá trị không đổi
    console.log(f2(5, 6));

    // class
    class Car {
        constructor(name, year) {
            this.name = name;
            this.year = year;
        }
    }

    myCar = new Car("Ford", 2014);
    console.log(myCar);

    // promise
    let myPromise = new Promise(function (myResolve, myReject) {
        let x = 1;
        if (x == 0) {
            setTimeout(function () {
                myResolve("Pormise !!");
            }, 3000);
        }
        else {
            setTimeout(function () {
                myReject("Reject !!");
            }, 3000);
        }
    });

    myPromise.then(
        function (value) {
            console.log(value);
        },
        function (error) {
            console.log(error);
        }
    );


    // Default  parameter
    function myFunction(x, y = 10) {
        // y is 10 if not passed or undefined
        return x + y;
    }
    console.log(myFunction(5)); // will return 15


    // Function rest parameter: cho phép 1 hàm coi 1 số lượng vô hạn tham số là 1 mảng
    function sum(...args) {
        let sum = 0;
        for (let arg of args) sum += arg;
        return sum;
    }

    let sumx = sum(4, 9, 16, 25, 29, 100, 66, 77);
    console.log(sumx);


    // Array find(): trả về ptu đầu tiên thoả mãn
    var numbers = [4, 9, 16, 25, 29];
    var first = numbers.find(function (value, index, array) {
        return value > 18;
    });
    console.log(first);

    // Array find(): trả về chỉ số của ptu đầu tiên thoả mãn
    var numbers = [4, 9, 16, 25, 29];
    var first = numbers.findIndex(function (value, index, array) {
        return value > 18;
    });
    console.log(first);


    // Number isInterger
    console.log(Number.isInteger(10));        // returns true
    console.log(Number.isInteger(10.5));    // returns false

    // isSafeInterger
    // Safe integers are all integers from - (253 - 1) to + (253 - 1).
    // This is safe: 9007199254740991. This is not safe: 9007199254740992.
    console.log(Number.isSafeInteger(121321656548));        // returns true
    console.log(Number.isSafeInteger(10123154654864878978765464));    // returns false


    // is Finite():  returns false if the argument is Infinity or NaN.
    console.log(isFinite(10 / 0));       // returns false
    console.log(isFinite(10 / 1));       // returns true

    // isNaN():  returns true if the argument is NaN. Otherwise it returns false.
    console.log(isNaN("Hello"));       // returns true
});
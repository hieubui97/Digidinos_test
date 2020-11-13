$().ready(function () {
    var person1 = { firstName: 'Jon', lastName: 'Kuperman' };
    var person2 = { firstName: 'Kelly', lastName: 'King' };

    function say(greeting1, greeting2) {
        console.log(greeting1 + ',' + greeting2 + ' ' + this.firstName + ' ' + this.lastName);
    }

    say.call(person1, 'Hello', 'Good morning'); // => Hello,Good morning Jon Kuperman
    say.call(person2, 'Hello', 'Good morning'); // => Hello,Good morning Kelly King

    var newFunction = say.bind(person1, 'Bind: Hello', 'Good morning'); // => Hello,Good morning Jon Kuperman
    newFunction();
});
$().ready(function () {
    // Object chứa hàm callback
    var domainInfo = {
        name: 'Digi dinos',
        setName: function (name) {
            // giá trị này sẽ không có tác dụng với key name trong object này
            // nếu như ta sử dụng nó là một callback function
            this.name = name;
        }
    };

    // Hàm có tham số callback
    function test(callback) {
        callback('This is window object');
    }

    // Gọi đến hàm và truyền hàm callback vào
    test(domainInfo.setName);

    // Vẫn kết quả cũ Digi dinos, tức là hàm callback setName đã ko tác động
    // gì tới thuộc tính name
    document.write('<h3>Sử dụng this khi sử dụng callback function trong object</h3>');
    document.write('domainInfo.name: '+ domainInfo.name);

    // Xuống hàng
    document.write('<br/>');

    // kết quả Hieu bui, tức đối tượng window đã tự tạo ra một key name 
    // và giá trị của nó chính là giá trị ta đã sét trong hàm setName
    // => this chính là window object
    document.write('window.name: '+ window.name);
   


    // Hàm có tham số callback
    document.write('<br/><h3>Sử dụng Apply()</h3>');
    function test2(callback, callbackObject) {
        var name = "callbackObject";
        callback.apply(callbackObject, [name]);
        // callback.call(callbackObject, name);
    }

    // Gọi đến hàm và truyền hàm callback vào
    test2(domainInfo.setName, domainInfo);

    // Kết quả: Hieu bui
    document.write('domainInfo.name: '+ domainInfo.name);
    document.write('<br/>');
});
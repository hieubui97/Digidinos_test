$().ready(function () {
    var blog = {
        domain: "freetuts.net",
        author: "Nguyễn Văn Cường",
        showWebsite: function (callbackFunction) {
            callbackFunction();
        },
        render: function () {
            this.showWebsite(function () {
                document.write('<h3>This trong closure function</h3>')
                document.write(this); // là đối tượng window
                document.write('<br/>');
                document.write(this.domain); // nên thuộc tính domain không tồn tại
                document.write('<br/>');
                document.write(this.author); /// nên thuộc tính author không tồn tại
            });
        }
    };

    blog.render();


    // Sử dụng bind()
    var blog = {
        domain: "Digi dinos",
        author: "Hieu bui",
        showWebsite: function (callbackFunction) {
            callbackFunction();
        },
        render: function () {
            this.showWebsite(function () {
                document.write('<h3>Sử dụng bind(this)</h3>')
                document.write(this); // là đối tượng window
                document.write('<br/>');
                document.write(this.domain); // nên thuộc tính domain không tồn tại
                document.write('<br/>');
                document.write(this.author); /// nên thuộc tính author không tồn tại
            }.bind(this));
        }
    };

    blog.render();
});

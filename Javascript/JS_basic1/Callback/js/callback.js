$().ready(function () {
    // Hàm tạo chuỗi mật khẩu
    function createPassword(callback) {
        // Kiểm tra tham số truyền vào phải là function
        if (typeof callback !== 'function') {
            alert('Bạn phải truyền vào là một function');
            return false;
        }

        return callback('Digi dinos');
    }

    // Sử dụng
    var password = createPassword(function (secret_key) {
        return secret_key;
    });

    alert(password);

});
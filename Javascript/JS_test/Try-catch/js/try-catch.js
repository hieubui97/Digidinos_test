$().ready(function () {
    $('#btn').on('click', function () {
        var username = $('#username').val();
        var password = $('#password').val();

        try {
            if (!username || !password) {
                var userError = new UserError();
                userError.throwLogin();
            }
            else {
                alert('Login success!');
            }
        } catch (error) {
            alert(error.message);
        }
    });
});

function UserError() {

    this.throwLogin = function () {
        throw new Error('Invalid username and password');
    };

    // this.throwSession = function(){
    //     throw new Error('Your request is timeout');
    // };

    return this;
}
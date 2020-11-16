$().ready(function(){
    $('#btn').on('click', function(){
        var input = $('#input').val();
        const promise = new Promise(function(resolve, reject){
            if(input == "promise"){
                resolve("Resolve !!");
            }
            else reject("Reject !!");
        });

        promise.then(function(result){
            alert(result);
        }).catch(function(err){
            alert(err);
        })
    });
});
angular.module('myApp').factory('ticfactory', ['$http', function ($http) {

    var factory = {};

    factory.GetRequest = function ()
    {

        return $http(
            {
                url: '../../Ticket/Getrequest',
                method:"GET"

            });
            

    };




    factory.gettype_request = function (vish)
    {
        debugger;
        return $http(
            {

                url: '../../Ticket/Get_request_type',
                method: "POST",
                data: JSON.stringify({ rid: vish})

            });

    };


    factory.type_sh = function (model) {

        return $http({

            url: '../../Ticket/Post_type_sh',
            method:"POST",
            data: JSON.stringify({tid: model})
        });


    };


    factory.submitForm = function (model) {

        debugger;
        return $http({
            

            url: '../../Ticket/Post_Submit',
            method: "POST",
            data: { 'd': model }
        });

    };


    return factory;
}
]);
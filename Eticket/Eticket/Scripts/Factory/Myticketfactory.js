angular.module('myApp').factory('ticfactory', ['$http', function ($http) {


    var factory = {};

    factory.getdetails = function (currentpageindex) {

        debugger;
        return $http({
            url: '../../Ticket/GetmyTickets?pageid='+currentpageindex,
            method: "GET",
            //data: JSON.stringify({ pageid: currentpageindex })

        });

    };


    factory.getrequestdetails = function () {

        //debugger;
        return $http({
            url:'../../Ticket/Getrequest',
            method:"GET"

        });
    };


    factory.getRequestType = function () {

        //debugger;
        return $http({
            url: '../../Ticket/Gettype_request',
            method: "GET"
          

    });
};


    return factory;
}
]);
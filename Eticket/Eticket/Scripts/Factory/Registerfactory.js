angular.module('myApp').factory('userfactory', ['$http', function ($http) {
    var factory = {};

    factory.GetCategory = function ()
    {


        return $http(
            {
                url: '../../UserDetail/GetCategory',
                method: "GET"

            });


    }


    factory.GetLocation = function () {


        return $http(
            {
                url: '../../UserDetail/GetLocation',
                method: "GET"

            });


    }


    return factory;



}]);
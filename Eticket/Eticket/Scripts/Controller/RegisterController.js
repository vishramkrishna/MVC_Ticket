var app = angular.module('myApp', []);
app.controller('RegisterCtrl', function ($scope, userfactory) {
  


    $scope.data = {};
    $scope.ResponseData = {};
    userfactory.GetCategory().then(function (response) {

        debugger;
        $scope.GetCategoryoption = JSON.parse(response.data.ResponseData);
        // $scope.rname = response.data[0].rname;
        //  $scope.rname = requestoption.rname;

    });

    userfactory.GetLocation().then(function (response) {

        debugger;
        $scope.GetLocationoption = JSON.parse(response.data.ResponseData);
        // $scope.rname = response.data[0].rname;
        //  $scope.rname = requestoption.rname;

    });



    $scope.OpenPopup = function () {
        $scope.user = {};

        $scope.submitted = false;
        $("#registerpopup").modal('toggle');

    };




  
});
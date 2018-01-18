var app = angular.module('myApp', ['ngAnimate', 'ngTouch', 'ui.bootstrap']);
app.controller('myticket', function ($scope, ticfactory) {

    $scope.data = {};


    ticfactory.getrequestdetails().then(function (response)
    {

        debugger;
        $scope.requestoptions = response.data;
        console.log($scope.requestoptions);

      
        ticfactory.getRequestType().then(function (response) {

            //debugger;
            $scope.requestoptiontype = response.data;
            console.log($scope.requestoptiontype);

            ticfactory.getdetails(1).then(function (response) {
                debugger;
                $scope.details = response.data;
                console.log($scope.details);

            })

        });


    });


    //ticfactory.getdetails().then(function (response) {
    //    debugger;
    //    $scope.details = response.data;
    //    console.log($scope.details);

    //})


   
    








   


    //$scope.getRequestType = function () {
    //    $scope.l = false; 
    // $scope.l = 0;
    //debugger;
    //if ($scope.Details[i].Request != undefined && $scope.Details[i].Request > 0) {

    // debugger;
    //for (var i = 0; i < $scope.requestoption.length; i++) {



    //  if ($scope.requestoption[i].rid == $scope.Details.Request) {
    //   return $scope.requestoption[i].rname
    //   $scope.requestoption[i].rname
    //}
    //}
    //}
    //}

    $scope.getRequest= function (requestid) {
      
       
        //console.log("Before Loop -Array-1" + $scope.requestoptions);
        // console.log( "Before Loop-Array-2" +$scope.Details)

        for (var i = 0; i < $scope.requestoptions.length; i++) {
            //debugger;

            if ($scope.requestoptions[i].rid == requestid)
            {

                return $scope.requestoptions[i].rname;
                //$scope.Details[j].rname


            }


        }

      
    }



    $scope.gettype_request = function (requesttypeid)
    {
        debugger;
        for (var i = 0; i < $scope.requestoptiontype.length;i++)
        {
              
            if($scope.requestoptiontype[i].tid == requesttypeid)
            {

                return $scope.requestoptiontype[i].tname;
            }

        }


    }
   


    $scope.pageChanged = function () {
        //$log.log('Page changed to: ' + $scope.details.CurrentPageIndex);
        var currpage = angular.copy($scope.details.CurrentPageIndex);
        ticfactory.getdetails(currpage).then(function (response) {
            debugger;
            $scope.details = response.data;
            $scope.details.CurrentPageIndex = currpage
            console.log($scope.details);

        })
    };


});

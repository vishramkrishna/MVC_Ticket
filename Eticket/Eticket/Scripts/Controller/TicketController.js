var app = angular.module('myApp', []);
app.controller('Ticket', function ($scope, ticfactory, $window) {
  //  debugger;
    //$scope.l = true;

   // $scope.l = 1;
  
    $scope.data = {};
    $scope.ResponseData = {};
    ticfactory.GetRequest().then(function (response)
    {
   
        //debugger;
        $scope.requestoption = JSON.parse(response.data.ResponseData);
        // $scope.rname = response.data[0].rname;
      //  $scope.rname = requestoption.rname;
            
    });
    


    $scope.getRequestType = function () {
      // $scope.l = false; 
        //$scope.l = 0;
       // debugger;
        if ($scope.data.Request != undefined && $scope.data.Request > 0)
        {
        
            //debugger;
            for (var i = 0; i < $scope.requestoption.length; i++) {
                if ($scope.requestoption[i].rid == $scope.data.Request) {
                    return $scope.requestoption[i].rname
                    // $scope.requestoption[i].rname
                }
            }
        }
    }


    $scope.getRequestName = function ()
    {

       // debugger;
        if ($scope.data.type_request != undefined && $scope.data.type_request > 0)
        {
            for (var i = 0; i < $scope.type_requestoption.length; i++)
            {
                if ($scope.type_requestoption[i].tid == $scope.data.type_request)
                {
                    return $scope.type_requestoption[i].tname
                }
            
            }

        }


    }





    $scope.gettype_request = function ()
    {

       debugger;
        if ($scope.data.Request) {
           // debugger;

            ticfactory.gettype_request($scope.data.Request).then(function (response) {
              //  debugger;
                $scope.type_requestoption = JSON.parse(response.data.ResponseData);
                  
            });

        }
        else { $scope.Request = null }
    }




    $scope.type_sh = function ()
    {

      // debugger;
        if ($scope.data.type_request) {

            ticfactory.type_sh($scope.data.type_request).then(function (response) {

                $scope.type_shoption = JSON.parse(response.data.ResponseData);

            });


        }

        else { $scope.data.type_request = null }




    }


    $scope.submit = function ()
    {
        debugger;

        console.log($scope.data);
      
       ticfactory.submitForm($scope.data).then(function (response) {


       });



    }

    $scope.myticket = function ()
    {
        $window.location = 'MyTicket';
         
    }






        
});


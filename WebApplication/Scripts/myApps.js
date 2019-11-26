var myApps = angular.module('myApps', []);
myApps.controller('AppsCtrl', function ($scope, $http) {
    //Lastname Variables
    $http.get("/Json/GetNumber")
    .success(function (result) {
        $scope.test = result;
    })
    .error(function (result) {
        console.log();
    });
    //Name Variables
    $http.get("/Json/GetString")
    .success(function (result) {
        $scope.test2 = result;
    })
    .error(function (result) {
        console.log();
    });
    //ID Variables
    $http.get("/Json/GetId")
   .success(function (result) {
       $scope.test3 = result;
   })
   .error(function (result) {
       console.log();
   });
});



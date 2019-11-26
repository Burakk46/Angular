var myApp = angular.module('myApp', []);
myApp.controller('studentCtrl', function ($scope, $http) {

    $scope.Students = "";
    $http.get("/Json/Getstudent")
    .success(function (result) {
        $scope.Students = result;
    })
    .error(function (result) {
        console.log(result);
    });
});
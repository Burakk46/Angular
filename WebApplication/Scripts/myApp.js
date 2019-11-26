var myApp = angular.module('myApp', []);
myApp.controller('studentCtrl', function ($scope, $http) {

    $scope.Students = "";
    $http.get("/Home/Getstudent")
    .success(function (result) {
        $scope.Students = result;
        var deneme = result;
    })
    .error(function (result) {
        console.log(result);
    });
});
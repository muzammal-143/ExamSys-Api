

function getRoles($scope, $http) {
    $scope.x = "Volvo";
    $http({
        method: 'GET',
        url: '/Role/all'
    }).then(function successCallback(response) {
        $scope.response = response;
    }, function errorCallback(response) {

    });

}






angular.module('Role')
    .controller('getRoles', getRoles);
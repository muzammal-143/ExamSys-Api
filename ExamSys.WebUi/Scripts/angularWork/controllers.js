

function getRoles($scope, $http) {

    $http({
        method: 'GET',
        url: '/Role/all'
    }).then(function successCallback(response) {
        $scope.response = response;
    }, function errorCallback(response) {

    });

}

app.controller('myCtrl', function ($scope) {
    $scope.carname = "Volvo";
});




angular.module('alef')
    .controller('getRoles', getRoles)
    .controller('myCtrl', myCtrl)
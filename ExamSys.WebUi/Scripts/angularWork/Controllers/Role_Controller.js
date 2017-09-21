
function index($scope, $http) {
    
    
    $http({
        method: 'GET',
        url: '/Role/all'
    }).then(function successCallback(response) {
        response = response.data;
        $scope.data = [];
        try {    
            if (response.status == "success") {
                $scope.data = response.data;
            }
        } catch (e) {
            console.log(e.message);
        }
        
    }, function errorCallback(response) {
    });
}




angular.module('Role')
    .controller('index', index);
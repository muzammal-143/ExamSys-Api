
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

function add($scope, $http) {
    


    $scope.submit = function () {

        var onSuccess = function (data, status, headers, config) {
            alert('Student saved successfully.');
        };

        var onError = function (data, status, headers, config) {
            alert('Error occured.');
        }

        $http.post('/Role/add', { Role: $scope.Role })
                .success(onSuccess)
                .error(onError);

    };



};



angular.module('Role')
    .controller('index', index)
    .controller('add',add)
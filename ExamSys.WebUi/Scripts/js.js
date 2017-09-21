/// <reference path="jquery-1.10.2.js" />
/// <reference path="angular.js" />

var myApp = angular.module('myApp', []);

myApp.controller('theController', ["$scope", "$log","$location",
    function ($scope, $log, $location)
    {
        $log.info($location.path());
        
    }
]);


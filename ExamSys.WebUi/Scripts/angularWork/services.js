/**
 * Alef (ACT) - Laravel + Angular Boilerplate
 * Team: NDP Scratcher's
 *
 * services.js
 */

function Auth($localStorage, $q, $location) {
    return {
        checkPermissionForView: function(view){
            if(!view.permissions || !view.permissions.length){
                return true;
            }
            return this.hasPermissions(view.permissions);
        },

        getUrlPermission: function (data) {
            var deferred = $q.defer();
            if (this.hasPermissions(data)) {
                deferred.resolve();
            } else {
                $location.path('/index/main');
            }
            return deferred.promise;
        },

        hasPermissions: function (data) {
            var found = false;
            var user = $localStorage.user;
            if(typeof user === "undefined"){
                return found;
            }
            if (angular.isArray(data)) {
                angular.forEach(data, function (per, index) {
                    if(user.roles != '') {
                        angular.forEach(user.roles, function (permissions, role) {
                            if (permissions.indexOf(per) >= 0) {
                                found = true;
                                return;
                            }
                        });
                    }
                });
            } else {
                angular.forEach(user.roles, function (permissions, role) {
                    if (permissions.indexOf(data) >= 0) {
                        found = true;
                        return;
                    }
                });
            }
            return found;
        },

        hasRoles: function (data) {
            var found = false;
            var user = $localStorage.user;
            if (angular.isArray(data)) {
                angular.forEach(data, function (value, index) {
                    angular.forEach(user.roles, function (permissions, role) {
                        if (role === value) {
                            found = true;
                            return;
                        }
                    });
                });
            } else {
                angular.forEach(user.roles, function (permissions, role) {
                    if (role == value) {
                        found = true;
                        return;
                    }
                });
            }
            return found;
        },

    };
}

function AuthInterceptor($q, $location, $localStorage, $window, $rootScope) {

    return {
        'request': function (config) {
            config.headers = config.headers || {};

            var bearerToken = $localStorage.bearerToken;
            var cTag = $localStorage.cTag;

            config.headers['cTag'] = cTag;

            if (bearerToken) {
                config.headers['Authorization'] = bearerToken;
            }

            return config;
        },
        'response' : function (response) {
            if(response.data.cTag){
                $localStorage.cTag = response.data.cTag;
            }

            if(response.data.user){
                $localStorage.user = response.data.user;
                $rootScope.user = response.data.user;
            }

            if(response.data.userSocialite){
                $localStorage.userSocialite = response.data.userSocialite;
                $rootScope.userSocialite = response.data.userSocialite;
            }

            return response;
        },
        'responseError': function (response) {
            if(response.data.error === 'permission_denied'){
                $location.path('/404');
            }
            else if (response.status === 401 || response.status === 403) {
                $localStorage.$reset();
                // Need to reset view here.
            }
            return $q.reject(response);
        }
    };
}

function Options($http, $localStorage, $rootScope, SweetAlert) {
    return {
        getUserProfile: function () {
            $http.get('/cpanel/user/profile').success(function (response) {
                //alert(JSON.stringify(responce));
                $localStorage.user = response.data;
                $rootScope.user = response.data;

            }).error(function (responce) {
                //alert(JSON.stringify(responce));
            });
        }
    }
}

function SocialiteTimeline($http) {
    var SocialiteTimeline = function(usId) {
        this.items = [];
        this.busy = false;
        this.after = '';
        this.usId = usId;
    };

    SocialiteTimeline.prototype.nextPage = function() {
        if (this.busy) return;
        this.busy = true;

        var url = "/api/v1/socialite/posts?us_id="+this.usId;
        if(this.after != ''){
            url += '&next='+this.after;
        }

        $http({
            method: 'GET',
            url: url
        }).then(function successCallback(response) {
            if(response.data.status == 'success'){
                //var data = response.data.data;
                var items = response.data.data;
                this.items = this.items.concat(items);
                this.after = response.data.next;
                this.busy = false;
            } else {
                SweetAlert.swal('Oops...', response.data.message, 'error');
            }
        }.bind(this));
    };

    return SocialiteTimeline;
}




angular.module('alef')
    .factory('Auth', Auth)
    .factory('AuthInterceptor', AuthInterceptor)
    .factory('Options', Options)
    .factory('SocialiteTimeline', SocialiteTimeline);
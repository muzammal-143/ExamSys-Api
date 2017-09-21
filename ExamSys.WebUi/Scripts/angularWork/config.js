/**
 * Alef (ACT) - Laravel + Angular Boilerplate
 * Team: NDP Scratcher's
 *
 * config.js
 */

function config($stateProvider, $urlRouterProvider, $ocLazyLoadProvider, $httpProvider, $authProvider) {

    $ocLazyLoadProvider.config({
        // Set to true if you want to see what and when is dynamically loaded
        debug: false
    });

    $stateProvider
        .state('404', {
            url: "/404",
            templateUrl: "/dashboard/errors/404.html",
            data: { pageTitle: 'Error 404 Page Not Found.', specialClass: 'gray-bg' },
        })
        .state('index', {
            abstract: true,
            url: "/index",
            templateUrl: "/dashboard/common/content.html"
        })
        .state('index.main', {
            url: "/main?usId",
            templateUrl: "/dashboard/dashboard.html",
            data: {pageTitle: 'Alef - Dashboard'},
            resolve: {
                //getUrlPermission: function (Auth) {return Auth.getUrlPermission('cpanel');}
            }
        })
        .state('index.minor', {
            url: "/minor",
            templateUrl: "/dashboard/minor.html",
            data: {pageTitle: 'Example view'},
            resolve: {
                getUrlPermission: function (Auth) {return Auth.getUrlPermission('dashboard');}
            }
        })
        .state('settings', {
            abstract: true,
            url: "/settings",
            templateUrl: "/dashboard/common/content.html",
        })
        .state('settings.general', {
            url: "/general",
            templateUrl: "/dashboard/settings_general.html",
            data: {pageTitle: 'General Settings'},
            resolve: {
                //getUrlPermission: function (Auth) {return Auth.getUrlPermission('options_general');}
            }
        })
        .state('settings.cache', {
            url: "/cache",
            templateUrl: "/dashboard/settings_cache.html",
            data: {pageTitle: 'Cache Settings'},
            resolve: {
                getUrlPermission: function (Auth) {return Auth.getUrlPermission('options_cache');},
                loadPlugin: function ($ocLazyLoad) {
                    return $ocLazyLoad.load([{
                            name: 'ui.switchery',
                            files: [
                                '/libs/switchery/switchery.min.css',
                                '/libs/switchery/switchery.min.js',
                                '/libs/switchery/ng-switchery.js'
                            ]}
                    ]);
                }
            }
        })
        .state('settings.socialite', {
            url: "/socialite",
            templateUrl: "/dashboard/settings_socialite.html",
            data: {pageTitle: 'Socialite Settings'},
            controller: 'socialiteSetCtrl',
            resolve: {
                getUrlPermission: function (Auth) {return Auth.getUrlPermission('options_cache');},
            }
        })

    $authProvider.httpInterceptor = function() { return true; },
        $authProvider.withCredentials = false;
    $authProvider.tokenRoot = null;
    $authProvider.baseUrl = '/';
    $authProvider.loginUrl = '/login';
    $authProvider.signupUrl = '/register';
    $authProvider.unlinkUrl = '/auth/unlink/';
    $authProvider.tokenName = 'token';
    $authProvider.tokenPrefix = 'satellizer';
    $authProvider.tokenHeader = 'Authorization';
    $authProvider.tokenType = 'Bearer';
    $authProvider.storageType = 'localStorage';

// Facebook
    $authProvider.facebook({
        name: "facebook",
        url: "/login/facebook",
        authorizationEndpoint: "https://www.facebook.com/v2.5/dialog/oauth",
        redirectUri: window.env_fb_redirect,
        requiredUrlParams: ["display", "scope"],
        scope: window.env_fb_scopes,
        scopeDelimiter: ",",
        display: "popup",
        oauthType: "2.0",
        popupOptions: { width: 580, height: 400 },
        clientId: window.env_fb_client_id
    });

// Google
    $authProvider.google({
        url: '/login/google',
        authorizationEndpoint: 'https://accounts.google.com/o/oauth2/auth',
        redirectUri: window.env_gl_redirect,
        requiredUrlParams: ['scope'],
        optionalUrlParams: ['display', 'access_type', 'prompt'],
        scope: window.env_gl_scopes,
        scopePrefix: 'openid',
        scopeDelimiter: ' ',
        display: 'popup',
        accessType: 'offline',
        prompt: 'consent select_account',
        oauthType: '2.0',
        popupOptions: { width: 452, height: 633 },
        clientId: window.env_gl_client_id
    });


    $urlRouterProvider.otherwise("/index/main");

    $httpProvider.interceptors.push(AuthInterceptor);
}

function run($rootScope, $state, $localStorage, Options) {
    $rootScope.$state = $state;
    $rootScope.$on("$stateChangeStart", function (event, next) {
        var user = $localStorage.user;
        if(!user){
            //Options.getUserProfile();
        }
    });
}

angular
    .module('alef')
    .config(config)
    .run(run);

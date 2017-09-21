/**
 * Alef (ACT) - Laravel + Angular Boilerplate
 * Team: NDP Scratcher's
 *
 * directives.js
 */

/**
 * pageTitle - Directive for set Page title - mata title
 */
function pageTitle($rootScope, $timeout) {
    return {
        link: function(scope, element) {
            var listener = function(event, toState) {

                // Default title
                var title = 'Alef | Laravel boiler plate';

                // Create your own title pattern
                if (toState.data && toState.data.pageTitle) title = 'Alef | ' + toState.data.pageTitle;
                $timeout(function() {
                    element.text(title);
                });
            };
            $rootScope.$on('$stateChangeStart', listener);
        }
    }
}

/**
 * sideNavigation - Directive for run metsiMenu on sidebar navigation
 */
function sideNavigation($timeout) {
    return {
        restrict: 'A',
        link: function(scope, element) {
            // Call the metsiMenu plugin and plug it to sidebar navigation
            $timeout(function(){
                element.metisMenu();
            });
        }
    };
}

/**
 * iboxTools - Directive for iBox tools elements in right corner of ibox
 */
function iboxTools($timeout) {
    return {
        restrict: 'A',
        scope: true,
        templateUrl: 'views/common/ibox_tools.html',
        controller: function ($scope, $element) {
            // Function for collapse ibox
            $scope.showhide = function () {
                var ibox = $element.closest('div.ibox');
                var icon = $element.find('i:first');
                var content = ibox.find('div.ibox-content');
                content.slideToggle(200);
                // Toggle icon from up to down
                icon.toggleClass('fa-chevron-up').toggleClass('fa-chevron-down');
                ibox.toggleClass('').toggleClass('border-bottom');
                $timeout(function () {
                    ibox.resize();
                    ibox.find('[id^=map-]').resize();
                }, 50);
            },
                // Function for close ibox
                $scope.closebox = function () {
                    var ibox = $element.closest('div.ibox');
                    ibox.remove();
                }
        }
    };
}

/**
 * iboxTools with full screen - Directive for iBox tools elements in right corner of ibox with full screen option
 */
function iboxToolsFullScreen($timeout) {
    return {
        restrict: 'A',
        scope: true,
        templateUrl: 'views/common/ibox_tools_full_screen.html',
        controller: function ($scope, $element) {
            // Function for collapse ibox
            $scope.showhide = function () {
                var ibox = $element.closest('div.ibox');
                var icon = $element.find('i:first');
                var content = ibox.find('div.ibox-content');
                content.slideToggle(200);
                // Toggle icon from up to down
                icon.toggleClass('fa-chevron-up').toggleClass('fa-chevron-down');
                ibox.toggleClass('').toggleClass('border-bottom');
                $timeout(function () {
                    ibox.resize();
                    ibox.find('[id^=map-]').resize();
                }, 50);
            };
            // Function for close ibox
            $scope.closebox = function () {
                var ibox = $element.closest('div.ibox');
                ibox.remove();
            };
            // Function for full screen
            $scope.fullscreen = function () {
                var ibox = $element.closest('div.ibox');
                var button = $element.find('i.fa-expand');
                $('body').toggleClass('fullscreen-ibox-mode');
                button.toggleClass('fa-expand').toggleClass('fa-compress');
                ibox.toggleClass('fullscreen');
                setTimeout(function() {
                    $(window).trigger('resize');
                }, 100);
            }
        }
    };
}

/**
 * minimalizaSidebar - Directive for minimalize sidebar
*/
function minimalizaSidebar($timeout) {
    return {
        restrict: 'A',
        template: '<a class="navbar-minimalize minimalize-styl-2 btn btn-primary " href="" ng-click="minimalize()"><i class="fa fa-bars"></i></a>',
        controller: function ($scope, $element) {
            $scope.minimalize = function () {
                $("body").toggleClass("mini-navbar");
                if (!$('body').hasClass('mini-navbar') || $('body').hasClass('body-small')) {
                    // Hide menu in order to smoothly turn on when maximize menu
                    $('#side-menu').hide();
                    // For smoothly turn on menu
                    setTimeout(
                        function () {
                            $('#side-menu').fadeIn(400);
                        }, 200);
                } else if ($('body').hasClass('fixed-sidebar')){
                    $('#side-menu').hide();
                    setTimeout(
                        function () {
                            $('#side-menu').fadeIn(400);
                        }, 100);
                } else {
                    // Remove all inline style from jquery fadeIn function to reset menu state
                    $('#side-menu').removeAttr('style');
                }
            }
        }
    };
}

/**
 * fullScroll - Directive for slimScroll with 100%
 */
function fullScroll($timeout){
    return {
        restrict: 'A',
        link: function(scope, element) {
            $timeout(function(){
                element.slimscroll({
                    height: '100%',
                    railOpacity: 0.9
                });

            });
        }
    };
}

/**
 * slimScroll - Directive for slimScroll with custom height
 */
function slimScroll($timeout){
    return {
        restrict: 'A',
        scope: {
            boxHeight: '@'
        },
        link: function(scope, element) {
            $timeout(function(){
                element.slimscroll({
                    height: scope.boxHeight,
                    railOpacity: 0.9
                });

            });
        }
    };
}

/**
 * Auth - Directive to check Permissions
 */
function checkPermissions(Auth) {
    return {
        restrict: 'A',
        scope: {
            checkPermissions: '='
        },

        link: function (scope, elem, attrs) {
            scope.$watch(Auth.isLoggedIn, function() {
                if (Auth.hasPermissions(attrs.checkPermissions)) {
                    elem.show();
                } else {
                    elem.hide();
                }
            });
        }
    }
}


function checkRoles(Auth) {
    return {
        restrict: 'A',
        scope: {
            checkRoles: '='
        },

        link: function (scope, elem, attrs) {
            scope.$watch(Auth.isLoggedIn, function() {
                if (Auth.hasRoles(attrs.checkRoles)) {
                    elem.show();
                } else {
                    elem.hide();
                }
            });
        }
    }
}

function reverse () {
    return function (items) {
        //return items.slice().reverse();
    }
}




function timelineVideoPlayer() {
    return {
        restrict: 'E',
        replace: true,
        transclude: true,
        scope: {
            source: '@',
            thumbnail: '@',
            template: '@'
        },
        templateUrl: '/dashboard/elements/timelineVideoPlayer.html'
    };
}

function timelinePicture() {
    return {
        restrict: 'E',
        replace: true,
        transclude: true,
        scope: {
            picture: '@',
            alt: '@'
        },
        templateUrl: '/dashboard/elements/timelinePicture.html'
    };
}

function timelineAttachmentTitle() {
    return {
        restrict: 'E',
        replace: true,
        transclude: true,
        scope: {
            value: '@'
        },
        template: '<div class="sbca-title"><h3 ng-if="value">{{value}}</h3></div>'
    };
}

function timelineAttachmentDescription() {
    return {
        restrict: 'E',
        replace: true,
        transclude: true,
        scope: {
            images: '@'
        },
        template: '<div class="sbca-description"><span ng-if="value">{{value}}</span></div>'
    };
}

function timelineSubAttachment() {
    return {
        restrict: 'E',
        replace: true,
        transclude: true,
        scope: {
            picture: '@',
            alt: '@'
        },
        templateUrl: '/dashboard/elements/timelinePicture.html'
    };
}

function timelineLink() {
    return {
        restrict: 'E',
        replace: true,
        transclude: true,
        scope: {
            picture: '@',
            alt: '@'
        },
        templateUrl: '/dashboard/elements/timelinePicture.html'
    };

}

function timelineShare() {
    return {
        restrict: 'E',
        replace: true,
        transclude: true,
        scope: {
            picture: '@',
            alt: '@'
        },
        templateUrl: '/dashboard/elements/timelinePicture.html'
    };
}

function timelineGallery($compile) {
    function link(scope, element, attrs) {
        var imgGallery = [];
        i = 0;
        angular.forEach(scope.images, function(value, key) {
            var obj = {}
            if(value.type == 'video'){
                obj.href = "https://video.xx.fbcdn.net/v/t42.1790-2/15572969_1122276231222887_3774307312856989696_n.mp4?efg=eyJybHIiOjM4OCwicmxhIjo1MTIsInZlbmNvZGVfdGFnIjoic3ZlX3NkIn0%3D&rl=388&vabr=216&oh=79621ec69507ff9474804c4c719dfb1d&oe=585FA078"
                obj.type = value.type+'/mp4'
            } else {
                obj.href = value.thumb
                obj.type = value.type
            }
            obj.id = value.id
            obj.index = i
            obj.poster = value.thumb
            obj.thumbnail = value.thumb

            this.push(obj);
            i++;
        }, imgGallery);

        scope.imgGallery = imgGallery;

        scope.gridOptions = {
            urlKey      :     "thumbnail",
            onClicked   :     function(image) {
                var gallery = blueimp.Gallery(
                    imgGallery,
                    {
                        index: image.index,
                        preloadRange: 2
                    }
                );
            },
            onBuilded   :     function() {
                console.log ("built completed!")
                scope.isBuildingGrid = false;
            },
            margin      :     2,
            maxLength   :     4
        }

        blueimp.Gallery.prototype.videoFactory = function (obj, callback, videoInterface) {
            var that = this
            var options = this.options
            var videoContainerNode = this.elementPrototype.cloneNode(false)
            var videoContainer = $(videoContainerNode)
            var errorArgs = [{
                type: 'error',
                target: videoContainerNode
            }]

            var video = videoInterface || document.createElement('timeline-video-player')
            $compile(video)(scope)
            var url = this.getItemProperty(obj, options.urlProperty)
            var type = this.getItemProperty(obj, options.typeProperty)
            var title = this.getItemProperty(obj, options.titleProperty)
            var posterUrl = this.getItemProperty(obj, options.videoPosterProperty)
            var posterImage
            var sources = this.getItemProperty(
                obj,
                options.videoSourcesProperty
            )
            var source
            var playMediaControl
            var isLoading
            var hasControls
            videoContainer.addClass(options.videoContentClass)
            if (title) {
                videoContainerNode.title = title
            }

            alert(video.childElementCount);

            video.src = url

            if (posterUrl) {
                video.poster = posterUrl
                posterImage = this.imagePrototype.cloneNode(false)
                $(posterImage).addClass(options.toggleClass)
                posterImage.src = posterUrl
                posterImage.draggable = false
                videoContainerNode.appendChild(posterImage)
            }
            playMediaControl = document.createElement('a')
            playMediaControl.setAttribute('target', '_blank')
            if (!videoInterface) {
                playMediaControl.setAttribute('download', title)
            }
            playMediaControl.href = url
            if (video.src) {
                video.controls = true

                $(playMediaControl).on('click', function (event) {
                    that.preventDefault(event)

                })
                videoContainerNode.appendChild(
                    (videoInterface && videoInterface.element) || video
                )
            }
            videoContainerNode.appendChild(playMediaControl)
            this.setTimeout(callback, [{
                type: 'load',
                target: videoContainerNode
            }])
            return videoContainerNode
        }
    }

    return {
        scope: {
                images:"="
                },
        template: '<div ng-photo-grid="" images="imgGallery" grid-options="gridOptions" id=""></div>',
        link: link
    };
}



function passwordVerify() {
    return {
        require: "ngModel",
        scope: {
            passwordVerify: '='
        },
        link: function(scope, element, attrs, ctrl) {
            scope.$watch(function() {
                var combined;

                if (scope.passwordVerify || ctrl.$viewValue) {
                    combined = scope.passwordVerify + '_' + ctrl.$viewValue;
                }
                return combined;
            }, function(value) {
                if (value) {
                    ctrl.$parsers.unshift(function(viewValue) {
                        var origin = scope.passwordVerify;
                        if (origin !== viewValue) {
                            ctrl.$setValidity("passwordVerify", false);
                            return undefined;
                        } else {
                            ctrl.$setValidity("passwordVerify", true);
                            return viewValue;
                        }
                    });
                }
            });
        }
    };
}

function keepImageInBound() {
    return {
        restrict: 'A',
        link: function(scope, element, attrs) {
            element.bind('load', function() {
                if (element[0].clientHeight > element.parent()[0].clientHeight){
                    element.css('height', element.parent()[0].clientHeight+ 'px');
                }
            });
        }
    }
}

/**
 *
 * Pass all functions into module
 */
angular
    .module('alef')
    .directive('pageTitle', pageTitle)
    .directive('sideNavigation', sideNavigation)
    .directive('iboxTools', iboxTools)
    .directive('minimalizaSidebar', minimalizaSidebar)
    .directive('iboxToolsFullScreen', iboxToolsFullScreen)
    .directive('fullScroll', fullScroll)
    .directive('slimScroll', slimScroll)

    // Authentication
    .directive('checkPermissions', checkPermissions)
    .directive('checkRoles', checkRoles)
    .directive('passwordVerify', passwordVerify)


    // Custom Directives
    .directive('timelineVideoPlayer', timelineVideoPlayer)
    .directive('timelinePicture', timelinePicture)
    .directive('timelineAttachmentTitle', timelineAttachmentTitle)
    .directive('timelineAttachmentDescription', timelineAttachmentDescription)
    .directive('keepImageInBound', keepImageInBound)
    .directive('timelineGallery', timelineGallery)


    // Filters
    .filter('reverse', reverse);







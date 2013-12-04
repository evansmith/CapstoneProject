
var SongApp = angular.module("SongApp", ["ngResource"]).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', { controller: MainCtrl, templateUrl: 'home.html' }).
            otherwise({ redirectTo: '/' });
    });

SongApp.factory('SoundFactory', function ($resource) {
    return $resource('/api/Sound/:id', { id: '@id' }, { update: { method: 'PUT' } })
});


var MainCtrl = function ($scope, $location, SoundFactory) {

    //$scope.init = function () {

        
    //}
    //$scope.init();
    $scope.sounds = SoundFactory.query();
    
    $scope.currentSong; 

    $scope.reset = function () {
        $scope.sounds = SoundFactory.query({ s: $scope.search });
    };

    $scope.play = function (Sound) {
        if ($scope.currentSong != null)
            $scope.currentSong.stop();
        $scope.currentSong = new buzz.sound(Sound.Location);
        console.log("im being clicked!", Sound.Location);
        $scope.currentSong.play();
    }

    $scope.stop = function (Sound) {
        $scope.currentSong.stop();
    };

};


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

    $scope.init = function () {

        $scope.sounds = SoundFactory.query();

        //$scope.createdSounds = [];
        //$scope.createSounds = function (sounds, createdSounds) {
        //    for (i = 0; i < sounds.length; i++) {
        //        createdSounds[i].song = new buzz.sound(sounds[i].Location);
        //    }
        //    return createdSounds;
        //};

        
        //$scope.createSounds($scope.sounds, $scope.createdSounds);
        //console.log($scope.createSounds($scope.sounds, $scope.createdSounds));

        
        //$scope.sounds = [
        //   { sound: $scope.sound1, name: "24 Beep", description: "Sample from the television show 24"},
        //   { sound: $scope.sound2, name: "Cymbal-Hi Hat", description: "A Sample of a Zildjian Hi Hat Cymbal" },
        //   { sound: $scope.sound3, name: "Long Test", description: "Testing length" }
        //   //{ sound: $scope.sound4, name: "sound4", description: "testing a function" }
        //];

        
        
    }

    $scope.init();    
    //write a method here that creates a sound more efficiently
    
    $scope.play = function (Sound) {
        var soundPlay = new buzz.sound(Sound.Location);
        console.log("im being clicked!", Sound.Location);
        soundPlay.play();
    }

    //write a stop function here

};

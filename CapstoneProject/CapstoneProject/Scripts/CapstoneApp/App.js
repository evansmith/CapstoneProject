var SongApp = angular.module("SongApp", ["ngResource"]).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', { controller: MainCtrl, templateUrl: 'home.html' }).
            otherwise({ redirectTo: '/' });
    });



var MainCtrl = function ($scope, $location) {
    $scope.sound1 = new buzz.sound('http://localhost:50990/Sounds/ctu-24-ringtone.mp3', {
        preload: true,
        autoplay: false,
    });
    $scope.sound2 = new buzz.sound("\Users\smith_000\Downloads\16300_ltibbits_snare_2_high_vol");
    $scope.sounds = [
        { sound: $scope.sound1, name: "Sound1" },
        { sound: $scope.sound2, name: "Sound2" }
    ];


    $scope.play = function (sound) {
        console.log("im being clicked!", sound);
        sound.play();
    }
};

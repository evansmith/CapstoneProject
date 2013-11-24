
var SongApp = angular.module("SongApp", ["ngResource"]).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', { controller: MainCtrl, templateUrl: 'home.html' }).
            otherwise({ redirectTo: '/' });
    });



var MainCtrl = function ($scope, $location) {

    $scope.init = function () {
        //$scope.createASound = function (name, file) {
        //    $scope.name = new buzz.sound(file, {
        //        preload: 'metadata'
        //    });
        //    console.log($scope.name);
        //    return $scope.name;
        //};

        $scope.sound1 = new buzz.sound('http://localhost:50990/Sounds/ctu-24-ringtone.mp3', {
            preload: 'metadata'
        });
        

        $scope.sound2 = new buzz.sound('http://localhost:50990/Sounds/45666_pjcohen_Zildjian_A_Custom_Hi_Hat_Cymbals_Loose_Hit.WAV', {
            preload: 'metadata'
        });

        $scope.sound3 = new buzz.sound('http://localhost:50990/Sounds/shopping cart.mp3', {
            preload: 'metadata'
        });

        //$scope.createASound('sound4', 'http://localhost:50990/Sounds/16317_ltibbits_tom_13_tight_low_vol.wav');
        
        $scope.sounds = [
           { sound: $scope.sound1, name: "24 Beep", description: "Sample from the television show 24"},
           { sound: $scope.sound2, name: "Cymbal-Hi Hat", description: "A Sample of a Zildjian Hi Hat Cymbal" },
           { sound: $scope.sound3, name: "Long Test", description: "Testing length" }
           //{ sound: $scope.sound4, name: "sound4", description: "testing a function" }
        ];

        $scope.getSoundDuration = function (sound) {
            var duration1 = sound.bind("loadedmetadata", function (duration) {
                console.log(buzz.toTimer(sound.getDuration()));
                return buzz.toTimer(sound.getDuration());
            });
        }
        
    }

    $scope.init();
    $scope.getSoundDuration($scope.sound1);
    
    //write a method here that creates a sound more efficiently

    $scope.play = function (sound) {
        console.log("im being clicked!", sound);
        sound.play();
    }

    //write a stop function here

};

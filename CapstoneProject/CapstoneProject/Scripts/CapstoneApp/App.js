var SongApp = angular.module("SongApp", ["ngResource"]).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', { controller: MainCtrl, templateUrl: 'home.html' }).
            otherwise({ redirectTo: '/' });
    });



var MainCtrl = function ($scope, $location) {

    $scope.init = function () {
        $scope.sound1 = new buzz.sound('http://localhost:50990/Sounds/ctu-24-ringtone.mp3', {
            preload: 'metadata'
        });
        $scope.sound2 = new buzz.sound('http://localhost:50990/Sounds/45666_pjcohen_Zildjian_A_Custom_Hi_Hat_Cymbals_Loose_Hit.WAV', {
            preload: 'metadata'
        });

        $scope.sound3 = new buzz.sound('http://localhost:50990/Sounds/shopping cart.mp3', {
            preload: 'metadata'
        });

        $scope.sounds = [
           { sound: $scope.sound1, name: "24 Beep", description: "Sample from the television show 24" },
           { sound: $scope.sound2, name: "Cymbal-Hi Hat", description: "A Sample of a Zildjian Hi Hat Cymbal" },
           { sound: $scope.sound3, name: "Long Test", description: "Testing length" }
        ];

        //$scope.showIt = function (duration) {
        //    console.log(duration);
        //    return duration;
        //}

        $scope.getSoundDuration = function (sound) {
            var duration = "";
            sound.bind("loadedmetadata", function (duration) {
                duration = buzz.toTimer(sound.getDuration());
                console.log(duration);
                return duration;
            });  
        }

        
          

       


        
    }

    $scope.init();
    
    
   
    //write a method here that creates a sound more efficiently

    $scope.play = function (sound) {
        console.log("im being clicked!", sound);
        sound.play();
    }
};

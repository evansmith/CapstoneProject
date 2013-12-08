//This block of code initializes the sound application, called SongApp. 
var SongApp = angular.module("SongApp", ["ngResource"]).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', { controller: MainCtrl, templateUrl: 'home.html' }). //This establishes that when the MainCtrl is used, the template in the app will be home.html
            otherwise({ redirectTo: '/' }); //If i had more controllers, more templates would be chained right here. 
    });

SongApp.factory('SoundFactory', function ($resource) { //this is the block of code that makes the api calls to the backend. 
    return $resource('/api/Sound/:id', { id: '@id' }, { update: { method: 'PUT' } })
});


var MainCtrl = function ($scope, $location, SoundFactory) { //this is the main controller. $scope is what connects the controller to the view $location interacts with the url

    $scope.sounds = SoundFactory.query(); //This makes the initial query from the database
    
    $scope.currentSong; //This is the variable that the song will be. This variable is updated everytime somebody hits preview. 

    $scope.searchBar = function () { //search bar function
        SoundFactory.query({ s: $scope.search, limit: $scope.limit, offset: $scope.offset }, //this calls the backend, with a limit and offset on how many results per page. 
            function (sounds) {
                var count = sounds.length; //this block of code checks how many songs there are, then 'makes sure' only 20 come through. 
                $scope.upperLimit = count < 20;
                $scope.sounds = $scope.sounds.concat(sounds);
            }
        );
    };



    $scope.reset = function () { //this resets everything.
        $scope.offset = 0;
        $scope.sounds = [];
        $scope.searchBar(); 
    };

    $scope.moreSounds = function () { //this function allows more sounds to pass through. 
        return !$scope.upperLimit;
    };

    $scope.limit = 20; //sets the limit to 20.

    $scope.reset(); //initializes reset. 
    $scope.play = function (Sound) { //this is the function that plays the sound. 
        if ($scope.currentSong != null) //if there is already a sound, make it stop (so multiple sounds dont play at the same time)
            $scope.currentSong.stop();
        $scope.currentSong = new buzz.sound(Sound.Location); //create a new sound based on its location
        $scope.currentSong.play(); //play the sound. 
    }

    $scope.stop = function (Sound) {
        $scope.currentSong.stop(); //stops the sound on button press. 
    };

    


};

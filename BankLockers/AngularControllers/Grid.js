var gridApp = angular.module('gridApp', []);
gridApp.controller('gridController', function ($scope,$http) {
    $scope.message = "taming the editable grid view in Angular js";

    $http({
        method: 'POST',
        url: '/Lockers/GetLockerList'
    }).then(function (response) {
        $scope.lockerList = response.data.lockerRepositoryList;
        console.log($scope.lockerList);
        var locations = [];

        angular.forEach($scope.lockerList, function (value, key) {
            locations.push(value.Location);
        });

        let uniqueLocations = []
        for (let i = 0; i < locations.length; i++) {
            if (uniqueLocations.indexOf(locations[i]) == -1) {
                uniqueLocations.push(locations[i])
            }
        }

        $scope.locations = console.log(uniqueLocations);
        console.log(locations);
        console.log(uniqueLocations);


        }, function (error) { console.log(error); });
    
});











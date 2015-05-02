var cardsControllers = angular.module('cardsControllers', []);

cardsControllers.controller('cardsListController', ['$scope', '$http', function ($scope, $http) {
        //$scope.cards = [{ id: 1 }, { id: 2 }];
        $http.get("all.json").success(function (data) {
            var cards = [];
            angular.forEach(data, function(card) {
                cards.push(card);
            });
            $scope.cards = cards;
        });
    }]);
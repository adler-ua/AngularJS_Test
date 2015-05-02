var cardsControllers = angular.module('cardsControllers', []);

cardsControllers.controller('cardsListController', ['$scope', 'cardsService',
    function ($scope, cardsService) {
        //$scope.cards = [{ id: 1 }, { id: 2 }];
        cardsService.query(function (data) {
            var cards = [];
            angular.forEach(data, function(card) {
                cards.push(card);
            });
            $scope.cards = cards;
        });
    }]);
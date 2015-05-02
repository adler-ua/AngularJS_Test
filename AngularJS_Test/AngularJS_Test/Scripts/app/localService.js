var cardsServices = angular.module('cardsServices', ['ngResource']);

cardsServices.factory('Cards', [
    '$resource',
    function($resource) {
        return $resource('home/allcards', {}, {
            query: { method: 'GET', params: {}, isArray: true }
        });
    }]);
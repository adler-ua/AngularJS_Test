var cardsServices = angular.module('cardsServices', ['ngResource']);

cardsServices.factory('cardsService', ['$resource',
    function ($resource) {
        return $resource('/api/cards', {}, {
            query: { method: 'GET', params: {}, isArray: true }
        });
    }]);
﻿var cardsServices = angular.module('cardsServices', ['ngResource']);

cardsServices.factory('cardsService', ['$resource',
    function ($resource) {
        return $resource('home/allcards', {}, {
            query: { method: 'GET', params: {}, isArray: true }
        });
    }]);
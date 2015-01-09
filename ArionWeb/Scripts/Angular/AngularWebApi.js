var app = angular.module('application', []);

app.factory('webApiFactory', ['$http', function ($http) {
    var webApiUrl = '/api';
    var webApiUrlForClasses = '/ElementClass';
    var webApiFactory = {};

    webApiFactory.getClasses = function (id) {
        if (id) {
            return $http({
                url: webApiUrl + webApiUrlForClasses + '/get',
                method: "GET",
                params: { id: id }
            });
        }
        $http.get(webApiUrl + webApiUrlForClasses);
    };

    return webApiFactory;
}]);

app.controller('webApiController', ['$scope', 'webApiFactory', function ($scope, webApiFactory) {
    $(document).ready(function () {
        console.log(webApiFactory.getClasses([1,2,3]));
    });
}]);
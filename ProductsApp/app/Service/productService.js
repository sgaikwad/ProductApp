

productApp.factory('productService', function ($http) {

    var url = "http://localhost/ProductsApp/api/Product/";

    get = function () {

        var serviceUrl = url + "/" + "get";

        return $http.get(serviceUrl);
    };

    GetByName = function (name) {
        var urlParameters = url + "/" + "GetByName" + "?name=" + name;
        return $http.get(urlParameters);
    };

    return {
        get: get,
        GetByName: GetByName
    }
});
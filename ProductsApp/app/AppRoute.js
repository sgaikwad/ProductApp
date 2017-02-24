productApp.config(function ($routeProvider) {
    $routeProvider.when("/home", {
        templateUrl: "C:\Deployment\productapp\app\Templates\Search.html",
        controller: "searchController"
    })
    .otherwise({
        redirectTo: "/home"
    });
});
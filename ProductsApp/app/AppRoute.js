productApp.config(function ($routeProvider) {
    $routeProvider.when("/home", {
        templateUrl: "productsapp/app/Templates/Search.html",//"C:\Deployment\productapp\app\Templates\Search.html",
        controller: "searchController"
    }).when("/details", {
        templateUrl: "productsapp/app/Templates/Details.html",
        controller: "detailsController"
    })
    .otherwise({
        redirectTo: "/home"
    });
});
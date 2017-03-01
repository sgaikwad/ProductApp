
productApp.controller('searchController', function ($scope, productService) {
    
    OnSuccess = function (response) {
        $scope.loading = false;
        if (response.data.Status) {
            $scope.hasError = false;
            $scope.searchResult = response.data;
        }
        else {
            $scope.hasError = true;
            $scope.errorMessage = "No Records found...!!!";
            $scope.searchResult = {};
        }
    };

    OnError = function (response) {
        $scope.hasError = true;
        $scope.errorMessage = "Error in Service";
    };

    $scope.loading = true;
    productService.get().then(OnSuccess, OnError);

    $scope.getProductByName = function () {
        $scope.loading = true;
        var searchItem = $scope.searchItem;
        productService.GetByName(searchItem).then(OnSuccess, OnError);
    };
});
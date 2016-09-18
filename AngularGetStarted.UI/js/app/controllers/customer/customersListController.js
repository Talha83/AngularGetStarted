(function () {
    "use strict";

    // Getting the module
    angular.module("customers")
    .controller("customersListController", customersListController);

    function customersListController($scope, $http) {
        var vm = this;
        vm.customers = [];
        vm.pagedCustomers = [];
        vm.sortType = "FirstName";
        vm.sortReverse = false;

        vm.currentPage = 0;
        vm.numPerPage = 10;
        vm.maxSize = 5;

        $http.get("/api/customers/getCustomers")
        .then(function (response) {
            angular.copy(response.data, vm.customers);
            vm.count = vm.customers.length;
            vm.currentPage = 1
        }, function () {
            alert('error');
        });

        vm.sortData = function (sortBy) {
            vm.currentPage = 1;
            if (vm.sortType == sortBy)
            {
                vm.sortReverse = !vm.sortReverse;
            }
            else
            {
                vm.sortType = sortBy;
                vm.sortReverse = false;
            }
        };

        $scope.$watch('vm.currentPage + vm.numPerPage', function () {
            debugger;
            var begin = ((vm.currentPage - 1) * vm.numPerPage)
            , end = begin + vm.numPerPage;

            vm.pagedCustomers = vm.customers.slice(begin, end);
        });

    }
})();

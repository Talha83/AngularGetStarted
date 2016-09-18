(function () {
    "use strict";

    // Getting the module
    angular.module("customers")
    .controller("editcustomerController", editcustomerController);

    function editcustomerController($routeParams, $http) {
        var vm = this;
        vm.customer = {};

        vm.customerId = $routeParams.customerId;

        $http.get("/api/customers/getCustomer/" + vm.customerId)
        .then(function (response) {
            //angular.copy(response.data, vm.customer);
            vm.customer = response.data;
            debugger;
        }, function () {
            alert('error');
        });

        vm.UpdateCustomer = function()
        {
            $http.put("/api/customers/updateCustomer", vm.customer)
            .then(function (response) {
                vm.customer = response.data;
            }), function () {
                alert(error);
            };
        }
    }
})();

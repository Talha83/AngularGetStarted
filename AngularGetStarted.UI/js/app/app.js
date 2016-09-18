(function () {
    "use strict";

    // Creating the module
    angular.module("customers", ["ngRoute",
        "common.services", "ui.bootstrap"])
    .config(function ($routeProvider) {
        $routeProvider.when("/", {
            controller: "customersListController",
            controllerAs: "vm",
            templateUrl: "/uiviews/customer/customersView.html"
        });

        $routeProvider.when("/editCustomer/:customerId", {
            controller: "editcustomerController",
            controllerAs: "vm",
            templateUrl: "/uiviews/customer/editCustomerView.html"
        });

        $routeProvider.otherwise({ redirectTo: "/" });
    });
})();
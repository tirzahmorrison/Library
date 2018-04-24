angular.module('Library', ['ui.bootstrap'])
    .controller("mainController", ["$scope", "$http", ($scope, $http) => {
        $scope.hideSearch = false
        $scope.getCheckedOut = () => {
            $http({
                method: "GET",
                url: window.location.origin + `/admin/checkedout`
            }).then(response => {
                $scope.bookData = response.data
                $scope.books = []
                $scope.checkOutList = []
            })
        }
        $scope.search = () => {
            $http({
                method: "GET",
                url: window.location.origin + `/library/search?query=${$scope.query}&field=${$scope.field}`
            }).then(response => {
                $scope.books = response.data 
                $scope.bookData = []
                $scope.checkOutList = []
            })
        }
        $scope.checkOut = (ID) => {
            $http({
                method: "POST",
                url: window.location.origin + `/library/checkout/${ID}?email=${$scope.email}`
            })
        }
        $scope.checkIn = (ID) => {
            $http({
                method: "POST",
                url: window.location.origin + `/library/checkin/${ID}`
            })
        }
        $scope.getReaderCheckedOutItems = () => {
            $http({
                method: "GET",
                url: window.location.origin + `/library/itemsout?email=${$scope.email}`
            })
                .then(response => {
                    $scope.checkOutList = response.data
                    $scope.books = []
                    $scope.bookData = []
                })
        }
    } ])

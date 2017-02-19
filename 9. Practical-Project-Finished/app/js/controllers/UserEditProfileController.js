'use strict';

app.controller('UserEditProfileController',
    function ($scope, $rootScope, $location, townsService, authService, notifyService) {
        $rootScope.pageTitle = "Edit Profile";

        $scope.towns = townsService.getTowns();

        $scope.getUserProfile = function() {
            authService.getUserProfile(
                function success(data) {
                    $scope.userData = data;
                },
                function error(err) {
                    notifyService.showError("Cannot load user data", err);
                }
            );
        };

        $scope.getUserProfile();

        $scope.updateProfile = function(userData) {
            authService.editUser(userData,
                function success() {
                    notifyService.showInfo("User edited successfully");
                    $location.path("/");
                },
                function error(err) {
                    notifyService.showError("User edit failed", err);
                }
            );
        };

        $scope.changePassword = function(passData) {
            authService.changePass(passData,
                function success() {
                    notifyService.showInfo("Password changed successfully");
                    $location.path("/");
                },
                function error(err) {
                    notifyService.showError("Password change failed", err);
                }
            );
        };
    }
);

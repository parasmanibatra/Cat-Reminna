<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestService.aspx.cs" Inherits="WebRemina.TestService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html ng-app>
<head>
    <title>Hello AngularJS</title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.8/angular.min.js"></script>
    <script>
        function Hello($scope, $http) {
            $http.get('http://localhost:8089/WebService/GetUsers').
        success(function (data) {
            $scope.users = data;
        });
        }
    </script>
</head>
<body>
    <div ng-controller="Hello">
        <p ng-repeat="user in users">
            The User is {{user}}  <br />
        </p>
    </div>
    </form>
</body>
</html>

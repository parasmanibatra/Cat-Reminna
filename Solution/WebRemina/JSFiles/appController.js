app.controller("LoginController", function ($scope, $http) {
 var serviceurl = 'http://localhost:8089/WebService/Authenticate'
    $scope.Authenticate = function () {
        var uname = $scope.name.text;
        var pwd = $scope.password.text;
        $http({
            method: "GET",
            url: serviceurl + '/' + uname + '/' + pwd
        }).success(function (data) {
            if (data == 'true') {
                //  alert("Hi Paras!");
                $scope.User = 'Hi User!!Site is under construction';
            }
            else {
                alert("Invalid loginname or password!!");
                $scope.User = 'Please register before login'
            }
        }).error(function () {
            alert("Ooops..Something went wrong!!");
        })
    }
});
var app = angular.module("myApp", []);
app.controller("myCtrl", function ($scope, $http) {
  $http
    .get("https://localhost:7131/api/Slide/GetAllSlide")
    .then(function (response) {
      $scope.slide = response.data;
    });
  $http
    .get("https://localhost:7131/api/Product/SanPhamBanChay")
    .then(function (response) {
      $scope.productbestorder = response.data;
    });
  $http
    .get("https://localhost:7131/api/Product/SanPhamMoiVe")
    .then(function (response) {
      $scope.productnew = response.data;
      console.log(response.data);
    });
  $http
    .get("https://localhost:7131/api/Product/SanPhamGiamGia")
    .then(function (response) {
      $scope.productsale = response.data;
      console.log(response.data);
    });
  $http
    .get("https://localhost:7131/api/Product/GetProductByViewCount")
    .then(function (response) {
      $scope.productviewcount = response.data;
      console.log(response.data);
    });
  $http
    .get("https://localhost:7131/api/Category/GetAllCategory")
    .then(function (response) {
      $scope.loai = response.data;
      console.log(response.data);
    });
});

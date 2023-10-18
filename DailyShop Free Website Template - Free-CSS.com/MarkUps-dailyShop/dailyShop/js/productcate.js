var app = angular.module("myApp", []);
app.controller("myCtrl", function ($scope, $http) {
  const urlParams = new URLSearchParams(window.location.search);
  const id = urlParams.get("id");
  console.log("detail/id/" + id);
  $http
    .get("https://localhost:7131/api/Category/GetAllCategory")
    .then(function (response) {
      $scope.allcate = response.data;
      console.log(response.data);
    });
  $http
    .get("https://localhost:7131/api/Category/GetProductByCategory/" + id)
    .then(function (response) {
      $scope.productbycate = response.data;
      console.log(response.data);
    });
  $scope.SearchProduct = function () {
    if (!$scope.search) {
      // Nếu ô input rỗng
      $http
        .get("https://localhost:7131/api/Category/GetProductByCategory/" + id)
        .then(function (response) {
          $scope.productbycate = response.data;
          console.log(response.data);
        });
    } else {
      // Nếu ô input không rỗng
      $http
        .get(
          "https://localhost:7131/api/Product/TimKiemSanPham/" + $scope.search
        )
        .then(function (response) {
          $scope.productbycate = response.data;
          console.log(response.data);
        });
    }
  };
  $scope.searchProductsAsc = function () {
    var url =
      "https://localhost:7131/api/Product/TimKiemSanPhamTuThapLenCao/" + id;
    console.log(url);
    $http.get(url).then(function (response) {
      $scope.ProductByCateID = response.data;
    });
  };
  $scope.searchProductsDesc = function () {
    var url =
      "https://localhost:7131/api/Product/TimKiemSanPhamGiaTuCaoXuongThap/" +
      id;
    console.log(url);
    $http.get(url).then(function (response) {
      $scope.ProductByCateID = response.data;
    });
  };
  $scope.searchProductss = function () {
    if ($scope.sortOrder === "option2") {
      $scope.searchProductsAsc();
    } else if ($scope.sortOrder === "option1") {
      $scope.searchProductsDesc();
    } else if ($scope.sortOrder === "title") {
      $scope.searchProductsByTitleAsc();
    } else if ($scope.sortOrder === "-title") {
      $scope.searchProductsByTitleDesc();
    } else {
      // Xử lý cho các giá trị sortOrder khác nếu cần
    }
  };
});

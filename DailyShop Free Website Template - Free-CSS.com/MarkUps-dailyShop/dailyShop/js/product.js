var app = angular.module("myApp", []);
app.controller("myCtrl", function ($scope, $http, $window) {
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
    .get("https://localhost:7131/api/Product/GetSanPhamByID/" + id)
    .then(function (response) {
      $scope.productbyId = response.data;
      console.log(response.data);
    });
  $scope.addToCart = function (product) {
    var cartItems = $window.localStorage.getItem("cartItems");
    if (!cartItems) {
      cartItems = [];
    } else {
      cartItems = JSON.parse(cartItems);
    }
    var index = cartItems.findIndex(
      (item) => item.sanphamid === product.sanphamid
    );
    if (index === -1) {
      product.soLuong = 1;
      cartItems.push(product);
    } else {
      cartItems[index].soLuong += 1;
    }
    alert("Thêm sản phẩm vào giỏ hàng thành công");
    $window.localStorage.setItem("cartItems", JSON.stringify(cartItems));
  };
});

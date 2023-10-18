var app = angular.module("myApp", []);
app.controller("myCtrl", function ($scope, $http) {
  $scope.createOrder = function () {
    // Tạo đối tượng khách hàng từ dữ liệu trong form
    var customer = {
      customerid: 0,
      customername: $scope.customername,
      customerphone: $scope.customerphone,
      customeremail: $scope.customeremail,
      customeraddress: $scope.customeraddress,
      orderstatusid: 1,
    };

    // Lấy thông tin giỏ hàng từ local storage
    var cartItems = JSON.parse(localStorage.getItem("cartItems"));

    // Tạo một mảng chứa các sản phẩm trong giỏ hàng
    var orderDetails = [];

    for (var i = 0; i < cartItems.length; i++) {
      var orderDetail = {
        sanphamid: cartItems[i].sanphamid,
        quantity: cartItems[i].soLuong,
        price: cartItems[i].price,
      };

      orderDetails.push(orderDetail);
    }

    // Gửi dữ liệu đơn hàng đến API
    var data = {
      khach: customer,
      listchitiet: orderDetails,
    };

    $http
      .post("https://localhost:7131/api/Order/CreateOrder", data)
      .then(function (response) {
        // Xử lý kết quả trả về nếu cần
        console.log(response);
        localStorage.removeItem("cartItems");
        alert("Thêm đơn hàng thành công");
      })
      .catch(function (error) {
        // Xử lý lỗi nếu có
        console.log(error);
        alert("Lỗi");
      });
  };
});

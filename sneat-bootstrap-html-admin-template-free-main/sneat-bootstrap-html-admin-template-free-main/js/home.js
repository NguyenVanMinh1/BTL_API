var app = angular.module("myApp", []);
app.controller("myCtrl", function ($scope, $http) {
  $http
    .get("https://localhost:7097/api/ProductManage/GetAllProduct")
    .then(function (response) {
      $scope.getallProduct = response.data;
    });
  $http.get("https://localhost:7097/api/Brand/GetAllBrands").then(
    function (response) {
      // Xử lý dữ liệu trả về tại đây nếu cần
      $scope.nhacungcap = response.data;
      console.log($scope.nhacungcap);
    },
    function (error) {
      // Xử lý lỗi tại đây nếu cần
      console.log(error);
    }
  );
  // Get All Danh Mục
  $http.get("https://localhost:7097/api/Category/GetAllCategory").then(
    function (response) {
      $scope.category = response.data;
      console.log($scope.category);
    },
    function (error) {
      console.log(error);
    }
  );
  $scope.addProduct = function () {
    const data = {
        sanphamid: 0,
        producname: $scope.productname,
        loaiid: $scope.CategoryID_Create,
        price: $scope.productprice,
        imagesanpham: "",
        tenchatlieu: $scope.productpin,
        createdate: "2023-04-24T02:55:09.805Z",
        nhanhieuid: 1,
        soluong: $scope.ok,
        ghiChu: $scope.textmota,
        loainame: "string",
        nhanhieuname: "string",
        viewCount:100
      
    };

    const fileInput = document.querySelector("#product-image");
    const file = fileInput.files[0];

    if (!file) {
      return;
    }

    const formData = new FormData();
    formData.append("file", file);

    // Gọi API để upload ảnh và lấy đường dẫn trả về
    $http({
      method: "POST",
      url: "https://localhost:7097/api/UpLoadFile/upload/product",
      headers: {
        "Content-Type": undefined,
      },
      transformRequest: angular.identity,
      data: formData,
    })
      .then(function (response) {
        // Thêm đường dẫn ảnh vào thông tin sản phẩm
        data.imagesanpham = "https://localhost:7097" + response.data.filePath;

        // Gọi API để thêm sản phẩm mới
        $http({
          method: "POST",
          url: "https://localhost:7097/api/ProductManage/AddSanPham",
          data: data,
        })
          .then(function (response) {
            alert("Thêm sản phẩm thành công");
            console.log("Thêm sản phẩm thành công!");
            $http.get("https://localhost:7097/api/ProductManage/GetAllProduct").then(
              function (response) {
                // Xử lý dữ liệu trả về tại đây nếu cần
                $scope.getallProduct = response.data;
              },
              function (error) {
                // Xử lý lỗi tại đây nếu cần
                console.log(error);
              }
            );
          })
          .catch(function (error) {
            console.log(error);
          });
      })
      .catch(function (error) {
        console.log(error);
      });
  };
  $scope.deleteProduct = function (id) {
    var confirmDelete = confirm("Bạn có chắc muốn xóa sản phẩm này không?");
    if (confirmDelete) {
      $http
        .delete("https://localhost:7097/api/ProductManage/DeleteProduct/" + id)
        .then(
          function (response) {
            $http.get("https://localhost:7097/api/ProductManage/GetAllProduct").then(
              function (response) {
                $scope.getallProduct = response.data;
                alert("Xóa sản phẩm thành công");
                
              },
              function (error) {
                console.log(error);
              }
            );
          },
          function (error) {
            console.log(error);
          }
        );
    }
  };
  $scope.getProductByID = function (id) {
    $http.get("https://localhost:7097/api/ProductManage/GetProductById/" + id).then(
      function (response) {
        $scope.ProductByID = response.data;
        console.log(response.data);
      },
      function (error) {
        console.log(error);
      }
    );
  };
  $scope.updateProduct = function () {
    const data = {
        sanphamid: $scope.ProductByID.sanphamid,
        producname: $scope.ProductByID.producname,
        loaiid: $scope.ProductByID.loaiid,
        price: $scope.ProductByID.price,
        imagesanpham: "",
      tenchatlieu: $scope.ProductByID.tenchatlieu,
      createdate: "2023-04-24T02:55:09.805Z",
      nhanhieuid: 1,
      loainame: "string",
      nhanhieuname: "string",
      viewCount: 150,
      ghiChu: $scope.ProductByID.ghiChu,
     
    };

    const fileInput = document.querySelector("#product-images");
    const file = fileInput.files[0];

    if (!file) {
      alert("Vui lòng chọn hình ảnh sản phẩm.");
      return;
    }

    const formData = new FormData();
    formData.append("file", file);

    // Gọi API để upload ảnh và lấy đường dẫn trả về
    $http({
      method: "POST",
      url: "https://localhost:7097/api/UpLoadFile/upload/product",
      headers: {
        "Content-Type": undefined,
      },
      transformRequest: angular.identity,
      data: formData,
    }).then(function (response) {
      // Thêm đường dẫn ảnh vào thông tin sản phẩm
      data.imagesanpham = "https://localhost:7097" + response.data.filePath;

      $http.post("https://localhost:7097/api/ProductManage/UpdateSanPham", data).then(
        function (response) {
          // handle success
          alert("Sửa sản phẩm thành công");
          console.log(response);

          $http
            .get("https://localhost:7097/api/ProductManage/GetAllProduct")
            .then(function (response) {
              $scope.getallProduct = response.data;
              console.log(response.data);
            });
          // do something after update successfully
        },
        function (response) {
          // handle error
          console.log(response);
          alert("Lỗi");
          // do something when update failed
        }
      );
    });
  };
  $scope.addDanhmuc = function () {
    const data = {
      loaiid: 0,
      loainame: $scope.productdanhmuc,
      priority:1
    };

    $http({
      method: "POST",
      url: "https://localhost:7097/api/Category/AddCategory",
      data: JSON.stringify(data),
      headers: {
        "Content-Type": "application/json",
      },
    }).then(
      function successCallback(response) {
        alert("Thêm danh mục thành công");
        console.log(response.data);
        $http.get("https://localhost:7097/api/Category/GetAllCategory").then(
          function (response) {
            $scope.category = response.data;
            console.log($scope.category);
          },
          function (error) {
            console.log(error);
          }
        );
      },
      function errorCallback(response) {
        // Xử lý khi thêm danh mục thất bại
        console.log(response.data);
      }
    );
  };
  // delete danh mục
  $scope.deleteDanhMuc = function (id) {
    var confirmDelete = confirm("Bạn có chắc muốn xóa danh mục này không?");
    if (confirmDelete) {
      $http
        .delete("https://localhost:7097/api/Category/DeleteCategory/" + id)
        .then(
          function (response) {
            $http.get("https://localhost:7097/api/Category/GetAllCategory").then(
              function (response) {
                $scope.category = response.data;
                alert("Xóa danh mục thành công");
              },
              function (error) {
                console.log(error);
              }
            );
          },
          function (error) {
            console.log(error);
          }
        );
    }
  };
  $scope.textinputsearch = "";
  $scope.SearchProduct = function () {
    if ($scope.textinputsearch == "") {
      $http.get("https://localhost:7097/api/ProductManage/GetAllProduct").then(
        function (response) {
          // Xử lý dữ liệu trả về tại đây nếu cần
          $scope.getallProduct = response.data;
          console.log($scope.product);
        },
        function (error) {
          // Xử lý lỗi tại đây nếu cần
          console.log(error);
        }
      );
    }
    $http
      .get(
        "https://localhost:7097/api/ProductManage/GetProductByName/" +
          $scope.textinputsearch
      )
      .then(
        function (response) {
          $scope.getallProduct = response.data;
          console.log(response.data);
        },
        function (error) {
          console.log(error);
        }
      );
  };
});

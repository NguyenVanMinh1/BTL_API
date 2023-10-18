/**
 * Quản lý - Account
 */

'use strict';

document.addEventListener('DOMContentLoaded', function (e) {
  (function () {
    const deactivateAcc = document.querySelector('#formAccountDeactivation');

    // Update/reset user image of Account page
    let AccountUserImage = document.getElementById('uploadedAvatar');
    const fileInput = document.querySelector('.Account-file-input'),
      resetFileInput = document.querySelector('.Account-image-reset');

    if (AccountUserImage) {
      const resetImage = AccountUserImage.src;
      fileInput.onchange = () => {
        if (fileInput.files[0]) {
          AccountUserImage.src = window.URL.createObjectURL(fileInput.files[0]);
        }
      };
      resetFileInput.onclick = () => {
        fileInput.value = '';
        AccountUserImage.src = resetImage;
      };
    }
  })();
});

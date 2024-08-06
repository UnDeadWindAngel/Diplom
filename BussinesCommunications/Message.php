<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Моя программа</title>
    <base href="index.php">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <link href="carousel.css" rel="stylesheet">
    <link href="main.css" rel="stylesheet">
    <link href="ForDroper.css" rel="stylesheet">
  </head>
  <body style="background-color: #ffffff;" class="px-0 py-0">
    <main class="px-0 py-0 g-0">
        <?php
        include "source/blocks/Header.php";
        include "source/php/UserInfo.php";
        ?>
        <div class="container-fluid body col-lg-1 g-0"></div>
        <div class="container-fluid body col-lg-10 g-0">
            <div id="uploadFile_Loader" class="upload-zone">
                <form class="form-upload" id="uploadForm" method="post" action="source/php/Upload.php" enctype="multipart/form-data">
                    <div class="upload-zone_dragover" style="border-color:#000000;">
                       <svg xmlns="http://www.w3.org/2000/svg" fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="1" viewBox="0 0 24 24" class="upload-loader__image" style="color:#000000;">
                          <path d="M4 14.899A7 7 0 1 1 15.71 8h1.79a4.5 4.5 0 0 1 2.5 8.242M12 12v9"/>
                          <path d="m16 16-4-4-4 4"/>
                       </svg>
                       <p class="Myp">Перетащи файл сюда</p>
                       <span class="form-upload__hint" style="color:#000000;" id="hint">Можно загружать только Word файлы</span>
                    </div>
                    <label class="form-upload__label" for="uploadForm_file">
                       <span class="form-upload__title">Или нажми кнопку</span>
                       <input class="form-upload__input" id="uploadForm_File" type="file" name="file_name[]" aria-describedby="hint">
                       <input class="form-upload__input" id="uploadFile" type="submit" name="fileup"  style="background-color:#00aeff; border-color:#00aeff;">
                    </label>
                    <div class="form-upload__container">
                       <span class="form-upload__hint" id="uploadForm_Hint"></span>
                    </div>
                </form>
            </div>
        </div>
        <div class="container-fluid body col-lg-1 g-0"></div>
       <?php
       include 'source/blocks/Footer.php';
       ?>
    </main>
      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
      <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" integrity="sha384-BBtl+eGJRgqQAUMxJ7pMwbEyER4l1g+O15P+16Ep7Q9Q+zqX6gSbd85u4mG4QzX+" crossorigin="anonymous"></script>
      <script src="source/js/ForDroper.js" ></script>
   </body>
</html>
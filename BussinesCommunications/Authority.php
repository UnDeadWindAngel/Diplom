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
  </head>
  <body style="background-color: #ffffff;" class="px-0 py-0">
  <?php 
  $rand=rand(999999,100000);
  ?>
    <main class="px-0 py-0 g-0">
      <?php
      include "source/blocks/Header.php";
      ?>
      <style>  
      .captcha{
        width: 50%;
        background: yellow;
        text-align: center;
        font-size: 24px;
        font-weight: 700;
      }
      </style>
      <div class="container-fluid body col-lg-12 g-0">
        <div class="row g-0 px-0 py-0">
            <div class="col-4">
            </div>
            <div class="col-4">
                <form action="source/php/Auth.php" method="post">
                    <div class="mb-3">
                        <label for="login" class="form-label" style="color: #5e5b5b;">Логин</label>
                        <input type="text" name="login2" class="form-control" id="login" aria-describedby="emailHelp" required>
                    </div>
                    <div class="mb-3">
                        <label for="password" class="form-label" style="color: #5e5b5b;">Пароль</label>
                        <input type="password" name="password" class="form-control" id="password" required>
                    </div>
                    <div class="row col-md-12">
                      <div class="col-md-6 mb-3">
                        <label for="captcha" style="color: #5e5b5b;">Я не робот, а ты?</label>
                        <input type="text" name="captcha" id="captcha" placeholder="Введите число" required data-parsley-trigger="keyup" class="form-control" />
                        <input type="hidden" name="captcha-rand" value="<?php echo $rand;?>"/>
                      </div>
                      <div class="col-md-6 mb-3">
                        <label for="captcha-code" style="color: #5e5b5b;">Код</label>
                        <div class="captcha">
                          <?php print_r($rand); ?>
                        </div>
                      </div>
                    </div>
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal" style="color:#ffffff; background-color: #00aeff; border-color: #00aeff;">Закрыть</button>
                    <button type="submit" class="btn btn-primary" style="color:#ffffff; background-color: #00aeff; border-color: #00aeff;">Авторизоваться</button>
                </form>
            </div>
            <div class="col-4">
            </div>
        </div>
      </div>
      <?php
      include 'source/blocks/Footer.php';
      ?>
    </main>
      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
      <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" integrity="sha384-BBtl+eGJRgqQAUMxJ7pMwbEyER4l1g+O15P+16Ep7Q9Q+zqX6gSbd85u4mG4QzX+" crossorigin="anonymous"></script>
  </body>
</html>
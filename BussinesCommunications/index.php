<?php
    if(!isset($_COOKIE["login"])){
    include 'source/php/Session.php';}
?>
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
    <main class="px-0 py-0 g-0">
      <?php
      include 'source/blocks/Header.php';
      ?>
      <div class="container-fluid body col-lg-12 g-0">
      <?php
      include 'source/blocks/MainSlider.php';
      ?>
        <div class="row g-0 px-0 py-0">
          <div class="col-6" style="border-right: 1px dotted white;">
            <h1 style="text-align:center;">Новости</h1>
            <div class="row g-0 px-0 py-0">
              <h2 style="text-align:center;">Сегодня мы выполнили 1000+ заказов</h2>
              <p class="Myp">Сегодня наш оператор Василий, из Филиала в Кемеровской области выполнил заказ под номером 1235321, этот заказ стал для всего филлиала 1001. Так держать, мы продолжаем быть на страже нашего региона!</p>
            </div>
          </div>
          <div class="col-6">
            <h1  style="text-align:center;">Достижения нашей кампании</h1>
            <div class="row g-0 px-0 py-0">
              <h2 style="text-align:center;">Сегодня мы выполнили 1000+ заказов</h2>
              <p class="Myp">Поздравляем с этим достижением наш филиал в городе Кемерово. Ребята молодцы смогли сделать это и поднять рабочую планку на новый уровень!</p>
            </div> 
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
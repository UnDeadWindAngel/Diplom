<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Моя программа</title>
    <base href="index.php">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
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
          <div class="col-12">
            <h1 style="text-align:center; color:#5e5b5b;">Новости</h1>
            <div class="row g-0 px-0 py-0">
              <h2 style="text-align:center;">Сегодня мы выполнили 1000+ заказов</h2>
              <p class="Myp">Сегодня наш оператор Василий, из Филиала в Кемеровской области выполнил заказ под номером 1235321, этот заказ стал для всего филлиала 1001. Так держать, мы продолжаем быть на страже нашего региона!</p>
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
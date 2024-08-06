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
      include "source/blocks/Header.php";
      include "source/php/UserInfo.php";
      ?>
      <div class="container-fluid body col-lg-12 g-0">
        <div class="row g-0 px-0 py-0">
          <div class="container-fluid body col-lg-6 g-0">
            <div class="card" style="background-color: #ffffff; border: 1px solid white;">
              <div class="card-header" style="margin-left: auto; margin-right: auto;">
                  <h3>Профиль</h3>
              </div>
              <div class="card-body" style="margin-left: auto; margin-right: auto;">
                <div class="container-fluid body col-lg-12 g-0">
                  <?php
                      if(!isset($_SESSION['Avatar']))
                          echo("<img src=\"/source img/ThisIsYourPhoto.jpg\" class=\"img-fluid rounded-circle mb-3 Photo\" alt=\"аватар пользователя\">");
                      else
                          echo("<img src=\"".$_SESSION['Avatar']."\" class=\"img-fluid rounded-circle mb-3 Photo\" alt=\"аватар пользователя\">");
                  ?>
                  <h5>Логин : <?php echo($_SESSION['login']); ?> </h5>
                  <h5>ФИО : <?php echo($_SESSION['FirstName']." ".mb_substr($_SESSION['SecondName'],0,1,'UTF-8').". ".mb_substr($_SESSION['ThirdName'],0,1,'UTF-8')."."); ?> </h5>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="container-fluid col-lg-12 g-0">
        <div class="container-fluid col-lg-1 g-0">
        </div>
        <div class="container-fluid col-lg-10 g-0">
          <div class="row">
            <table class="table table-hover" id="tableEmp">
              <thead>
                <tr id="tabl0">
                  <th scope="col">№</th>
                  <th scope="col">Название</th>
                  <th scope="col">От кого</th>
                  <th scope="col">Кто подписал</th>
                  <th scope="col">Дата отправки</th>
                  <th scope="col">Дата подписания</th>
                  <th scope="col">Статус</th>
                  <th scope="col">Причина отказа</th>
                </tr>
              </thead>
              <tbody>
                <?php
                include "source\php\ReportWiev.php";
                ?>
              </tbody>
            </table>
            <style type="text/css">
              .table {
                border-collapse: collapse;
                border-spacing: 0;
                width: 100%;
              }
              .table th, .table td {
                border: 1px solid #888;
                padding: 10px;
                text-align: center;
                vertical-align: middle;
                position: relative;
                cursor: pointer;
              }
              
              /* Hover */
              .table .hover td:after {
                content: '';
                position: absolute;
                top: 0px;
                right: 0px;    
                bottom: 0px;    
                left: 0px;
                width: 105%;
                border-top: 3px solid #a8d8ea;
                border-bottom: 3px solid #a8d8ea;
              }
              .table .hover td:first-child:after {
                border-left: 3px solid #a8d8ea;
              }
              .table .hover td:last-child:after {
                border-right: 3px solid #a8d8ea;
                width: auto;
              }
              
              /* Click */
              .table .active td:after {
                content: '';
                position: absolute;
                top: 0px;
                right: 0px;    
                bottom: 0px;    
                left: 0px;
                width: 105%;
                border-top: 3px solid #a8d8ea;
                border-bottom: 3px solid  #a8d8ea;
              }
              .table .active td:first-child:after {
                border-left: 3px solid  #a8d8ea;
              }
              .table .active td:last-child:after {
                border-right: 3px solid  #a8d8ea;
                width: auto;
              }
              </style>
          </div>
        </div>
        <div class="container-fluid col-lg-1 g-0">
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
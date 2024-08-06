
      <div class="container-fluid header col-12 g-0 px-0 py-0" style="background-color:#ffffff;">
        <div class="row g-0">
          <nav class="navbar navbar-expand navbar-light">
            <div class="container-fluid">
              <a class="navbar-brand" href="" style="color: #000000;" >Документооборот РТК</a>
              <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
              </button>
              <div class="container-fluid collapse navbar-collapse col-10" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-0 col-10">
                  <li class="nav-item"><a class="nav-link" href="" style="color: #00aeff;">Главная</a></li>
                  <li class="nav-item"><a class="nav-link" href="/News.php" style="color: #00aeff;">Новости кампании</a></li>
                  <li class="nav-item"><a class="nav-link" href="/NextGen.php" style="color: #00aeff;">Будущие проекты</a></li>
                  <li class="nav-item"><a class="nav-link" href="/OurWorking.php" style="color: #00aeff;">Как мы работаем</a></li>
                  <li class="nav-item"><a class="nav-link" href="/Our.php" style="color: #00aeff;">О нас</a></li>
                  <?php if(!isset($_COOKIE["login"])) {echo"<li class=\"nav-item\"><a class=\"nav-link\" href=\"/Authority.php\" style=\"color: #00aeff;\">Авторизация</a></li>";} 
                  else if($_COOKIE["login"]=="guest"){echo"<li class=\"nav-item\"><a class=\"nav-link\" href=\"/Authority.php\" style=\"color: #00aeff;\">Авторизация</a></li>";}?>
                  <?php if(isset($_COOKIE["login"])){if($_COOKIE["login"]!="guest") {echo"<li class=\"nav-item\"><a class=\"nav-link\" href=\"/UserPage.php\" style=\"color: #00aeff;\">Страница пользователя</a></li>";}} ?>
                  <?php if(isset($_COOKIE["login"])){if($_COOKIE["login"]!="guest") {echo"<li class=\"nav-item\"><a class=\"nav-link\" href=\"/Message.php\" style=\"color: #00aeff;\">Сообщения</a></li>";}} ?>
                  <?php if(isset($_COOKIE["login"])){if($_COOKIE["login"]!="guest") {echo"<li class=\"nav-item\"><a class=\"nav-link\" href=\"/source/php/Exit.php\" style=\"color: #00aeff;\">Выход</a></li>";}} ?>
                </ul>
              </div>
            </div>
          </nav>
        </div>
      </div>
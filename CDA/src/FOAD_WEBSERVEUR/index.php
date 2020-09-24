<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body style=background-color:grey>
    <?php 
    require_once("personne.php");

    $personne1=new personne("truc", "bidule", "4845435", "zenznzng@fjjfhzeb");

    $personne1->setAdresse("newadresse");
    $personne1->setMAIL("newadresse@MAIL");

    echo $personne1->getPersonne();

    var_dump($personne1);
    

    ?>
</body>
</html>
<?php
/*
mysqli_connect() - Открыть новое соединение с MySQL сервером. Возвращает объект, представляющий подключение к серверу MySQL.

mysqli_connect_error() - Возвращает описание последней ошибки подключения. Сообщение об ошибке. NULL, если ошибка отсутствует.

mysqli_query() - Выполняет запрос к базе данных. Возвращает FALSE в случае неудачи. В случае успешного выполнения запросов SELECT mysqli_query() вернет объект mysqli_result. Для остальных успешных запросов mysqli_query() вернет TRUE.

mysqli_set_charset() - Устанавливает кодировку

mysqli_fetch_all() - Выбирает все строки из результирующего набора и помещает их в ассоциативный массив, обычный массив или в оба

mysqli_fetch_assoc() - Извлекает результирующий ряд в виде ассоциативного массива. Возвращает ассоциативный массив, соответствующий результирующей выборке или NULL, если других рядов не существует.

mysqli_num_rows() - Получает число рядов в результирующей выборке.

mysqli_affected_rows() - Получает число строк, затронутых предыдущей операцией MySQL. Возвращает число строк, затронутых последним INSERT, UPDATE, REPLACE или DELETE запросом. Целое число, большее нуля, означает количество затронутых или полученных строк. Ноль означает, что запросом вида UPDATE не обновлено ни одной записи, или что ни одна строка не соответствует условию WHERE в запросе, или что запрос еще не был выполнен. Значение -1 указывает на то, что запрос вернул ошибку.

mysqli_error() - Возвращает строку с описанием последней ошибки.
*/
    $db = mysqli_connect('127.0.0.1', 'root', '', 'l04_34pr11') or die('Ошибка соединения с БД.'.mysqli_connect_error($db));
    mysqli_set_charset($db, 'utf8') or die('Not encount wordcodding');
    
    /* $sql_ins = "INSERT INTO products (name, price, manufacturer)
            VALUES
            ('Conditioner', 20000, 'LG'),
            ('Socks', 7, 'Jitomyr')";

    $res_ins = mysqli_query($db, $sql_ins);
    if($res_ins)
    {
        echo "Added!!!!<br>";

    }
    else
    {
        echo "Error!";
        echo mysqli_error($db);
    } */

    /* $sql_upd = "UPDATE products SET price = 150 WHERE id = 6";
    $res_udp = mysqli_query($db, $sql_upd) or die('Error'); */

    /* $sql_del = "DELETE FROM products WHERE id = 6";
    $res_del = mysqli_query($db, $sql_del) or die('Error');

    echo "Number of rows affected ".mysqli_affected_rows($db)."<br>";
    echo "Connected!!"; */

    $res_select = mysqli_query($db, "SELECT * FROM products ORDER BY price DESC");

    //echo mysqli_num_rows($res_select);
    //$data = mysqli_fetch_all($res_select, MYSQLI_BOTH);
    /* echo "<pre>";
    print_r($data);
    echo '</pre>'; */

    /* foreach($data as $item){
        echo "id: {$item['id']} <br>";
        echo "name: {$item['name']} <br>";
        echo "price: {$item['price']} <br>";
        echo "<hr>";
    } */
    while ($row = mysqli_fetch_assoc($res_select)){
        echo "id: {$row['id']} <br>";
        echo "name: {$row['name']} <br>";
        echo "price: {$row['price']} <br>";
        echo "<hr>";
    }
?>
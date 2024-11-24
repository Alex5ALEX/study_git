USE autorent;


-- Предопределённые данные
SET @names = 'Alice,Bob,Charlie,David,Eve,Frank,Grace,Hannah,Ian,Jack';
SET @surnames = 'Smith,Johnson,Williams,Brown,Jones,Miller,Davis,García,Martínez,Rodriguez';
SET @addresses = '123 Main St,456 Maple Ave,789 Oak Dr,321 Pine St,654 Elm St,987 Cedar Blvd,135 Birch Rd,246 Willow Ct,369 Spruce St,159 Ash Ln';
SET @phones = '+1(555)1000-0000,+1(555)2000-0000,+1(555)3000-0000,+1(555)4000-0000,+1(555)5000-0000,+1(555)6000-0000,+1(555)7000-0000,+1(555)8000-0000,+1(555)9000-0000,+1(555)0000-0000';
SET @domain = '@example.com';

-- Заполнение таблицы 100 уникальными строками
DELIMITER //
CREATE PROCEDURE FillUsers()
BEGIN
    DECLARE v_counter INT DEFAULT 0;
    DECLARE v_name VARCHAR(50);
    DECLARE v_surname VARCHAR(50);
    DECLARE v_age INT;
    DECLARE v_phone VARCHAR(55);
    DECLARE v_email VARCHAR(100);
    DECLARE v_address VARCHAR(255);
    
    WHILE v_counter < 100 DO
        SET v_name = SUBSTRING_INDEX(SUBSTRING_INDEX(@names, ',', FLOOR(1 + RAND() * 10)), ',', -1);
        SET v_surname = SUBSTRING_INDEX(SUBSTRING_INDEX(@surnames, ',', FLOOR(1 + RAND() * 10)), ',', -1);
        SET v_age = FLOOR(18 + RAND() * 50); -- Возраст от 18 до 67
        SET v_phone = SUBSTRING_INDEX(SUBSTRING_INDEX(@phones, ',', FLOOR(1 + RAND() * 10)), ',', -1);
        SET v_email = CONCAT(LOWER(v_name), LOWER(v_surname), FLOOR(RAND() * 100), @domain); -- Уникальный email
        SET v_address = SUBSTRING_INDEX(SUBSTRING_INDEX(@addresses, ',', FLOOR(1 + RAND() * 10)), ',', -1);

        INSERT INTO autorent.client (Id, Name, Surname, Age, Phone, Email, Addres)
        VALUES (
            UUID(), -- Генерация уникального идентификатора
            v_name,
            v_surname,
            v_age,
            v_phone,
            v_email,
            v_address
        );

        SET v_counter = v_counter + 1;
    END WHILE;
END //
DELIMITER ;

-- Вызов процедуры для заполнения таблицы
CALL FillUsers();
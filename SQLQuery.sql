-- Tabulka produkty
CREATE TABLE products (
    produktID INT PRIMARY KEY,
    nazev VARCHAR(255),
    cena FLOAT
);

-- Tabulka zakaznici
CREATE TABLE customers (
    zakaznikID INT PRIMARY KEY,
    jmeno VARCHAR(100),
    email VARCHAR(255)
);

-- Tabulka objednavky
CREATE TABLE orders (
    objednavkaID INT PRIMARY KEY,
    zakaznikID INT,
    datumObjednani DATETIME,
    celkovaCena FLOAT,
    FOREIGN KEY (zakaznikID) REFERENCES customers(zakaznikID)
);

-- Tabulka detaily_objednavek
CREATE TABLE order_details (
    detailID INT PRIMARY KEY,
    objednavkaID INT,
    produktID INT,
    mnozstvi INT,
    FOREIGN KEY (objednavkaID) REFERENCES orders(objednavkaID),
    FOREIGN KEY (produktID) REFERENCES products(produktID)
);

-- Tabulka kategorie_produktu
CREATE TABLE product_categories (
    kategorieID INT PRIMARY KEY,
    nazevKategorie VARCHAR(255)
);

-- Tabulka pro vazbu M:N mezi produkty a kategoriemi
CREATE TABLE product_category_association (
    ID INT PRIMARY KEY,
    produktID INT,
    kategorieID INT,
    FOREIGN KEY (produktID) REFERENCES products(produktID),
    FOREIGN KEY (kategorieID) REFERENCES product_categories(kategorieID)
);






--Data do tabulek

INSERT INTO products (produktID, nazev, cena) VALUES
(1, 'Mobilni telefon', 299.99),
(2, 'Televize', 599.99),
(3, 'Notebook', 899.99),
(4, 'Sluchatka', 49.99),
(5, 'Chytre hodinky', 199.99),
(6, 'Gaming pocitac', 1499.99),
(7, 'Fitness narek', 79.99),
(8, 'Fotoaparat', 349.99),
(9, 'Wireless reproduktor', 129.99),
(10, 'Externi pevny disk', 79.99);

-- Zakaznici
INSERT INTO customers (zakaznikID, jmeno, email) VALUES
(1, 'Jan Novak', 'jan.novak@example.com'),
(2, 'Petra Svobodova', 'petra.svobodova@example.com'),
(3, 'Pavel Dvorak', 'pavel.dvorak@example.com'),
(4, 'Jana Novotna', 'jana.novotna@example.com'),
(5, 'Martin Prochazka', 'martin.prochazka@example.com'),
(6, 'Eva Novakova', 'eva.novakova@example.com'),
(7, 'Michal Novy', 'michal.novy@example.com'),
(8, 'Alena Kovarova', 'alena.kovarova@example.com'),
(9, 'Tomas Pospisil', 'tomas.pospisil@example.com'),
(10, 'Lucie Nova', 'lucie.nova@example.com');

-- Objednavky
INSERT INTO orders (objednavkaID, zakaznikID, datumObjednani, celkovaCena) VALUES
(1, 1, '2024-01-01 08:30:00', 399.99),
(2, 2, '2024-01-02 09:15:00', 155.99),
(3, 3, '2024-01-03 10:00:00', 179.99),
(4, 4, '2024-01-04 11:00:00', 99.99),
(5, 5, '2024-01-05 12:00:00', 199.99),
(6, 6, '2024-01-06 13:00:00', 649.99),
(7, 7, '2024-01-07 14:00:00', 129.99),
(8, 8, '2024-01-08 15:00:00', 399.99),
(9, 9, '2024-01-09 16:00:00', 249.99),
(10, 10, '2024-01-10 17:00:00', 149.99);

-- Detaily objednavek
INSERT INTO order_details (detailID, objednavkaID, produktID, mnozstvi) VALUES
(1, 1, 1, 1),
(2, 1, 2, 1),
(3, 2, 3, 2),
(4, 2, 4, 3),
(5, 3, 5, 1),
(6, 3, 6, 1),
(7, 4, 7, 2),
(8, 5, 8, 1),
(9, 6, 9, 2),
(10, 7, 10, 3);

-- Kategorie produktu
INSERT INTO product_categories (kategorieID, nazevKategorie) VALUES
(1, 'Elektronika'),
(2, 'Obleceni'),
(3, 'Kosmetika'),
(4, 'Domaci potreby'),
(5, 'Sportovni potreby');

-- Vazba M:N mezi produkty a kategoriemi
INSERT INTO product_category_association (ID, produktID, kategorieID) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 1),
(5, 5, 1),
(6, 6, 1),
(7, 7, 1),
(8, 8, 1),
(9, 9, 1),
(10, 10, 1);

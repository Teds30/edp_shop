
-- -----------------------------------------------------
-- Schema shop_orders
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `shop_orders`;
-- -----------------------------------------------------
-- Schema new_schema1
-- -----------------------------------------------------
USE `shop_orders` ;

-- -----------------------------------------------------
-- Table `shop_orders`.`employee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `shop_orders`.`employee` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));


-- -----------------------------------------------------
-- Table `shop_orders`.`customer`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `shop_orders`.`customer` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));


-- -----------------------------------------------------
-- Table `shop_orders`.`categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `shop_orders`.`categories` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));


-- -----------------------------------------------------
-- Table `shop_orders`.`products`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `shop_orders`.`products` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `price` FLOAT NULL,
  `stock` INT NULL,
  `category_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `category_idx` (`category_id` ASC) VISIBLE,
  CONSTRAINT `category`
    FOREIGN KEY (`category_id`)
    REFERENCES `shop_orders`.`categories` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `shop_orders`.`orders`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `shop_orders`.`orders` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `customer_id` INT NULL,
  `employee_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `customer_idx` (`customer_id` ASC) VISIBLE,
  INDEX `employee_idx` (`employee_id` ASC) VISIBLE,
  CONSTRAINT `customer`
    FOREIGN KEY (`customer_id`)
    REFERENCES `shop_orders`.`customer` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `employee`
    FOREIGN KEY (`employee_id`)
    REFERENCES `shop_orders`.`employee` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `shop_orders`.`order_lines`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `shop_orders`.`order_lines` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `order_id` INT NULL,
  `product_id` INT NULL,
  `quantity` FLOAT NULL,
  PRIMARY KEY (`id`),
  INDEX `order_idx` (`order_id` ASC) VISIBLE,
  INDEX `prod_idx` (`product_id` ASC) VISIBLE,
  CONSTRAINT `order`
    FOREIGN KEY (`order_id`)
    REFERENCES `shop_orders`.`orders` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `prod`
    FOREIGN KEY (`product_id`)
    REFERENCES `shop_orders`.`products` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- -----------------------------------------------------
-- Table `shop_orders`.`accounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `shop_orders`.`accounts` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(255) NULL,
  `password` VARCHAR(255) NULL,
  PRIMARY KEY (`id`));

INSERT INTO shop_orders.accounts (username, password) VALUES 
('a', md5('a'));
INSERT INTO shop_orders.categories (name) VALUES 
('cat1'),
('cat2'),
('cat3'),
('cat4'),
('cat5'),
('cat6'),
('cat7'),
('cat8'),
('cat9'),
('cat10');

INSERT INTO shop_orders.customer (name) VALUES 
('customer1'),
('customer2'),
('customer3'),
('customer4'),
('customer5'),
('customer6'),
('customer7'),
('customer8'),
('customer9'),
('customer10');

INSERT INTO shop_orders.employee (name) VALUES 
('employee1'),
('employee2'),
('employee3'),
('employee4'),
('employee5'),
('employee6'),
('employee7'),
('employee8'),
('employee9'),
('employee10');

INSERT INTO shop_orders.products (name, price, stock, category_id) VALUES 
('prod1', 500, 12, 1),
('prod2', 500, 14, 1),
('prod3', 500, 11, 1),
('prod4', 500, 1, 1),
('prod5', 500, 1, 1),
('prod6', 500, 1, 1),
('prod7', 500, 1, 1),
('prod8', 500, 1, 1),
('prod9', 500, 1, 1),
('prod10', 500, 1, 1);

INSERT INTO shop_orders.orders (customer_id, employee_id) VALUES 
(1, 1),
(1, 1),
(1, 1),
(4, 1),
(5, 1),
(6, 1),
(7, 1),
(8, 1),
(9, 1),
(10, 1);

INSERT INTO shop_orders.order_lines (order_id, product_id, quantity) VALUES 
(1, 1, 3),
(1, 1, 4),
(2, 3, 2),
(3, 4, 1),
(4, 5, 1),
(5, 6, 1),
(6, 7, 1),
(7, 8, 1),
(8, 9, 1),
(9, 10, 1);
(10, 10, 1);



CREATE OR REPLACE VIEW CustomerTotalOrders AS
  SELECT customer.id, customer.name, COUNT(orders.customer_id) as orders
  FROM customer
  INNER JOIN orders ON orders.customer_id = customer.id
  GROUP BY customer.id;


CREATE OR REPLACE VIEW ProductTotalSold AS
SELECT products.id, products.name, COUNT(order_lines.product_id) as sold
from products
inner join order_lines on products.id = order_lines.product_id
GROUP BY products.id;



CREATE OR REPLACE VIEW OrderLinesTotalCost AS
SELECT order_lines.id as order_line_id, orders.id as order_id, products.id as product_id, order_lines.quantity, (products.price * order_lines.quantity) as total_amount from order_lines
INNER JOIN products on products.id = order_lines.product_id
INNER JOIN orders on orders.id = order_lines.order_id;

DELIMITER //
DROP PROCEDURE IF EXISTS UpdateProductStock;
CREATE PROCEDURE UpdateProductStock (
  IN prod_id INT,
  IN quantity INT
)
BEGIN
  
  UPDATE products
  SET stock = stock - quantity
  WHERE id = prod_id;

END; //
DELIMITER ;

DROP FUNCTION IF EXISTS OrderCost;
DELIMITER //
CREATE FUNCTION OrderCost (
  _order_id INT
)
RETURNS DECIMAL(11, 2)
deterministic
BEGIN

  DECLARE total DECIMAL(11,2) DEFAULT 0;

  SELECT SUM(total_amount) into total FROM orderlinestotalcost WHERE order_id = _order_id;
  
  RETURN total;
END //
DELIMITER ;
CREATE DATABASE JewelleryShop;
GO

USE JewelleryShop;
GO

CREATE TABLE role (
    id INT IDENTITY(1,1) PRIMARY KEY,
    role_name NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    first_name NVARCHAR(100),
    last_name NVARCHAR(100),
    email NVARCHAR(255) UNIQUE,
    password NVARCHAR(255),
    phone NVARCHAR(20),
    address NVARCHAR(MAX),
    create_day_at DATETIME DEFAULT GETDATE(),
    status INT,
    role_id INT,
    FOREIGN KEY (role_id) REFERENCES role(id)
);
GO

CREATE TABLE discount (
    id INT IDENTITY(1,1) PRIMARY KEY,
    discount_name NVARCHAR(100),
    value DECIMAL(5,2),
    create_date_at DATETIME DEFAULT GETDATE(),
    end_date_at DATETIME,
    stock INT
);
GO

CREATE TABLE orders (
    id INT IDENTITY(1,1) PRIMARY KEY,
    stock INT,
    shipping_address NVARCHAR(MAX),
    status INT,
    order_date DATETIME DEFAULT GETDATE(),
    order_note NVARCHAR(MAX),
    discount_id INT,
    user_id INT,
    FOREIGN KEY (discount_id) REFERENCES discount(id),
    FOREIGN KEY (user_id) REFERENCES users(id)
);
GO

CREATE TABLE bill (
    id INT IDENTITY(1,1) PRIMARY KEY,
    create_date_at DATETIME DEFAULT GETDATE(),
    total_price DECIMAL(10,2),
    order_id INT,
    FOREIGN KEY (order_id) REFERENCES orders(id)
);
GO

CREATE TABLE payment (
    id INT IDENTITY(1,1) PRIMARY KEY,
    payment_method NVARCHAR(100),
    payment_status NVARCHAR(100),
    payment_date DATETIME,
    amount DECIMAL(10,2),
    bill_id INT,
    FOREIGN KEY (bill_id) REFERENCES bill(id)
);
GO

CREATE TABLE category_product (
    id INT IDENTITY(1,1) PRIMARY KEY,
    category_name NVARCHAR(100)
);
GO

CREATE TABLE material (
    id INT IDENTITY(1,1) PRIMARY KEY,
    material_name NVARCHAR(100)
);
GO

CREATE TABLE gemstone_type (
    id INT IDENTITY(1,1) PRIMARY KEY,
    stone_name NVARCHAR(100),
    description NVARCHAR(MAX)
);
GO

CREATE TABLE size (
    id INT IDENTITY(1,1) PRIMARY KEY,
    size_number NVARCHAR(20)
);
GO

CREATE TABLE products (
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_name NVARCHAR(255),
    stock INT,
    price DECIMAL(10,2),
    description NVARCHAR(MAX),
    image NVARCHAR(255),
    product_size_id INT,
    material_id INT,
    gemstone_type_id INT,
    category_id INT,
    FOREIGN KEY (material_id) REFERENCES material(id),
    FOREIGN KEY (gemstone_type_id) REFERENCES gemstone_type(id),
    FOREIGN KEY (category_id) REFERENCES category_product(id)
);
GO

CREATE TABLE product_size (
    id INT IDENTITY(1,1) PRIMARY KEY,
    price DECIMAL(10,2),
    stock INT,
    product_id INT,
    size_id INT,
    FOREIGN KEY (product_id) REFERENCES products(id),
    FOREIGN KEY (size_id) REFERENCES size(id)
);
GO

CREATE TABLE order_detail (
    id INT IDENTITY(1,1) PRIMARY KEY,
    quantity INT,
    price DECIMAL(10,2),
    order_id INT,
    product_id INT,
    FOREIGN KEY (order_id) REFERENCES orders(id),
    FOREIGN KEY (product_id) REFERENCES products(id)
);
GO

CREATE TABLE cart (
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_id INT,
    user_id INT,
    FOREIGN KEY (product_id) REFERENCES products(id),
    FOREIGN KEY (user_id) REFERENCES users(id)
);
GO

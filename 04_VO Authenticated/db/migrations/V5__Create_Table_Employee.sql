CREATE TABLE employee (
	id INT(5) NOT NULL AUTO_INCREMENT,
	username VARCHAR(50) NOT NULL DEFAULT '0',
	password VARCHAR(50) NOT NULL DEFAULT '0',
	fullname VARCHAR(500) NOT NULL,
	refresh_token VARCHAR(50) NOT NULL DEFAULT '0',
	refresh_token_expiry_time DATETIME NULL DEFAULT NULL,
	PRIMARY KEY (id),
	UNIQUE user_name (user_name)
)
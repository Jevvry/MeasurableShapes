/*
Считаю что существуют такие таблицы 

CREATE TABLE goods
(
    id_good int NOT NULL,
    good_name nchar(10) NULL,
    CONSTRAINT PK_id_good PRIMARY KEY (id_good)
    )

CREATE TABLE categories
(
	id_category int NOT NULL, 
	category_name nchar(10) NULL, 
    CONSTRAINT PK_id_category PRIMARY KEY (id_category) 
)

CREATE TABLE categoriesGoods
(
	id_category int NOT NULL,
    id_good int NOT NULL,
    CONSTRAINT PK_id_category PRIMARY KEY (id_category, id_good) 
)

ALTER TABLE categoriesGoods ADD 
	CONSTRAINT FK_id_category FOREIGN KEY (id_category) REFERENCES categories(id_category)
ALTER TABLE categoriesGoods ADD 
	CONSTRAINT FK_id_good FOREIGN KEY (id_good) REFERENCES goods(id_good)
*/
SELECT g.good_name, c.category_name
FROM goods AS g INNER JOIN 
    categoriesGoods AS cG on g.id_good = cG.id_good INNER JOIN
    categories AS c on cG.id_category = c.id_category

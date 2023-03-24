SELECT Products.name AS ProductName, categories.name AS CategoryName
FROM Categories_products
	FULL JOIN products
		ON Categories_products.product_id = Products.id
	LEFT JOIN Categories
		ON Categories_products.category_id = Categories.id
ORDER BY ProductName ASC
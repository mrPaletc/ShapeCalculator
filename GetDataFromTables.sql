select Product.name as  PrdouctName, Category.name as CategoryName 
from Product
left join CategoryProduct on Product.id = CategoryProduct.ProductID
left join Category on CategoryProduct.CategoryId = Category.id
select p.Name, c.Name 
from Products p left join ProductCategories pc on p.Id = pc.ProductId
				left join Categories c on c.Id = pc.CategoryId
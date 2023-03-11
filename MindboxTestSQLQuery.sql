use MindboxTestDB;

select distinct p.productName, c.categoryName as category
from Products as p
left join ProductsToCategories as ptc
on p.id = ptc.productID
left join Categories as c
on c.id = ptc.categoryID;

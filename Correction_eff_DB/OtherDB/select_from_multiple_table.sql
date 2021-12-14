use coffee_store;
select distinct coffee_origin from products;
select coffee_origin from products;
select*from customers limit 5 offset 5;

select products.name,orders.order_time from orders inner join products
on orders.products_id=products.id;


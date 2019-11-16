Nota:

Para acceder al JWT:
localhost:<port>/api/Token/[Valor]/[Contraseña]

Para acceder al CRUD de pizzas:
localhost:<port>/api/Pizzas/

Se espera un base de datos con el nombre: PizzaDB
y una colección con el nombre: Pizzas

(Puede modificarse esta información en "appsettings.json")

Ejemplo de formato de Json:
[{"id":"5dcf54d4d25420878d95f865","pizzaName":"Pepperoni Pizza","description":"A new pizza","ingredients":["Pepperoni","Cheese"],"dough":"Delicious","size":"Big","portions":1,"hasCheese":true}]
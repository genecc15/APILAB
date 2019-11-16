Nota:

Para generar el token en JWT:
localhost:<port>/api/Token/[Usuario]/[Contraseña]
  El usuario y contraseña deben ser iguales. 
  Ejemplo: https://localhost:44345/api/token/Genesis/Genesis

Para acceder a los valores del JWT:
  Ejemplo: https://localhost:44345/api/values
  Aquí deberá ingresar el token en postman.
  Se mostrará un JSON.

Para acceder al CRUD de pizzas:
localhost:<port>/api/Pizzas/

Se espera un base de datos con el nombre: PizzaDB
y una colección con el nombre: Pizzas

(Puede modificarse esta información en "appsettings.json")

Ejemplo de formato de Json:
[{"id":"5dcf54d4d25420878d95f865","pizzaName":"Pepperoni Pizza","description":"A new pizza","ingredients":["Pepperoni","Cheese"],"dough":"Delicious","size":"Big","portions":1,"hasCheese":true}]

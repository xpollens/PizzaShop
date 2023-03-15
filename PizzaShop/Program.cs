using PizzaShop;

MenuItem pizza = new MenuItem(ItemType.Pizza, Size.Small);
pizza.addTopping("Mozzarella");
pizza.addTopping("Mushrooms");

string description = pizza.getDescription();
int price = pizza.getPrice();

Console.WriteLine($"{description}: {price}");

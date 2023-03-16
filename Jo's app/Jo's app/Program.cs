// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Jo_s_app;

BreakfastOrder Breakfast_Order = new("order_id", "item_name", 1, 1);
Breakfast_Order.prepareOrder();


LunchOrder Lunch_Order = new("order_id", "item_name", 1, 1);
Lunch_Order.prepareOrder();

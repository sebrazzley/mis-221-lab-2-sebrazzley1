

const double DRIVERS_WAGE = 1.27;
double milesPerOrder;
double ordersFilled;
double milesDriven;
double ordersMade;
double costPerOrder;
double fulfillmentRate;



System.Console.WriteLine("Enter number of orders filled ");
ordersFilled = int.Parse (Console.ReadLine());

System.Console.WriteLine("Enter number of orders made ");
ordersMade=int.Parse (Console.ReadLine());

System.Console.WriteLine("Enter number of miles driven ");
milesDriven = double.Parse (Console.ReadLine());

fulfillmentRate = ordersFilled/ordersMade;
milesPerOrder = milesDriven/ordersFilled;

costPerOrder = milesPerOrder * DRIVERS_WAGE;
//gi
System.Console.WriteLine("Your fulfillment rate is " + fulfillmentRate);
System.Console.WriteLine("Your cost per order is " + costPerOrder);


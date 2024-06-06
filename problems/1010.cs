/*In this problem, the task is to read a code of a product 1, the number of units of product 1, the price for one unit of product 1, the code of a product 2, the number of units of product 2 and the price for one unit of product 2. After this, calculate and show the amount to be paid.

Input
The input file contains two lines of data. In each line there will be 3 values: two integers and a floating value with 2 digits after the decimal point.

Output
The output file must be a message like the following example where "Valor a pagar" means Value to Pay. Remember the space after ":" and after "R$" symbol. The value must be presented with 2 digits after the point.*/

/*using System.Globalization;

var code = Convert.ToInt32(Console.ReadLine());
var unit = Convert.ToInt32(Console.ReadLine());
var price = Convert.ToDouble(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));

var product1 = unit * price;

code = Convert.ToInt32(Console.ReadLine());
unit = Convert.ToInt32(Console.ReadLine());
price = Convert.ToDouble(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));

var product2 = unit * price;

Console.WriteLine("VALOR A PAGAR: R$" + (product1+product2).ToString("F2", CultureInfo.CreateSpecificCulture("en-US")));*/
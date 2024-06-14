/*Read a value of floating point with two decimal places. This represents a monetary value. After this, calculate the smallest possible number of notes and coins on which the value can be decomposed. The considered notes are of 100, 50, 20, 10, 5, 2. The possible coins are of 1, 0.50, 0.25, 0.10, 0.05 and 0.01. Print the message “NOTAS:” followed by the list of notes and the message “MOEDAS:” followed by the list of coins.

Input
The input file contains a value of floating point N (0 ≤ N ≤ 1000000.00).

Output
Print the minimum quantity of banknotes and coins necessary to change the initial value, as the given example.*/

/*using System.Globalization;

double val = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
double[] mont = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
int notas;

Console.WriteLine("NOTAS:");

for (int i = 0; i < 6; i++){
    notas = (int)(val / mont[i]);
    Console.WriteLine(notas + "nota(s) de R$ " + mont[i].ToString("F2", CultureInfo.InvariantCulture));
    val -= mont[i] * notas;
}

Console.WriteLine("MOEDAS:");

for (int i = 6; i < mont.Length; i++){
    notas = (int)(val / mont[i]);
    Console.WriteLine(notas + "moeda(s) de R$ " + mont[i].ToString("F2", CultureInfo.InvariantCulture));
    val -= mont[i] * notas;
}*/
// See https://aka.ms/new-console-template for more information

int [] numbers = {1,2,3,4,5,10};
static double CalculateAverage(int[] values) => values.Average();

double avg = CalculateAverage(numbers);
Console.WriteLine($"Average value is: {avg}");

static int GetMax(int[] values) => values.Max();
Console.WriteLine($"Max value is: {GetMax(numbers)}");


static int CalculateMax(int[] values) => values.Max();
Console.WriteLine($"Max value is: {CalculateMax(numbers)}");

//przepraszam ale niechcacy zrobilem merge bez fast forward wiec robie wersje prawidlowa 

static int GetMin(int[] values) => values.Min();
Console.WriteLine($"Min: {GetMin(numbers)}");
Console.WriteLine("Zmieniono na gałęź feature-conflict");
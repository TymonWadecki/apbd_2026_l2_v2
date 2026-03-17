// See https://aka.ms/new-console-template for more information

int [] numbers = {1,2,3,4,5,10};
static double GetAverage(int[] values) => values.Average();

double avg = GetAverage(numbers);
Console.WriteLine($"Average value is: {avg}");
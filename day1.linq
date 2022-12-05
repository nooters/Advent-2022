<Query Kind="Program" />

void Main()
{
	List<int> calorieCount = new List<int>();
	string[] inputNumbers = File.ReadAllLines("input.txt");
	int currentCount = 0;
	//Parse file for numbers
	//Keep adding until you reach an empty space, then expand to next elf
	foreach(string i in inputNumbers)
	{
		if( i == "" )
		{
			calorieCount.Add(currentCount);
			currentCount = 0;
		}
		else
		{
			currentCount += int.Parse(i);
		}
	}
	//After done parsing, sort collection and output sorted list
	calorieCount = calorieCount.OrderBy(n => n).ToList().Dump ("Calories by Elves");
	//part 2						   
	int bigThree = calorieCount.OrderBy(n => n).TakeLast(3).Sum().Dump ("Top 3 Elves Added");

}

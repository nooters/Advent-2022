<Query Kind="Program" />

void Main()
{
	int compartments = 0;
	int score = 0;
	int score2 = 0;
	int N = 0;
	string[] groupCompare = new string[3];
	// string[] rucksack = {"vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg", "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw"};
	string[] rucksack = File.ReadAllLines("input3.txt");
	foreach(string sack in rucksack)
	{
		//divide the sack into the two compartments
		compartments = sack.Length / 2;
		//check each letter if it has a corresponding letter in the second compartment
		foreach(char elfItem in sack[0..compartments])
		{
			if(sack[^compartments..].Contains(elfItem))
			{
				
				score += 1 + (elfItem switch
				{
					(>= 'a') and (<= 'z') => elfItem - 'a',
					(>= 'A') and (<= 'Z') => elfItem + 26 - 'A',
					_ => elfItem.Dump("Shouldn't see this!"),
				});
				break;
			}
		}
		//calculate the value of the character

		
		//Part 2
		//Store multiple lines for comparison
		groupCompare[N] = sack;
		N++;
		if(N > 2)
		{
			foreach(char elfItem in groupCompare[0])
			{
				if(groupCompare[1].Contains(elfItem) && groupCompare[2].Contains(elfItem))
				{
					score2 += 1 + (elfItem switch
					{
						(>= 'a') and (<= 'z') => elfItem - 'a',
						(>= 'A') and (<= 'Z') => elfItem + 26 - 'A',
						_ => elfItem.Dump("Shouldn't see this!"),
					});
					N = 0;
					break;
				}

			}
		}
	}
	
	score=score.Dump("Score");
	score2=score2.Dump("Score 2");
	
}

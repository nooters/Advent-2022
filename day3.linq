<Query Kind="Program" />

void Main()
{
	int compartments = 0;
	int score = 0;
	int score2 = 0;
	int N = 0;
	char common = 'a';
	string[] groupCompare = new string[3];
	string[] rucksack = File.ReadAllLines("input3.txt");
	foreach(string sack in rucksack)
	{
		compartments = sack.Length / 2;
		common = char.Parse(string.Concat(sack[0..compartments].Intersect(sack[^compartments..])));
		score += 1 + (common switch
		{
			(>= 'a') and (<= 'z') => common - 'a',
			(>= 'A') and (<= 'Z') => common + 26 - 'A',
			_ => common.Dump("Shouldn't see this!"),
		});
		
		//Part 2
		//Store multiple lines for comparison
		groupCompare[N] = sack;
		N++;
		if(N > 1)
		{
			groupCompare[0] = string.Concat(groupCompare[0].Intersect(groupCompare[1]));
		}
		if(N > 2)
		{
			common = char.Parse(string.Concat(groupCompare[0].Intersect(groupCompare[2])));
			score2 += 1 + (common switch
			{
				(>= 'a') and (<= 'z') => common - 'a',
				(>= 'A') and (<= 'Z') => common + 26 - 'A',
				_ => common.Dump("Shouldn't see this!"),
			});
			N = 0;
		}
	}
	score=score.Dump("Score");
	score2=score2.Dump("Score 2");	
}

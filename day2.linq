<Query Kind="Program" />

void Main()
{
	int Score = 0;
	string b = "";
	string[] RPS = File.ReadAllLines("input2.txt");
	foreach(string i in RPS)
	{
		switch (i)
		{
			//Ties
			case "A X": case "B Y": case "C Z": 
				Score += 3;
				break;
			//Wins
			case "A Y": case "B Z": case "C X":
				Score += 6;
				break;
			//Losses need not be calculated				
			default:
				break;
		}
		
		switch (i[^1..])
		{
			//used Rock, Paper, or Scissors
			case "X":
				Score += 1;
				break;
			case "Y":
				Score += 2;
				break;
			case "Z":
				Score += 3;
				break;
			default:
				break;
			
		}
		
	}
	Score = Score.Dump ("Final Score");	
	Score = 0;
	
	//Part 2, same concept different cuts
		foreach(string i in RPS)
	{
		switch (i[^1..])
		{
			//Ties
			case "Y": 
				Score += 3;
				break;
			//Wins
			case "Z":
				Score += 6;
				break;
			//Losses need not be calculated				
			default:
				break;
		}
		
		switch (i)
		{
			//used Rock, Paper, or Scissors
			case "A Y": case "B X": case "C Z":
				Score += 1;
				break;
			case "B Y": case "C X": case "A Z":
				Score += 2;
				break;
			default:
				Score += 3;
				break;
		}
	}
	Score = Score.Dump ("REAL Final Score");	
	
}

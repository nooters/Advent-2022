<Query Kind="Program" />

void Main()
{
	string[] pairs = File.ReadAllLines("input4.txt");
	int sections = 0, sections2 = 0;
	foreach(string p in pairs)
	{
		string[] f = Regex.Split(p,@"\D+");
		int[] e = new int[4]{int.Parse(f[0]), int.Parse(f[1]), int.Parse(f[2]), int.Parse(f[3])};
		//If bounds of either number are fully within the other, increment sections
		if((e[0]>=e[2]&&e[1]<=e[3])||(e[0]<=e[2]&&e[1]>=e[3]))
		{
			sections++;
		}
		//part2
		//If there are any intersections, increment sections2
		//if left (0) is greater than right (3) or right (1) is less than left (2)
		//or
		//if left (2) is greater than right (1) or right (3) is less than left (0)
		//it's easy to get lost with all these calls...
		if(!((e[0]>e[3]||e[1]<e[2])||(e[2]>e[1]||e[3]<e[0])))
		{
			sections2++;
		}
	}
	sections.Dump("Sections");
	sections2.Dump("Sections 2");
}

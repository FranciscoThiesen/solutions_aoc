using System;
public class Test
{
	public static void Main()
	{
		System.Collections.Generic.List<int> L = new System.Collections.Generic.List<int>(); 
		string val;
		while((val = Console.ReadLine()) != null) {
			L.Add(Convert.ToInt32(val));
		}
		
		foreach (int v in L)
		{
			foreach (int v2 in L)
			{
				if(v + v2 == 2020)
				{
					Console.WriteLine(v * v2);
				}
			}
		}
	}
}

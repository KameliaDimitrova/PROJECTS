﻿using System;

public class Substring_broken
{
	public static void Main()

    {
		string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

		char Search = 'p';
		bool hasMatch = false;

		for (int i = 0; i < text.Length; i++)
		{
           
			if ((text[i]) == Search)
			{
				hasMatch = true;

				int endIndex = jump+1;
                string matchedString;

                if (i + endIndex <= text.Length)
                {

                    matchedString = text.Substring(i, endIndex);

                }
                else
                {

                    matchedString = text.Substring(i);
                }
                    Console.WriteLine(matchedString);
                i += jump;


            }
		}

		if (!hasMatch)
		{
			Console.WriteLine("no");
		}
	}
}

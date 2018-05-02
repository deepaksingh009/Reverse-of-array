using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Permutation
    {
		public void method()
		{
			string intputstr = "aabc";
			List<string> output = new List<string>();
			int counter = 0;
			List<char> str = new List<char>();


			for (int i = 0; i < intputstr.Length; i++)
			{
				str.Add(intputstr[i]);
			}

			for (int i = 0; i < 24; i++)
			{
				var s = "";
				var laststring = "";
				if (output.Count > 0)
				{
					laststring = output[i - 1];
				}
				for (int j = 0; j < intputstr.Length; j++)
				{
					if (counter == j)
					{
						if (output.Count > 0)

						{
							s += laststring[counter + 1] + "" + laststring[counter];
							counter = counter + 1;
							if (counter == intputstr.Length - 1)
							{
								counter = 0;
							}
							else
							{

								j = j + 2;
							}
						}
						else
						{

							s = intputstr[counter + 1] + "" + intputstr[i];
							if (counter == intputstr.Length)
							{
								counter = 0;
							}
							else
							{
								counter = counter + 1;
								j = j + 2;
							}
						}



					}

					if (output.Count > 0)
					{
						if (s.Length < laststring.Length)
						{
							s += laststring[j].ToString();
						}
					}
					else
					{ s += intputstr[j].ToString(); }





				}
				output.Add(s);

				

			}
		

		}
	}
}

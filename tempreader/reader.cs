using System;

namespace myReader {
class Reader {	
	public static void Main(){
	
		int counter = 0;
		string line;

		System.IO.StreamReader file = new System.IO.StreamReader("bedroom.json");
		while((line = file.ReadLine()) != null)
		{
			if (line.Contains("temp")){
				Console.WriteLine(line);
			}
	   
		   counter++;
		}

		file.Close();

		}

	}
}
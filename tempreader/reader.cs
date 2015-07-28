using System;
using System.Text;

namespace myReader {
class Reader {	

	public static void Main(){

		string line;
		string temptab = "      \"temp\" : \"";
		string datetab = "      \"date\" : \"";

		System.IO.StreamReader file = new System.IO.StreamReader("bedroom.json");
		int ctr = 0;
		while((line = file.ReadLine()) != null)
		{
			
			if (line.Contains("temp") || line.Contains("date")){


				StringBuilder b = new StringBuilder(line);
				b.Replace(temptab, "");
				b.Replace(datetab, "");
				b.Replace("\"", "").Replace(",", "");

				if (ctr % 2 ==0){
					Console.Write(b + ",");
				}else {
					Console.WriteLine(b);
				}
				ctr++;
			}	   
		}
		file.Close();
		}
	}
}

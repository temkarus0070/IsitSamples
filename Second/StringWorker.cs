/*
 * Created by SharpDevelop.
 * User: pretkov_a_i
 * Date: 24.09.2020
 * Time: 12:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;

namespace Second
{
	/// <summary>
	/// Description of StringWorker.
	/// </summary>
	public static class StringWorker
	{
		public static void FileRewriter(string filePath,string outputPath)
		{
			var writer = new StreamWriter(outputPath);
			var reader = new StreamReader(filePath);
			var str = reader.ReadToEnd().Split(new char[]{'\n'});
            var builder = new StringBuilder();
			foreach(var fileString in str)
			{
				var numbersArray = fileString.Split(new char[]{' '});
				foreach(var number in numbersArray)
				{
                    builder.Append($"{number} ");
				}
			}
            writer.WriteLine(builder.ToString());
			writer.Close();
			reader.Close();
			
		}
	}
}

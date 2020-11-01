/*
 * Created by SharpDevelop.
 * User: pretkov_a_i
 * Date: 24.09.2020
 * Time: 12:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Second
{
	/// <summary>
	/// Description of StringWorker.
	/// </summary>
    /// 

        //repair

	public class StringWorker
	{
        public string FilePath { get; set; }
        public string Output { get; set; }

        public StringWorker(string filePath, string outputPath)
        {
            this.FilePath = filePath;
            this.Output = outputPath;
        }



		public  void FileRewrite()
		{
            var writer = new StreamWriter(Output);
			var reader = new StreamReader(FilePath);
			var str = reader.ReadToEnd().Split(new char[]{'\n'});
            var builder = new StringBuilder();
			foreach(var fileString in str)
			{
				var numbersArray = fileString.Split(new char[]{' '});
				foreach(var subStr in numbersArray)
				{
                   if( !String.IsNullOrWhiteSpace(subStr))
                    builder.Append($"{subStr} ");
				}
			}
            writer.WriteLine(builder.ToString());
			writer.Close();
			reader.Close();
			
		}
	}
}

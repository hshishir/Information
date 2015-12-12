using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Information
{
	class Program
	{
		static void Main(string[] args)
		{
			TestAsyncExample();

			Console.WriteLine("Carry on");
		}

		static async void TestAsyncExample()
		{
			var obj = new AsyncExample();
			var url = "http://www.microsoft.com";

			int contentLength = await obj.GetWebAsync(url);
			Console.WriteLine("Url={0}, Length={1}", url, contentLength);
		}
	}
}

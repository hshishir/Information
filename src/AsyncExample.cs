using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
	public class AsyncExample
	{
		public async Task<int> GetWebAsync(string url)
		{
			var httpClient = new HttpClient();
			Task<string> getStringTask = httpClient.GetStringAsync(url);
			string content = await getStringTask;
			return content.Length;
		}
	}
}
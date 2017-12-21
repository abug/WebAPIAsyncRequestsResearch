using System;
using System.Diagnostics;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebAPIAsyncRequestsResearch.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		public JsonResult<ValueObject> Get()
		{
			Trace.WriteLine("Parameterless get started...");

			var randomGenerator = new Random();
			var randomTimeSpan = randomGenerator.Next(2, 15);

			Thread.Sleep(randomTimeSpan * 1000);

			return Json(new ValueObject
			{
				Id = 1,
				Value = "Value 1",
				TimeSpan = randomTimeSpan
			});
		}

		// GET api/values/5
		public JsonResult<ValueObject> Get(int id)
		{
			Trace.WriteLine("Parameterized get is started...");

			var randomGenerator = new Random();
			var randomTimeSpan = randomGenerator.Next(2, 15);

			Thread.Sleep(randomTimeSpan * 1000);

			return Json(new ValueObject
			{
				Id = id,
				Value = $"Value {id}",
				TimeSpan = randomTimeSpan
			});
		}
	}

	public class ValueObject
	{
		public int Id { get; set; }
		public string Value { get; set; }
		public int TimeSpan { get; set; }
	}
}
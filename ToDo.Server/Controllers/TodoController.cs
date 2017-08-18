using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using TodoApi.Models;

namespace TodoApi.Controllers
{
	[Route("api/[controller]")]
	public class TodoController : ApiController
	{
		public TodoController()
		{
			if (TodoItems == null)
			{
				TodoItems = new TodoRepository();
			}
		}

		public static ITodoRepository TodoItems { get; set; }

		[HttpGet]
		public IEnumerable<TodoItem> GetAll()
		{
			return TodoItems.GetAll();
		}

		[HttpGet]
		[Route("{id}")]
		public TodoItem GetById(string id)
		{
			var item = TodoItems.Find(id);
			if (item == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return item;
		}

		[HttpPost]
		public IHttpActionResult Create([FromBody] TodoItem item)
		{
			if (item == null)
			{
				return BadRequest();
			}
			TodoItems.Add(item);
            return CreatedAtRoute("DefaultApi", new { id = item.Key }, item);
        }

        /// <summary>
        /// Update the given item using the default PUT route
        /// </summary>
        /// <param name="item">the item to update with the modified data</param>
        /// <returns>200 OK if success</returns>
		[HttpPut]
        [Route("{id}")]
        public IHttpActionResult Update([FromBody] TodoItem item)
        {
            if (item == null)
                return BadRequest();

            var todo = TodoItems.Find(item.Key);
            if (todo == null)
                return NotFound();

            TodoItems.Update(item);
            return Ok();
        }

        [HttpPut]
		[Route("{id}")]
		public IHttpActionResult Update([FromBody] TodoItem item, string id)
		{
			if (item == null)
			{
				return BadRequest();
			}

			var todo = TodoItems.Find(id);
			if (todo == null)
			{
				return NotFound();
			}

			item.Key = todo.Key;

			TodoItems.Update(item);
			return Ok();
		}

		[HttpDelete]
		[Route("{id}")]
		public IHttpActionResult Delete(string id)
		{
			var todo = TodoItems.Find(id);
			if (todo == null)
			{
				return NotFound();
			}

			TodoItems.Remove(id);
			return Ok();
		}
	}
}

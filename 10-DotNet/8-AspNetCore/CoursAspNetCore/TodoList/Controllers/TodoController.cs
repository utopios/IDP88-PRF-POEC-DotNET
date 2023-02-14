using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.Tools;

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        private DataDbContext _dataDbContext;

        public TodoController(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }
        public IActionResult Index(string? message)
        {
            ViewBag.Message = message;  
            return View(_dataDbContext.ToDos.ToList());
        }

        public IActionResult SubmitTodo(ToDo toDo)
        {
            _dataDbContext.ToDos.Add(toDo);
            string message = "";
            if (_dataDbContext.SaveChanges() > 0)
            {
                message = "todo ajoutée";
            }
            else
            {
                message = "erreur todo";
            }
            return RedirectToAction("Index", "Todo", new {message = message});
        }
        
        public IActionResult ChangeStateTodo(int id)
        {
            ToDo? todo = _dataDbContext.ToDos.Find(id);
            string message = "";
            if(todo == null)
            {
                message = "aucune todo avec cet id";
            }
            else
            {
                todo.Done = !todo.Done;
                if(_dataDbContext.SaveChanges() > 0)
                {
                    message = "State changed";
                }
            }
            return RedirectToAction("Index", "Todo", new { message = message });
        }

        public IActionResult DeleteTodo(int id)
        {
            ToDo? todo = _dataDbContext.ToDos.Find(id);
            string message = "";
            if (todo == null)
            {
                message = "aucune todo avec cet id";
            }
            else
            {
               _dataDbContext.ToDos.Remove(todo);
                if (_dataDbContext.SaveChanges() > 0)
                {
                    message = "todo deleted";
                }
            }
            return RedirectToAction("Index", "Todo", new { message = message });
        }
    }
}

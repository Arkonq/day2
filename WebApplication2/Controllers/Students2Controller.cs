using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
	//localhost/Students2/
	// Scoped
	// Transcient
	// Singleton

	public class Students2Controller : Controller
	{
		public IList<Student> _students { get; private set; }

		public Students2Controller()
		{
			this._students = new List<Student>()
			{
				new Student() {Id = 1, Name = "Student 1", Mark = 4},
				new Student() {Id = 2, Name = "Student 2", Mark = 4},
				new Student() {Id = 3, Name = "Student 3", Mark = 2},
				new Student() {Id = 4, Name = "Student 4", Mark = 3},
				new Student() {Id = 5, Name = "Student 5", Mark = 5}
			};
		}


		// GET: Students2
		public ActionResult Index()
		{
			return View(_students);
		}

		/// <summary>
		/// https://bitbucket.org/absagatnd/day2/src/master/
		/// Создать Details.cshtml (View)
		/// Отобразить данные с переменной student во View
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ActionResult Details(int id)
		{
			Student student = _students.FirstOrDefault(s => s.Id == id);
			return View(student);
		}

		// GET: Students2/Create
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}

		// POST: Students2/Create
		[HttpPost]
		public ActionResult Create(Student student)
		{
			try
			{
				if (ModelState.IsValid)
				{
					_students.Add(student);
				}
				ViewBag.Count = _students.Count;
				return View();
			}
			catch
			{
				return View();
			}
		}

		// GET: Students2/Edit/5
		public ActionResult Edit(int id)
		{
			Student student = _students.FirstOrDefault(s => s.Id == id);
			return View(student);
		}

		// POST: Students2/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, Student student)
		{
			try
			{
				if (_students.FirstOrDefault(s => s.Id == id) != null)
				{
					_students.FirstOrDefault(s => s.Id == id).Name = student.Name;
					_students.FirstOrDefault(s => s.Id == id).Mark = student.Mark;
					return RedirectToAction("Index");
				}
				else
				{
					return View();
				}
			}
			catch
			{
				return View();
			}
		}

		// GET: Students2/Delete/5
		public ActionResult Delete(int id)
		{
			Student student = _students.FirstOrDefault(s => s.Id == id);
			_students.Remove(student);
			return RedirectToAction("Index");
		}

		// POST: Students2/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}

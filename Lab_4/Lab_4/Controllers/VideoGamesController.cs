﻿using Lab_4.Models;
using Lab_4.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_4.Controllers
{
    public class VideoGamesController : Controller
    {
        // GET: VideoGames
        public ActionResult Index()
        {
            return View();
        }

        // GET: VideoGames/Details/5
        public ActionResult Details(string id)
        {
            return View(Singleton.Instance.dictionary[id]);
        }

        // GET: VideoGames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoGames/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Videogames newGame = (new Videogames
                {
                    Name = collection["Name"],
                    RealeseDAte = DateTime.Parse(collection["RealeseDate"]),
                    Gender = collection["Gender"],
                    Ranking = int.Parse(collection["Ranking"]),
                    platform = collection["plataform"]
                });
                Singleton.Instance.dictionary.Add(collection["Name"], newGame);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoGames/Edit/5
        public ActionResult Edit(string id)
        {
            return View(Singleton.Instance.dictionary[id]);
        }

        // POST: VideoGames/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoGames/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VideoGames/Delete/5
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
        
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(FormCollection collection)
        {
            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}

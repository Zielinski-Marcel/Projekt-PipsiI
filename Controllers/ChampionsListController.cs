﻿using Microsoft.AspNetCore.Mvc;
using PPSI3.Data;
using PPSI3.ViewModels;
using PPSI.Models;

namespace PPSI3.Controllers
{
    public class ChampionsListController : Controller
    {
        private readonly DB context;
        public ChampionsListController(DB context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var ChampionsAtributes = context.ChampionsAtribute.ToList();
            var Champions = context.Champions.ToList();
            var ChampionsRoles = context.ChampionsRole.ToList();
            //MergeDB
            List<ChampionsListViewModel> Champs = ChampionsListViewModel.GenerateListOfChampions(Champions, ChampionsAtributes, ChampionsRoles);
            return View(Champs);
        }
    }
}

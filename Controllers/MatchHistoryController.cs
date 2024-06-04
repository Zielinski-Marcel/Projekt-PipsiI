using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPSI.Nowy_folder;
using PPSI3.ExtraData;
using PPSI3.Models;
using PPSI3.ViewModels;
using System.Collections.Generic;

namespace PPSI3.Controllers
{
    public class MatchHistoryController : Controller
    {
        private readonly DB context;

        public MatchHistoryController(DB context)
        {
            this.context = context;
        }


        // GET: MatchHistoryController
        public ActionResult Index()
        {
            var Champions = context.Champions.ToList();
            var Teams = context.Teams.ToList();
            var Maps = context.Maps.ToList();
            var Players = context.Players.ToList();
            var GameModes = context.GameModes.ToList();
            var Summoners = context.Summoners.ToList();
            var Matches = context.Matches.ToList();
            var Equipments = context.Equipment.ToList();

            var ViewModel = new MatchViewModel(1, Matches, Teams, Players, GameModes, Champions, Summoners, Maps, Equipments);


            return View(ViewModel);
        }

        [HttpPost]
        public IActionResult ChampionCounters(int matchId)
        {
            var Champions = context.Champions.ToList();
            var Teams = context.Teams.ToList();
            var Maps=context.Maps.ToList();
            var Players=context.Players.ToList();
            var GameModes=context.GameModes.ToList();
            var Summoners=context.Summoners.ToList();
            var Matches=context.Matches.ToList();
            var Equipments=context.Equipment.ToList();

            var ViewModel = new MatchViewModel(matchId, Matches ,Teams, Players, GameModes, Champions, Summoners, Maps, Equipments);
           

            return View(ViewModel);
        }


    }
}

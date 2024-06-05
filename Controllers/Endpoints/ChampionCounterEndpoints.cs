using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using PPSI3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using PPSI3.ExtraData;
using PPSI3.ViewModels;
using PPSI3.Data;
using PPSI.Models;
namespace PPSI3.Controllers.Endpoints;

public static class ChampionCounterEndpoints
{
    public static void MapChampionCounterEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/ChampionCounter").WithTags(nameof(ChampionsAtribute));

        group.MapGet("/{name}/{role}", async (string name, string Role, DB db) =>
        {
            var ChampionsAtributes = await db.ChampionsAtribute.ToListAsync();
            var Champions = await db.Champions.ToListAsync();
            var ChampionsRoles = await db.ChampionsRole.ToListAsync();
            List<ChampionsListViewModel> Champs = ChampionsListViewModel.GenerateListOfChampions(Champions, ChampionsAtributes, ChampionsRoles);
            Champs = ChampionsAtribute.RoleFilter(Champs, Role);
            ChampionsAtribute enemyLaner = ChampionsAtribute.getChampionsAtributeById(Champion.getChampionIdByName(name, Champions), ChampionsAtributes);

            List<Champion> BestChampions = ChampionsAtribute.SelectChampionAgainstLaner(enemyLaner, Champs, Champions);


            return BestChampions;

        })
       .WithName("ChampionCounters")
       .WithOpenApi();




    }
}
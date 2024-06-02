using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using PPSI.Nowy_folder;
using PPSI3.Models;
using Microsoft.AspNetCore.Mvc;
namespace PPSI3.Controllers;

public static class ChampionCounterEndpoints
{
    public static void MapChampionCounterEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/ChampionCounter").WithTags(nameof(ChampionsAtribute));

        group.MapGet("/{name}", async ( string name, DB db) =>
        {
            var ChampionsAtributes = await db.ChampionsAtribute.ToListAsync();
            var Champions = await db.Champions.ToListAsync();
            int championId = Champion.getChampionIdByName(name, Champions);
            ChampionsAtribute enemyLaner = ChampionsAtribute.getChampionsAtributeById(championId, ChampionsAtributes);
            List<Champion> bestChampions = ChampionsAtribute.SelectChampionAgainstLaner(enemyLaner, ChampionsAtributes, Champions);

            return bestChampions;

        })
       .WithName("ChampionCounters")
       .WithOpenApi();

       

      
    }
}
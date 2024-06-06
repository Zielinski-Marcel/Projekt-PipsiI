using Microsoft.EntityFrameworkCore;
using PoroCounter2.Data;
using PoroCounter2.Models;
using PoroCounter2.ViewModels;


namespace PoroCounter2.Controllers.Endpoints
{
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
}

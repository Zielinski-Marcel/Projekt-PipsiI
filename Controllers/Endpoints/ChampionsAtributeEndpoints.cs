﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PoroCounter2.Data;
using PoroCounter2.Models;

namespace PoroCounter2.Controllers.Endpoints
{
    public static class ChampionsAtributeEndpoints
    {
        public static void MapChampionsAtributeEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/ChampionsAtribute").WithTags(nameof(ChampionsAtribute));

            group.MapGet("/", async (DB db) =>
            {
                return await db.ChampionsAtribute.ToListAsync();
            })
            .WithName("GetAllChampionsAtributes")
            .WithOpenApi();

            group.MapGet("/{id}", async Task<Results<Ok<ChampionsAtribute>, NotFound>> (int id, DB db) =>
            {
                return await db.ChampionsAtribute.AsNoTracking()
                    .FirstOrDefaultAsync(model => model.Id == id)
                    is ChampionsAtribute model
                        ? TypedResults.Ok(model)
                        : TypedResults.NotFound();
            })
            .WithName("GetChampionsAtributeById")
            .WithOpenApi();


        }
    }
}

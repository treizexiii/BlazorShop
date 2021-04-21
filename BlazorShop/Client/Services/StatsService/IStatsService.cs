using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Client.Services.StatsService
{
    interface IStatsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}

using System;

namespace BlazorShop.Shared
{
    public class Stats
    {
        public int Id { get; set; }
        public int Visits { get; set; }
        public DateTime? LastVisit { get; set; }
    }
}
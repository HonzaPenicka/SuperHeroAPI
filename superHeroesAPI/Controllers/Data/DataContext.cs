using System;
using Microsoft.EntityFrameworkCore;
using SuperHeroesAPI;

namespace superHeroesAPI.Controllers.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<SuperHero> SuperHeroes { get; set; }
	}
}


using Gra_przegladarkowa.Models;
using Gra_przegladarkowa.Models.Character;
using Gra_przegladarkowa.Models.Guild;
using Gra_przegladarkowa.Models.Item;
using Gra_przegladarkowa.Models.Mission;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.DAL
{
    public class RidentiaDbContext : DbContext
    {
        public RidentiaDbContext(DbContextOptions<RidentiaDbContext> options)
            : base(options)
        {
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Guild_Building> Guild_Buildings { get; set; }
        public DbSet<GuildChat> GuildChats { get; set; }
        public DbSet<InvitationsGuild> InvitationsGuilds { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<RaportGuild> RaportGuilds { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
        public DbSet<Backpack_Item> Backpack_Items { get; set; }
        public DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<CurrentEquipment> CurrentEquipment { get; set; }
        public DbSet<CurrentEquipment_Item> CurrentEquipment_Items { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Missions> Missions { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().ToTable("Characters");
            modelBuilder.Entity<Friend>().ToTable("Friends");
            modelBuilder.Entity<Level>().ToTable("Levels");
            modelBuilder.Entity<Message>().ToTable("Messages");
            modelBuilder.Entity<Profession>().ToTable("Professions");
            modelBuilder.Entity<Statistic>().ToTable("Statistics");
            modelBuilder.Entity<Work>().ToTable("Works");
            modelBuilder.Entity<Building>().ToTable("Buildings");
            modelBuilder.Entity<Guild>().ToTable("Guilds");
            modelBuilder.Entity<Guild_Building>().ToTable("Guild_Buildings");
            modelBuilder.Entity<GuildChat>().ToTable("GuildChats");
            modelBuilder.Entity<InvitationsGuild>().ToTable("InvitationsGuilds");
            modelBuilder.Entity<Member>().ToTable("Members");
            modelBuilder.Entity<RaportGuild>().ToTable("RaportGuilds");
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<Backpack>().ToTable("Backpacks");
            modelBuilder.Entity<Backpack_Item>().ToTable("Backpack_Items");
            modelBuilder.Entity<CategoryItem>().ToTable("CategoryItems");
            modelBuilder.Entity<CurrentEquipment>().ToTable("CurrentEquipment");
            modelBuilder.Entity<CurrentEquipment_Item>().ToTable("CurrentEquipment_Items");
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Missions>().ToTable("Missions");
            modelBuilder.Entity<Monster>().ToTable("Monsters");
            modelBuilder.Entity<Profile>().ToTable("Profiles");
        }
    }
}

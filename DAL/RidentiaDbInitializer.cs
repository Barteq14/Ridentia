using Gra_przegladarkowa.Models;
using Gra_przegladarkowa.Models.Character;
using Gra_przegladarkowa.Models.Guild;
using Gra_przegladarkowa.Models.Item;
using Gra_przegladarkowa.Models.Mission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.DAL
{
    public class RidentiaDbInitializer
    {
        public static void Initialize(RidentiaDbContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Levels.Any())
            {
                return;   // DB has been seeded
            }
            
            
             /*################################### CHARACTERS*/
             /*
            // characters
            var characters = new Character[]
            {
                new Character { },
            };
            foreach (Character c in characters)
            {
                context.Characters.Add(c);
            }
            context.SaveChanges();


            // friends
            var friends = new Friend[]
            {
                new Friend {  },
            };
            foreach (Friend f in friends)
            {
                context.Friends.Add(f);
            }
            context.SaveChanges();
            */
            // levels
            var levels = new Level[]
            {
                new Level { NameLevel = "Level 1", ReceivedPoint = 10, RequiredExp = 20 },
                new Level { NameLevel = "Level 2", ReceivedPoint = 10, RequiredExp = 22 },
                new Level { NameLevel = "Level 3", ReceivedPoint = 10, RequiredExp = 24 },
                new Level { NameLevel = "Level 4", ReceivedPoint = 10, RequiredExp = 26 },
                new Level { NameLevel = "Level 5", ReceivedPoint = 10, RequiredExp = 28 },
                new Level { NameLevel = "Level 6", ReceivedPoint = 10, RequiredExp = 30 },
                new Level { NameLevel = "Level 7", ReceivedPoint = 10, RequiredExp = 32 },
                new Level { NameLevel = "Level 8", ReceivedPoint = 10, RequiredExp = 34 },
                new Level { NameLevel = "Level 9", ReceivedPoint = 10, RequiredExp = 36 },
                new Level { NameLevel = "Level 10", ReceivedPoint = 12, RequiredExp = 38 },
                new Level { NameLevel = "Level 11", ReceivedPoint = 12, RequiredExp = 40 },
                new Level { NameLevel = "Level 12", ReceivedPoint = 12, RequiredExp = 42 },
                new Level { NameLevel = "Level 13", ReceivedPoint = 12, RequiredExp = 44 },
                new Level { NameLevel = "Level 14", ReceivedPoint = 12, RequiredExp = 46 },
                new Level { NameLevel = "Level 15", ReceivedPoint = 12, RequiredExp = 48 },
                new Level { NameLevel = "Level 16", ReceivedPoint = 12, RequiredExp = 50 },
                new Level { NameLevel = "Level 17", ReceivedPoint = 12, RequiredExp = 52 },
                new Level { NameLevel = "Level 18", ReceivedPoint = 12, RequiredExp = 54 },
                new Level { NameLevel = "Level 19", ReceivedPoint = 12, RequiredExp = 56 },
                new Level { NameLevel = "Level 20", ReceivedPoint = 14, RequiredExp = 58 },
                new Level { NameLevel = "Level 21", ReceivedPoint = 14, RequiredExp = 60 },
                new Level { NameLevel = "Level 22", ReceivedPoint = 14, RequiredExp = 62 },
                new Level { NameLevel = "Level 23", ReceivedPoint = 14, RequiredExp = 64 },
                new Level { NameLevel = "Level 24", ReceivedPoint = 14, RequiredExp = 66 },
                new Level { NameLevel = "Level 25", ReceivedPoint = 14, RequiredExp = 68 },
                new Level { NameLevel = "Level 26", ReceivedPoint = 14, RequiredExp = 70 },
                new Level { NameLevel = "Level 27", ReceivedPoint = 14, RequiredExp = 72 },
                new Level { NameLevel = "Level 28", ReceivedPoint = 14, RequiredExp = 74 },
                new Level { NameLevel = "Level 29", ReceivedPoint = 14, RequiredExp = 76 },
                new Level { NameLevel = "Level 30", ReceivedPoint = 16, RequiredExp = 78 },
                new Level { NameLevel = "Level 31", ReceivedPoint = 16, RequiredExp = 80 },
                new Level { NameLevel = "Level 32", ReceivedPoint = 16, RequiredExp = 82 },
                new Level { NameLevel = "Level 33", ReceivedPoint = 16, RequiredExp = 84 },
                new Level { NameLevel = "Level 34", ReceivedPoint = 16, RequiredExp = 86 },
                new Level { NameLevel = "Level 35", ReceivedPoint = 16, RequiredExp = 88 },
                new Level { NameLevel = "Level 36", ReceivedPoint = 16, RequiredExp = 90 },
                new Level { NameLevel = "Level 37", ReceivedPoint = 16, RequiredExp = 92 },
                new Level { NameLevel = "Level 38", ReceivedPoint = 16, RequiredExp = 94 },
                new Level { NameLevel = "Level 39", ReceivedPoint = 16, RequiredExp = 96 },
                new Level { NameLevel = "Level 40", ReceivedPoint = 18, RequiredExp = 98 },
                new Level { NameLevel = "Level 41", ReceivedPoint = 18, RequiredExp = 100 },
                new Level { NameLevel = "Level 42", ReceivedPoint = 18, RequiredExp = 102},
                new Level { NameLevel = "Level 43", ReceivedPoint = 18, RequiredExp = 104},
                new Level { NameLevel = "Level 44", ReceivedPoint = 18, RequiredExp = 106},
                new Level { NameLevel = "Level 45", ReceivedPoint = 18, RequiredExp = 108},
                new Level { NameLevel = "Level 46", ReceivedPoint = 18, RequiredExp = 110},
                new Level { NameLevel = "Level 47", ReceivedPoint = 18, RequiredExp = 112},
                new Level { NameLevel = "Level 48", ReceivedPoint = 18, RequiredExp = 114},
                new Level { NameLevel = "Level 49", ReceivedPoint = 18, RequiredExp = 116},
                new Level { NameLevel = "Level 50", ReceivedPoint = 20, RequiredExp = 118},
                new Level { NameLevel = "Level 51", ReceivedPoint = 20, RequiredExp = 120},
                new Level { NameLevel = "Level 52", ReceivedPoint = 20, RequiredExp = 122},
                new Level { NameLevel = "Level 53", ReceivedPoint = 20, RequiredExp = 124},
                new Level { NameLevel = "Level 54", ReceivedPoint = 20, RequiredExp = 126},
                new Level { NameLevel = "Level 55", ReceivedPoint = 20, RequiredExp = 128},
                new Level { NameLevel = "Level 56", ReceivedPoint = 20, RequiredExp = 130},
                new Level { NameLevel = "Level 57", ReceivedPoint = 20, RequiredExp = 132},
                new Level { NameLevel = "Level 58", ReceivedPoint = 20, RequiredExp = 134},
                new Level { NameLevel = "Level 59", ReceivedPoint = 20, RequiredExp = 136},
                new Level { NameLevel = "Level 60", ReceivedPoint = 22, RequiredExp = 138},
                new Level { NameLevel = "Level 61", ReceivedPoint = 22, RequiredExp = 140},
                new Level { NameLevel = "Level 62", ReceivedPoint = 22, RequiredExp = 142},
                new Level { NameLevel = "Level 63", ReceivedPoint = 22, RequiredExp = 144},
                new Level { NameLevel = "Level 64", ReceivedPoint = 22, RequiredExp = 146},
                new Level { NameLevel = "Level 65", ReceivedPoint = 22, RequiredExp = 148},
                new Level { NameLevel = "Level 66", ReceivedPoint = 22, RequiredExp = 150},
                new Level { NameLevel = "Level 67", ReceivedPoint = 22, RequiredExp = 152},
                new Level { NameLevel = "Level 68", ReceivedPoint = 22, RequiredExp = 154},
                new Level { NameLevel = "Level 69", ReceivedPoint = 22, RequiredExp = 156},
                new Level { NameLevel = "Level 70", ReceivedPoint = 24, RequiredExp = 158},
                new Level { NameLevel = "Level 71", ReceivedPoint = 24, RequiredExp = 160},
                new Level { NameLevel = "Level 72", ReceivedPoint = 24, RequiredExp = 162},
                new Level { NameLevel = "Level 73", ReceivedPoint = 24, RequiredExp = 164},
                new Level { NameLevel = "Level 74", ReceivedPoint = 24, RequiredExp = 166},
                new Level { NameLevel = "Level 75", ReceivedPoint = 24, RequiredExp = 168},
                new Level { NameLevel = "Level 76", ReceivedPoint = 24, RequiredExp = 170},
                new Level { NameLevel = "Level 77", ReceivedPoint = 24, RequiredExp = 172},
                new Level { NameLevel = "Level 78", ReceivedPoint = 24, RequiredExp = 174},
                new Level { NameLevel = "Level 79", ReceivedPoint = 24, RequiredExp = 176},
                new Level { NameLevel = "Level 80", ReceivedPoint = 26, RequiredExp = 178},
                new Level { NameLevel = "Level 81", ReceivedPoint = 26, RequiredExp = 180},
                new Level { NameLevel = "Level 82", ReceivedPoint = 26, RequiredExp = 182},
                new Level { NameLevel = "Level 83", ReceivedPoint = 26, RequiredExp = 184},
                new Level { NameLevel = "Level 84", ReceivedPoint = 26, RequiredExp = 186},
                new Level { NameLevel = "Level 85", ReceivedPoint = 26, RequiredExp = 188},
                new Level { NameLevel = "Level 86", ReceivedPoint = 26, RequiredExp = 190},
                new Level { NameLevel = "Level 87", ReceivedPoint = 26, RequiredExp = 192},
                new Level { NameLevel = "Level 88", ReceivedPoint = 26, RequiredExp = 194},
                new Level { NameLevel = "Level 89", ReceivedPoint = 26, RequiredExp = 196},
                new Level { NameLevel = "Level 90", ReceivedPoint = 28, RequiredExp = 198},
                new Level { NameLevel = "Level 91", ReceivedPoint = 28, RequiredExp = 200},
                new Level { NameLevel = "Level 92", ReceivedPoint = 28, RequiredExp = 202},
                new Level { NameLevel = "Level 93", ReceivedPoint = 28, RequiredExp = 204},
                new Level { NameLevel = "Level 94", ReceivedPoint = 28, RequiredExp = 206},
                new Level { NameLevel = "Level 95", ReceivedPoint = 28, RequiredExp = 208},
                new Level { NameLevel = "Level 96", ReceivedPoint = 28, RequiredExp = 210},
                new Level { NameLevel = "Level 97", ReceivedPoint = 28, RequiredExp = 212},
                new Level { NameLevel = "Level 98", ReceivedPoint = 28, RequiredExp = 214},
                new Level { NameLevel = "Level 99", ReceivedPoint = 28, RequiredExp = 216},
                new Level { NameLevel = "Level 100", ReceivedPoint = 30, RequiredExp = 218 },
                new Level { NameLevel = "Level 101", ReceivedPoint = 30, RequiredExp = 220},
                new Level { NameLevel = "Level 102", ReceivedPoint = 30, RequiredExp = 222},
                new Level { NameLevel = "Level 103", ReceivedPoint = 30, RequiredExp = 224},
                new Level { NameLevel = "Level 104", ReceivedPoint = 30, RequiredExp = 226},
                new Level { NameLevel = "Level 105", ReceivedPoint = 30, RequiredExp = 228},
                new Level { NameLevel = "Level 106", ReceivedPoint = 30, RequiredExp = 230},
                new Level { NameLevel = "Level 107", ReceivedPoint = 30, RequiredExp = 232},
                new Level { NameLevel = "Level 108", ReceivedPoint = 30, RequiredExp = 234},
                new Level { NameLevel = "Level 109", ReceivedPoint = 30, RequiredExp = 236},
                new Level { NameLevel = "Level 110", ReceivedPoint = 32, RequiredExp = 238}
            };
            foreach (Level l in levels)
            {
                context.Levels.Add(l);
            }
            context.SaveChanges();
            /*
            // messages
            var messages = new Message[]
            {
                new Message {  },
            };
            foreach (Message m in messages)
            {
                context.Messages.Add(m);
            }
            context.SaveChanges();
            */
            // professions
            var professions = new Profession[]
            {
                new Profession { NameProfession = "Wojownik", Hp = 1500, Armor = 500, Strenght = 10, Dexterity = 10, Vitality = 10, Resistance = 10, BlockHit = 10, Inteligance = 10 ,NameSpecialMove ="Jego tarcza płonie co zadaje dodatkowe obrażenia oraz podwyższa punkty życia" , ImageProfessionName ="~/Images/CreateCharacter/Characters/warrior.png", SpecialMoveTurnRequired = 20},
                new Profession { NameProfession = "Barbarzyńca", Hp = 1500, Armor = 500, Strenght = 10, Dexterity = 10, Vitality = 10, Resistance = 10, BlockHit = 10, Inteligance = 10, NameSpecialMove ="Podwyższenie pancerza o 200 punktów przed każda walką" , ImageProfessionName ="~/Images/CreateCharacter/Characters/barbarzynca.png", SpecialMoveTurnRequired = 20 },
                new Profession { NameProfession = "Zabójca", Hp = 1500, Armor = 500, Strenght = 10, Dexterity = 10, Vitality = 10, Resistance = 10, BlockHit = 10, Inteligance = 10 , NameSpecialMove ="Co pewną ilość ataków wyrzuca sztylet w przeciwnika" , ImageProfessionName ="~/Images/CreateCharacter/Characters/zabojca.png", SpecialMoveTurnRequired = 20  },
                new Profession { NameProfession = "Adept", Hp = 1500, Armor = 500, Strenght = 10, Dexterity = 10, Vitality = 10, Resistance = 10, BlockHit = 10, Inteligance = 10 , NameSpecialMove ="Posyła magiczną kulę która wybuch na przeciwniku co 5 atak" , ImageProfessionName ="~/Images/CreateCharacter/Characters/adept.png", SpecialMoveTurnRequired = 20  },
                new Profession { NameProfession = "Druid", Hp = 1500, Armor = 500, Strenght = 10, Dexterity = 10, Vitality = 10, Resistance = 10, BlockHit = 10, Inteligance = 20  ,NameSpecialMove ="Przywracanie pewnej ilości punktów zrowia co 3 atak" , ImageProfessionName ="~/Images/CreateCharacter/Characters/druid.png", SpecialMoveTurnRequired = 20  },
                new Profession { NameProfession = "Łucznik", Hp = 1500, Armor = 500, Strenght = 10, Dexterity = 10, Vitality = 10, Resistance = 10, BlockHit = 10, Inteligance = 10  ,NameSpecialMove ="Atak 3 strzałami na raz" , ImageProfessionName ="~/Images/CreateCharacter/Characters/lucznik.png", SpecialMoveTurnRequired = 20  }
            };
            foreach (Profession p in professions)
            {
                context.Professions.Add(p);
            }
            context.SaveChanges();
            /*
            // statistics
            var statistics = new Statistic[]
            {
                new Statistic {  },
            };
            foreach (Statistic s in statistics)
            {
                context.Statistics.Add(s);
            }
            context.SaveChanges();

            // works
            var works = new Work[]
            {
                new Work { Name = "Farmer" , Description = "Pracujesz jako rolnik , zbierasz plony", RevardExp = 100, RevardGold = 1000, WorkTime = 8 },
                new Work { Name = "Kowal" , Description = "Tworzysz przedmioty", RevardExp = 50, RevardGold = 1000, WorkTime = 3 },
                new Work { Name = "Stajenny" , Description = "Pomagasz przy opiekowaniu się końmi", RevardExp = 200, RevardGold = 1000, WorkTime = 5 },
                new Work { Name = "Rybak" , Description = "Łowisz ryby", RevardExp = 100, RevardGold = 1000, WorkTime = 2 },
                new Work { Name = "Piekarz" , Description = "Wypiekasz żywność", RevardExp = 100, RevardGold = 2000, WorkTime = 4 },
                new Work { Name = "Rzeźnik" , Description = "Brudna robota wymagająca twardej ręki", RevardExp = 100, RevardGold = 1500, WorkTime = 10 },
                new Work { Name = "Najemnik" , Description = "Pracujesz dla szefa w celu wyeliminowania jego przeciwników", RevardExp = 100, RevardGold = 1000, WorkTime = 8 }
            };
            foreach (Work w in works)
            {
                context.Works.Add(w);
            }
            context.SaveChanges();


            /*################################### GUILD*/
            /*
            // buildings
            var buildings = new Building[]
            {
                new Building { NameBuilding = "Pałac" , Description = "Dzięki temu budynkowi jesteśmy w stanie przyjmować większą ilość członków", Level = 1, CostUpgrade = 5000},
                new Building { NameBuilding = "Bank" , Description = "Dzięki temu budynkowi możesz wpłacać pieniądze do wspólnej kieszeni", Level = 1, CostUpgrade = 5000},
                new Building { NameBuilding = "Pole treningowe" , Description = "Zmniejszone koszta treningu", Level = 1, CostUpgrade = 5000},
                new Building { NameBuilding = "Magazyn" , Description = "Przechowywanie różnych przedmiotów", Level = 1, CostUpgrade = 5000},
                new Building { NameBuilding = "Łaźnia" , Description = "Możliwość odpoczynku", Level = 1, CostUpgrade = 5000}
            };
            foreach (Building b in buildings)
            {
                context.Buildings.Add(b);
            }
            context.SaveChanges();

            // guilds
            var guilds = new Guild[]
            {
                new Guild {  },
            };
            foreach (Guild g in guilds)
            {
                context.Guilds.Add(g);
            }
            context.SaveChanges();

            // guild_buildings
            var guild_buildings = new Guild_Building[]
            {
                new Guild_Building {  },
            };
            foreach (Guild_Building bg in guild_buildings)
            {
                context.Guild_Buildings.Add(bg);
            }
            context.SaveChanges();

            // guildchats
            var guildchats = new GuildChat[]
            {
                new GuildChat {  },
            };
            foreach (GuildChat gc in guildchats)
            {
                context.GuildChats.Add(gc);
            }
            context.SaveChanges();

            // invitationguild
            var invitationguild = new InvitationsGuild[]
            {
                new InvitationsGuild {  },
            };
            foreach (InvitationsGuild i in invitationguild)
            {
                context.InvitationsGuilds.Add(i);
            }
            context.SaveChanges();

            // members
            var members = new Member[]
            {
                new Member {  },
            };
            foreach (Member m in members)
            {
                context.Members.Add(m);
            }
            context.SaveChanges();

            // raportguilds
            var raportguilds = new RaportGuild[]
            {
                new RaportGuild {  },
            };
            foreach (RaportGuild r in raportguilds)
            {
                context.RaportGuilds.Add(r);
            }
            context.SaveChanges();
            */
            // roles
            var roles = new Role[]
            {
                new Role { NameRole = "Członek" },
                new Role { NameRole = "Admin" },
                new Role { NameRole = "Władca" }
            };
            foreach (Role ro in roles)
            {
                context.Roles.Add(ro);
            }
            context.SaveChanges();


            /*################################### ITEMS*/
            /*
            // backpacks
            var backpacks = new Backpack[]
            {
                new Backpack {  },
            };
            foreach (Backpack b in backpacks)
            {
                context.Backpacks.Add(b);
            }
            context.SaveChanges();

            // backpackItems
            var backpackitems = new Backpack_Item[]
            {
                new Backpack_Item {  },
            };
            foreach (Backpack_Item bi in backpackitems)
            {
                context.Backpack_Items.Add(bi);
            }
            context.SaveChanges();
            */
            // categoryItem
            var categoryitems = new CategoryItem[]
            {
                new CategoryItem { NameCategoryItem = "Broń" },
                new CategoryItem { NameCategoryItem = "Zbroja" },
                new CategoryItem { NameCategoryItem = "Hełm" },
                new CategoryItem { NameCategoryItem = "Tarcza" },
                new CategoryItem { NameCategoryItem = "Buty" },
                new CategoryItem { NameCategoryItem = "Rękawice" },
                new CategoryItem { NameCategoryItem = "Pierścień" },
                new CategoryItem { NameCategoryItem = "Amulet" },
                new CategoryItem { NameCategoryItem = "Żywność" },
                new CategoryItem { NameCategoryItem = "Bonus" },
            };
            foreach (CategoryItem c in categoryitems)
            {
                context.CategoryItems.Add(c);
            }
            context.SaveChanges();
            /*
            // currentEquipment
            var currentEquipments = new CurrentEquipment[]
            {
                new CurrentEquipment { },
            };
            foreach (CurrentEquipment ce in currentEquipments)
            {
                context.CurrentEquipment.Add(ce);
            }
            context.SaveChanges();

            // currentEquipment_Item
            var currentEquipment_Items = new CurrentEquipment_Item[]
            {
                new CurrentEquipment_Item {  },
            };
            foreach (CurrentEquipment_Item cei in currentEquipment_Items)
            {
                context.CurrentEquipment_Items.Add(cei);
            }
            context.SaveChanges();

            // items
            var items = new Item[]
            {
                new Item { NameItem = "Trojząb zagłady" , Damage = 10, Armor = 12, ItemPrice = 100, Hp = 200, BlockHit = 3, RequiredLvl = 1, Strenght = 0, Inteligence = 2, Resistance = 3, Vitality = 5 },
                new Item { NameItem = "Pałka Rafała" , Damage = 10, Armor = 12, ItemPrice = 100, Hp = 200, BlockHit = 3, RequiredLvl = 1, Strenght = 0, Inteligence = 2, Resistance = 3, Vitality = 5 },
                new Item { NameItem = "Różdżka" , Damage = 10, Armor = 12, ItemPrice = 100, Hp = 200, BlockHit = 3, RequiredLvl = 1, Strenght = 0, Inteligence = 2, Resistance = 3, Vitality = 5 },
                new Item { NameItem = "Widły matykty" , Damage = 10, Armor = 12, ItemPrice = 100, Hp = 200, BlockHit = 3, RequiredLvl = 1, Strenght = 0, Inteligence = 2, Resistance = 3, Vitality = 5 },
                new Item { NameItem = "Miecz klasyczny" , Damage = 10, Armor = 12, ItemPrice = 100, Hp = 200, BlockHit = 3, RequiredLvl = 1, Strenght = 0, Inteligence = 2, Resistance = 3, Vitality = 5 },
            };
            foreach (Item it in items)
            {
                context.Items.Add(it);
            }
            context.SaveChanges();

            */
            /*################################### Mission*/
            /*
            // missions
            var missions = new Missions[]
            {
                new Missions { NameMission = "misja 1" , Description = "jakis tam opis", RevardExp = 10, RevardGold = 500, MissionLvl= 1, RequiredQuantity = 3, Status = "nie aktywna"},
                new Missions { NameMission = "misja 2" , Description = "jakis tam opis", RevardExp = 12, RevardGold = 600, MissionLvl= 2, RequiredQuantity = 3, Status = "nie aktywna"},
                new Missions { NameMission = "misja 3" , Description = "jakis tam opis", RevardExp = 14, RevardGold = 700, MissionLvl= 3, RequiredQuantity = 3, Status = "nie aktywna"},
                new Missions { NameMission = "misja 4" , Description = "jakis tam opis", RevardExp = 16, RevardGold = 800, MissionLvl= 1, RequiredQuantity = 3, Status = "nie aktywna"},
                new Missions { NameMission = "misja 5" , Description = "jakis tam opis", RevardExp = 18, RevardGold = 600, MissionLvl= 5, RequiredQuantity = 3, Status = "nie aktywna"},
                new Missions { NameMission = "misja 6" , Description = "jakis tam opis", RevardExp = 20, RevardGold = 1000, MissionLvl= 1, RequiredQuantity = 3, Status = "nie aktywna"},
                new Missions { NameMission = "misja 7" , Description = "jakis tam opis", RevardExp = 25, RevardGold = 700, MissionLvl= 6, RequiredQuantity = 3, Status = "nie aktywna"},

            };
            foreach (Missions mi in missions)
            {
                context.Missions.Add(mi);
            }
            context.SaveChanges();

            // monsters
            var monsters = new Monster[]
            {
                new Monster { NameMonster = "Ludożerca", Hp = 10000, Armor = 100, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Mumia", Hp = 2000, Armor = 150, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Wilk", Hp = 3000, Armor = 200, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Cyklop", Hp = 4000, Armor = 250, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Krokodyl", Hp = 5000, Armor = 300, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Yeti", Hp = 6000, Armor = 350, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Skorpion", Hp = 7000, Armor = 400, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Kobra", Hp = 8000, Armor = 450, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Łowca", Hp = 9000, Armor = 500, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Byk", Hp = 11000, Armor = 550, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Zoombie", Hp = 12000, Armor = 600, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Szaman", Hp = 13000, Armor = 650, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Dezerter", Hp = 14000, Armor = 700, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Niewolnik", Hp = 15000, Armor = 750, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Zbuntowany Rycerz", Hp = 16000, Armor = 800, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Czarownica", Hp = 17000, Armor = 850, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Wampir", Hp = 18000, Armor = 900, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
                new Monster { NameMonster = "Dzik", Hp = 19000, Armor = 950, Damage = 20, MonsterLvl = 1, BlockHit = 4, DeathRevardExp = 1, DeathRevardGold = 200, Strenght = 20, Vitality = 50, Resistance = 20, Inteligence = 40 },
            };
            foreach (Monster mon in monsters)
            {
                context.Monsters.Add(mon);
            }
            context.SaveChanges();

            */
            /*################################### User*/
            /*
            // profiles
            var profiles = new Profile[]
            {
                new Profile {  },
            };
            foreach (Profile prof in profiles)
            {
                context.Profiles.Add(prof);
            }
            context.SaveChanges();
            */
        }
    }
}

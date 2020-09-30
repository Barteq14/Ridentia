using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gra_przegladarkowa.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backpacks",
                columns: table => new
                {
                    BackpackID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backpacks", x => x.BackpackID);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBuilding = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 999999999, nullable: false),
                    Level = table.Column<int>(nullable: false),
                    CostUpgrade = table.Column<int>(nullable: false),
                    Power = table.Column<int>(nullable: false),
                    PowerInfo = table.Column<string>(maxLength: 999999999, nullable: false),
                    ImageBuilding = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryItems",
                columns: table => new
                {
                    CategoryItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategoryItem = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryItems", x => x.CategoryItemID);
                });

            migrationBuilder.CreateTable(
                name: "CurrentEquipment",
                columns: table => new
                {
                    CurrentEquipmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentEquipment", x => x.CurrentEquipmentID);
                });

            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    GuildID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGuild = table.Column<string>(maxLength: 100, nullable: false),
                    MaxMember = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 999999999, nullable: false),
                    GoldGuild = table.Column<int>(nullable: false),
                    FamePointGuild = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.GuildID);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LevelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameLevel = table.Column<string>(maxLength: 100, nullable: false),
                    RequiredExp = table.Column<int>(nullable: false),
                    ReceivedPoint = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LevelID);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    MonsterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMonster = table.Column<string>(maxLength: 150, nullable: false),
                    MonsterLvl = table.Column<int>(nullable: false),
                    ImageMonsterName = table.Column<string>(nullable: false),
                    Damage = table.Column<int>(nullable: false),
                    Strenght = table.Column<int>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    BlockHit = table.Column<int>(nullable: false),
                    Resistance = table.Column<int>(nullable: false),
                    Inteligence = table.Column<int>(nullable: false),
                    Vitality = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false),
                    DeathRevardGold = table.Column<int>(nullable: false),
                    DeathRevardExp = table.Column<int>(nullable: false),
                    TimeRespown = table.Column<DateTime>(nullable: false),
                    MonsterID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.MonsterID);
                    table.ForeignKey(
                        name: "FK_Monsters_Monsters_MonsterID1",
                        column: x => x.MonsterID1,
                        principalTable: "Monsters",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ProfessionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProfession = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 999999999, nullable: true),
                    ImageProfessionName = table.Column<string>(nullable: false),
                    ImageProfessionName2 = table.Column<string>(nullable: false),
                    Strenght = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    BlockHit = table.Column<int>(nullable: false),
                    Resistance = table.Column<int>(nullable: false),
                    Inteligance = table.Column<int>(nullable: false),
                    Vitality = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false),
                    NameSpecialMove = table.Column<string>(maxLength: 150, nullable: false),
                    SpecialMoveTurnRequired = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ProfessionID);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 150, nullable: false),
                    AccountBan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileID);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 999999999, nullable: false),
                    WorkTime = table.Column<int>(nullable: false),
                    RevardGold = table.Column<int>(nullable: false),
                    RevardExp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkID);
                });

            migrationBuilder.CreateTable(
                name: "Guild_Buildings",
                columns: table => new
                {
                    GuildBuildingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuildID = table.Column<int>(nullable: false),
                    BuildingID = table.Column<int>(nullable: false),
                    BuildingID1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guild_Buildings", x => x.GuildBuildingID);
                    table.ForeignKey(
                        name: "FK_Guild_Buildings_Guilds_BuildingID",
                        column: x => x.BuildingID,
                        principalTable: "Guilds",
                        principalColumn: "GuildID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guild_Buildings_Buildings_BuildingID1",
                        column: x => x.BuildingID1,
                        principalTable: "Buildings",
                        principalColumn: "BuildingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaportGuilds",
                columns: table => new
                {
                    RaportGuildID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRaportGuild = table.Column<DateTime>(nullable: false),
                    GoldStolen = table.Column<int>(nullable: false),
                    Fame = table.Column<int>(nullable: false),
                    GuildID = table.Column<int>(nullable: true),
                    GuildID2 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaportGuilds", x => x.RaportGuildID);
                    table.ForeignKey(
                        name: "FK_RaportGuilds_Guilds_GuildID",
                        column: x => x.GuildID,
                        principalTable: "Guilds",
                        principalColumn: "GuildID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RaportGuilds_Guilds_GuildID2",
                        column: x => x.GuildID2,
                        principalTable: "Guilds",
                        principalColumn: "GuildID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRole = table.Column<string>(maxLength: 100, nullable: false),
                    GuildID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_Roles_Guilds_GuildID",
                        column: x => x.GuildID,
                        principalTable: "Guilds",
                        principalColumn: "GuildID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameItem = table.Column<string>(maxLength: 150, nullable: false),
                    RequiredLvl = table.Column<int>(nullable: false),
                    ItemPrice = table.Column<double>(nullable: false),
                    ImageItemName = table.Column<string>(maxLength: 150, nullable: false),
                    Damage = table.Column<int>(nullable: false),
                    Strenght = table.Column<int>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    BlockHit = table.Column<int>(nullable: false),
                    Resistance = table.Column<int>(nullable: false),
                    Inteligence = table.Column<int>(nullable: false),
                    Vitality = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false),
                    ProfessionID = table.Column<int>(nullable: false),
                    CategoryItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_Items_CategoryItems_CategoryItemID",
                        column: x => x.CategoryItemID,
                        principalTable: "CategoryItems",
                        principalColumn: "CategoryItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ProfessionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCharacter = table.Column<string>(maxLength: 150, nullable: false),
                    FamePoint = table.Column<int>(nullable: false),
                    Gold = table.Column<int>(nullable: false),
                    Strenght = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    BlockHit = table.Column<int>(nullable: false),
                    Resistance = table.Column<int>(nullable: false),
                    Inteligance = table.Column<int>(nullable: false),
                    Vitality = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false),
                    LevelID = table.Column<int>(nullable: true),
                    ProfessionID = table.Column<int>(nullable: true),
                    CurrentEquipmentID = table.Column<int>(nullable: true),
                    BackpackID = table.Column<int>(nullable: true),
                    WorkID = table.Column<int>(nullable: true),
                    ProfileID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterID);
                    table.ForeignKey(
                        name: "FK_Characters_Backpacks_BackpackID",
                        column: x => x.BackpackID,
                        principalTable: "Backpacks",
                        principalColumn: "BackpackID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_CurrentEquipment_CurrentEquipmentID",
                        column: x => x.CurrentEquipmentID,
                        principalTable: "CurrentEquipment",
                        principalColumn: "CurrentEquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Levels_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Levels",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ProfessionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Profiles_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "Profiles",
                        principalColumn: "ProfileID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Works_WorkID",
                        column: x => x.WorkID,
                        principalTable: "Works",
                        principalColumn: "WorkID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Backpack_Items",
                columns: table => new
                {
                    BackpackItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(nullable: true),
                    BackpackID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backpack_Items", x => x.BackpackItemID);
                    table.ForeignKey(
                        name: "FK_Backpack_Items_Backpacks_BackpackID",
                        column: x => x.BackpackID,
                        principalTable: "Backpacks",
                        principalColumn: "BackpackID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Backpack_Items_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurrentEquipment_Items",
                columns: table => new
                {
                    CurrentEquipmentItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(nullable: true),
                    CurrentEquipmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentEquipment_Items", x => x.CurrentEquipmentItemID);
                    table.ForeignKey(
                        name: "FK_CurrentEquipment_Items_CurrentEquipment_CurrentEquipmentID",
                        column: x => x.CurrentEquipmentID,
                        principalTable: "CurrentEquipment",
                        principalColumn: "CurrentEquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurrentEquipment_Items_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    FriendID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(maxLength: 150, nullable: false),
                    FriendID1 = table.Column<int>(nullable: true),
                    FriendID2 = table.Column<int>(nullable: true),
                    Character2CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.FriendID);
                    table.ForeignKey(
                        name: "FK_Friends_Characters_Character2CharacterID",
                        column: x => x.Character2CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friends_Characters_FriendID2",
                        column: x => x.FriendID2,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvitationsGuilds",
                columns: table => new
                {
                    InvitationsGuildID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(maxLength: 100, nullable: false),
                    GuildID = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvitationsGuilds", x => x.InvitationsGuildID);
                    table.ForeignKey(
                        name: "FK_InvitationsGuilds_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvitationsGuilds_Guilds_GuildID",
                        column: x => x.GuildID,
                        principalTable: "Guilds",
                        principalColumn: "GuildID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuildID = table.Column<int>(nullable: true),
                    RoleID = table.Column<int>(nullable: true),
                    CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_Members_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_Guilds_GuildID",
                        column: x => x.GuildID,
                        principalTable: "Guilds",
                        principalColumn: "GuildID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(maxLength: 150, nullable: false),
                    MessageText = table.Column<string>(maxLength: 999999999, nullable: false),
                    SendTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(maxLength: 150, nullable: false),
                    Sender = table.Column<int>(nullable: true),
                    Receiver = table.Column<int>(nullable: true),
                    Character2CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Messages_Characters_Character2CharacterID",
                        column: x => x.Character2CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Characters_Receiver",
                        column: x => x.Receiver,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    MissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMission = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 999999999, nullable: false),
                    MissionLvl = table.Column<int>(nullable: false),
                    RevardGold = table.Column<int>(nullable: false),
                    RevardExp = table.Column<int>(nullable: false),
                    RequiredQuantity = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 150, nullable: false),
                    CharacterID = table.Column<int>(nullable: false),
                    MonsterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.MissionID);
                    table.ForeignKey(
                        name: "FK_Missions_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Missions_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    StatisticID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FightWin = table.Column<int>(nullable: false),
                    FightLose = table.Column<int>(nullable: false),
                    GoldStolen = table.Column<int>(nullable: false),
                    Fame = table.Column<int>(nullable: false),
                    FightDate = table.Column<DateTime>(nullable: false),
                    CharacterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.StatisticID);
                    table.ForeignKey(
                        name: "FK_Statistics_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildChats",
                columns: table => new
                {
                    GuildChatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(maxLength: 999999999, nullable: false),
                    MessageDate = table.Column<DateTime>(nullable: false),
                    MemberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildChats", x => x.GuildChatID);
                    table.ForeignKey(
                        name: "FK_GuildChats_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backpack_Items_BackpackID",
                table: "Backpack_Items",
                column: "BackpackID");

            migrationBuilder.CreateIndex(
                name: "IX_Backpack_Items_ItemID",
                table: "Backpack_Items",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BackpackID",
                table: "Characters",
                column: "BackpackID",
                unique: true,
                filter: "[BackpackID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CurrentEquipmentID",
                table: "Characters",
                column: "CurrentEquipmentID",
                unique: true,
                filter: "[CurrentEquipmentID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_LevelID",
                table: "Characters",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ProfessionID",
                table: "Characters",
                column: "ProfessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ProfileID",
                table: "Characters",
                column: "ProfileID",
                unique: true,
                filter: "[ProfileID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_WorkID",
                table: "Characters",
                column: "WorkID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentEquipment_Items_CurrentEquipmentID",
                table: "CurrentEquipment_Items",
                column: "CurrentEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentEquipment_Items_ItemID",
                table: "CurrentEquipment_Items",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_Character2CharacterID",
                table: "Friends",
                column: "Character2CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_FriendID2",
                table: "Friends",
                column: "FriendID2");

            migrationBuilder.CreateIndex(
                name: "IX_Guild_Buildings_BuildingID",
                table: "Guild_Buildings",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_Guild_Buildings_BuildingID1",
                table: "Guild_Buildings",
                column: "BuildingID1");

            migrationBuilder.CreateIndex(
                name: "IX_GuildChats_MemberID",
                table: "GuildChats",
                column: "MemberID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvitationsGuilds_CharacterID",
                table: "InvitationsGuilds",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_InvitationsGuilds_GuildID",
                table: "InvitationsGuilds",
                column: "GuildID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryItemID",
                table: "Items",
                column: "CategoryItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProfessionID",
                table: "Items",
                column: "ProfessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_CharacterID",
                table: "Members",
                column: "CharacterID",
                unique: true,
                filter: "[CharacterID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Members_GuildID",
                table: "Members",
                column: "GuildID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_RoleID",
                table: "Members",
                column: "RoleID",
                unique: true,
                filter: "[RoleID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Character2CharacterID",
                table: "Messages",
                column: "Character2CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Receiver",
                table: "Messages",
                column: "Receiver");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_CharacterID",
                table: "Missions",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_MonsterID",
                table: "Missions",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_MonsterID1",
                table: "Monsters",
                column: "MonsterID1");

            migrationBuilder.CreateIndex(
                name: "IX_RaportGuilds_GuildID",
                table: "RaportGuilds",
                column: "GuildID");

            migrationBuilder.CreateIndex(
                name: "IX_RaportGuilds_GuildID2",
                table: "RaportGuilds",
                column: "GuildID2");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_GuildID",
                table: "Roles",
                column: "GuildID");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_CharacterID",
                table: "Statistics",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Backpack_Items");

            migrationBuilder.DropTable(
                name: "CurrentEquipment_Items");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Guild_Buildings");

            migrationBuilder.DropTable(
                name: "GuildChats");

            migrationBuilder.DropTable(
                name: "InvitationsGuilds");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "RaportGuilds");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "CategoryItems");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Backpacks");

            migrationBuilder.DropTable(
                name: "CurrentEquipment");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Guilds");
        }
    }
}

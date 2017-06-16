using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Audi')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('BMW')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('GM')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Mercedes')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('VW')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('A3', (SELECT ID FROM Makes WHERE Name='Audi'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('A4', (SELECT ID FROM Makes WHERE Name='Audi'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Q5', (SELECT ID FROM Makes WHERE Name='Audi'))");
    
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('120', (SELECT ID FROM Makes WHERE Name='BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('325i', (SELECT ID FROM Makes WHERE Name='BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('540Li', (SELECT ID FROM Makes WHERE Name='BMW'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Adam', (SELECT ID FROM Makes WHERE Name='GM'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Astra', (SELECT ID FROM Makes WHERE Name='GM'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Insignia', (SELECT ID FROM Makes WHERE Name='GM'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Audi', 'BMW', 'GM', 'Mercedes', 'VW')");
        }
    }
}

namespace APIRvMedical.Migrations
{
    using System.Data.Entity.Migrations;
    using APIRvMedical.Models;
    using MySql.Data.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<APIRvMedicalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
        }

        protected override void Seed(APIRvMedicalContext context)
        {
            // Seed data si nécessaire
        }
    }
}

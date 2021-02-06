namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrationElevenNote : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "CreateUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "CreateUtc");
        }
    }
}

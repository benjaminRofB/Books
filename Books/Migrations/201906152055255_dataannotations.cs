namespace Books.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataannotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(maxLength: 30));
            AlterColumn("dbo.Names", "SName", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Names", "SName", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
        }
    }
}

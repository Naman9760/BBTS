namespace BBTS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employees",
                c => new
                    {
                        eid = c.Int(nullable: false, identity: true),
                        ename = c.String(),
                        gender = c.String(),
                        city = c.String(),
                        salary = c.String(),
                    })
                .PrimaryKey(t => t.eid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.employees");
        }
    }
}

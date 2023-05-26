namespace ConsoleApp_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up() // veri tabanı içerisine tablo oluşturuyor. create işlemi
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        } // Tablo oluşumu end
        
        public override void Down() //işlemi iptal etmek için 
        {
            DropTable("dbo.Employees");
        }
    }
}

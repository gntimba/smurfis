namespace smurfis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        ID_Child = c.Guid(nullable: false),
                        cName = c.String(maxLength: 50),
                        cSurname = c.String(maxLength: 50),
                        cAddress = c.String(maxLength: 50),
                        cSpecialNeed = c.String(maxLength: 50),
                        ID_parent = c.Guid(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Child);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID_Employee = c.Guid(nullable: false),
                        eName = c.String(maxLength: 50),
                        eSurname = c.String(maxLength: 50),
                        eAddress = c.String(maxLength: 50),
                        eJobDescription = c.String(maxLength: 50),
                        eJobTitle = c.String(maxLength: 50),
                        ePhoneNumber = c.String(maxLength: 50),
                        email = c.String(maxLength: 50),
                        ePassword = c.String(maxLength: 50),
                        Salt = c.Binary(maxLength: 16, fixedLength: true),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Employee);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ID_parent = c.Guid(nullable: false),
                        pName = c.String(maxLength: 50),
                        pSurname = c.String(maxLength: 50),
                        pAdresss = c.String(maxLength: 50),
                        pPhoneNumber = c.String(maxLength: 50),
                        ID_Communication = c.Guid(),
                        eMail = c.String(maxLength: 50),
                        password = c.String(maxLength: 50),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_parent);
            
            CreateTable(
                "dbo.PreSchools",
                c => new
                    {
                        ID_PresSchool = c.Guid(nullable: false),
                        pAddress = c.String(maxLength: 50),
                        pOperationType = c.String(maxLength: 50),
                        pOperationNumber = c.String(maxLength: 50),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PresSchool);
            
            CreateTable(
                "dbo.Secretaries",
                c => new
                    {
                        ID_Secretary = c.Guid(nullable: false),
                        ID_Employee = c.Guid(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Secretary);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID_teacher = c.Guid(nullable: false),
                        ID_Employee = c.Guid(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_teacher);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Secretaries");
            DropTable("dbo.PreSchools");
            DropTable("dbo.Parents");
            DropTable("dbo.Employee");
            DropTable("dbo.Children");
        }
    }
}

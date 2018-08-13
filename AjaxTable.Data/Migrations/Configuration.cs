namespace AjaxTable.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AjaxTable.Data.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AjaxTable.Data.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Employees.AddOrUpdate(
                new Employee { Name = "Phạm Anh Thông",Salary = 350000,CreateDate = DateTime.Now, Status = true},
                new Employee { Name = "Trịnh Thị Vân Anh", Salary = 350000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Bảo Anh", Salary = 500000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Đàm Tuyết Dinh", Salary = 750000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Phạm Bảo Khang", Salary = 500000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Trương Thị Hạ Vân", Salary = 350000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Nguyễn Như Ngọc", Salary = 500000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Trần Huỳnh Như", Salary = 350000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Ken Phạm", Salary = 450000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Trịnh Thị Diễm Hương", Salary = 650000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Phạm Hoàng Minh", Salary = 250000, CreateDate = DateTime.Now, Status = true },
                new Employee { Name = "Đàm Tuyết Dinh1", Salary = 150000, CreateDate = DateTime.Now, Status = true }
                );

            context.SaveChanges();
        }
    }
}

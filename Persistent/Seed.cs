using System.Diagnostics;
using Domin;
namespace Persistent
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (!context.Activities.Any())
            {

                var activities = new List<Activiti>
                {
                    new Activiti
                    {
                        Title = "پست 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "نوشیدنی",
                        City = "شیراز",
                        Venue = "پل معالی آباد"
                    },
                    new Activiti
                    {
                        Title = "پست 2",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "فرهنگی",
                        City = "تبریز",
                        Venue = "مسجد کبود"
                    },
                    new Activiti
                    {
                        Title = "پست 3",
                        Date = DateTime.Now.AddMonths(1),
                       Description = "این پست برای تست ایجاد شده است",
                        Category = "موسیقی",
                        City = "اصفهان",
                        Venue = "پل سی و سه پل"
                    },
                    new Activiti
                    {
                        Title = "پست 4",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "غذا",
                        City = "اصفهان",
                        Venue = "پل خاجو"
                    },
                    new Activiti
                    {
                        Title = "پست 5",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "نوشیدنی",
                        City = "شیراز",
                        Venue = "حافظیه"
                    },
                    new Activiti
                    {
                        Title = "پست 6",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "فرهنگی",
                        City = "شیراز",
                        Venue = "سعدیه"
                    },
                    new Activiti
                    {
                       Title = "پست 7",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "نوشیدنی",
                        City = "شیراز",
                        Venue = "زند"
                    },
                    new Activiti
                    {
                       Title = "پست 8",
                        Date = DateTime.Now.AddMonths(6),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "موسیقی",
                        City = "شیراز",
                        Venue = "ملاصدرا"
                    },
                    new Activiti
                    {
                       Title = "پست 9",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "سفر",
                        City = "تهران",
                        Venue = "تجریش"
                    },
                    new Activiti
                    {
                        Title = "پست 10",
                        Date = DateTime.Now.AddMonths(8),
                        Description = "این پست برای تست ایجاد شده است",
                        Category = "نوشیدنی",
                        City = "شیراز",
                        Venue = "باغ ارم"
                    }
                };

                await context.Activities.AddRangeAsync(activities);
                await context.SaveChangesAsync();
            }
        }
    }
}
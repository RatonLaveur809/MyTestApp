using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Core
{
    public class MainService : IMainService
    {
        public void DoWork()
        {
            using (MyContext db = new MyContext())
            {
                // создаем два объекта User
                SomeEntity e1 = new SomeEntity { Text = "Hi" };
                SomeEntity e2 = new SomeEntity { Text = "looser" };

                // добавляем их в бд
                db.MyEntities.Add(e1);
                db.MyEntities.Add(e2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.MyEntities;
                Console.WriteLine("Список объектов:");
                foreach (SomeEntity sEntity in users)
                {
                    Console.Write(sEntity.Text + ", ");
                }
            }
            Console.Read();
        }
    }
}

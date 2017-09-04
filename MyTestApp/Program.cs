using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Microsoft.Practices.Unity;
using Data;

namespace MyTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new UnityContainer();
            container
               .RegisterType<IMainService, MainService>()
               .RegisterType<IMyContext, MyContext>();
            var mainController = container.Resolve<IMainService>();

            mainController.DoWork();
        }
    }
}

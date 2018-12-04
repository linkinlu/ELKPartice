using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELK
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            var i = 0;
            while (true)
            {
                //Console.WriteLine("1 info , 2 warning , 3 error");
                //var type = Console.ReadLine();
                //if (string.IsNullOrEmpty(type))
                //{
                //    continue;
                //}
                //Input(type);

                //测试下不断写入error的性能
                _log.Error(string.Format("这是Rispro系统 error log,{0}",i), new Exception("error"));
                i++;
            }
        }

        private static void Input(string type)
        {
            Console.WriteLine("请输入你要打印出来的消息");
            var input = Console.ReadLine();
            switch (type)
            {
                case "1":
                    _log.Info(string.Format("这是预约系统 Info log,你输入的是{0}", input));
                    break;
                case "2":
                    _log.Warn(string.Format("这是billing系统 warning log,你输入的是{0}", input));
                    break;
                case "3":
                    _log.Error(string.Format("这是Rispro系统 error log,你输入的是{0}", input), new Exception(input));
                    break;
                default:
                    break;
            }
        }
    

    }
}

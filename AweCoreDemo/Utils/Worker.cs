using System;
using System.Threading;
using AweCoreDemo.Models;

namespace AweCoreDemo.Utils
{
    public class Worker
    {
        private static Timer timer;

        public void Start()
        {
            var interval = 60 * 1000 * 30;
            timer = new Timer(Execute, null, interval, interval);
        }

        protected void Execute(object sender)
        {
            try
            {
                Db.RestoreItems();
                Cache.RemoveExpired();
            }
            catch (Exception)
            {
                //ex.Log();
            }
        }
    }
}
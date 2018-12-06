using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using log4net.Config;

namespace Tourist.Models
{
    public class Logger
    {
        static Logger()
        {
            XmlConfigurator.Configure();
        }
        
        public static ILog For(object LoggedObject)
        {
            if (LoggedObject != null)
                return For(LoggedObject.GetType());

            return For(null);
        }

        public static ILog For(Type ObjectType)
        {
            if (ObjectType != null)
                return LogManager.GetLogger(ObjectType.Name);

            return LogManager.GetLogger(string.Empty);
        }
    }
}
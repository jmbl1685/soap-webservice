using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SOAPWebServices.Core.FirebaseConnection
{
    public static class Connection
    {
        private static IFirebaseConfig Config() => new FirebaseConfig
        {
            AuthSecret = ConfigurationManager.AppSettings["firebase_authsecret"].ToString(),
            BasePath = ConfigurationManager.AppSettings["firebase_basepath"].ToString()
        };

        public static IFirebaseClient Client() => new FirebaseClient(Config());

    }

}

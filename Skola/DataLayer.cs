using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Skola.Mapiranje;

namespace Skola
{
   public class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();


        //funkcija na zahtev otvara sesiju
        public static ISession GetSession()
        {
            //ukoliko session factory nije kreiran
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        //konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleClientConfiguration.Oracle10
               .ShowSql()
                 .ConnectionString(c =>
                   c.Is("Data Source=160.99.12.92:1521/SBP_PDB;" +
                        "User Id=" + Constants.User + ";" +
                        "Password=" + Constants.Password));

                return Fluently.Configure()
                    .Database(cfg)
                    //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Skola.Mapiranja.OcenaMapiranja>())
                    //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Skola.Mapiranje.ZaposlenMapiranje>())
                      .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Skola.Mapiranje.UcenikMapiranje>())
                    //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Skola.Mapiranja.OstaleSkoleMapiranja>())
                    //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Skola.Mapiranja.PredmetMapiranja>())
                    //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Skola.Mapiranja.RoditeljiMapiranja>())
                    //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Skola.Mapiranja.SektorMapiranja>())
                    // .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Skola.Mapiranja.SmerMapiranja>())
                    .BuildSessionFactory();


            }
            catch (Exception ec)
            {

                System.Windows.Forms.MessageBox.Show(ec.InnerException.Message);
                return null;
            }

        }
    }
}

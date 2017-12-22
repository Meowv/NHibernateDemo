using NHibernate;
using NHibernate.Cfg;

namespace Shop.Data
{
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        /// <summary>
        /// 创建ISessionFactory
        /// </summary>
        public static ISessionFactory SessionFactory
        {
            get
            {
                //配置ISessionFactory
                return sessionFactory ?? (new Configuration()).Configure().BuildSessionFactory();
            }
        }
    }
}

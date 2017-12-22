using NHibernate;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Shop.Data
{
    public class CustomersData
    {
        /// <summary>
        /// 根据条件得到客户端信息集合
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns>客户信息集合</returns>
        public IList<Customers> GetCustomerList(Expression<Func<Customers, bool>> where)
        {
            try
            {
                using (ISession session = NHibernateHelper.SessionFactory.OpenSession())
                {
                    return session.Query<Customers>().Select(x => new Customers
                    {
                        CustomerID = x.CustomerID,
                        ContactName = x.ContactName,
                        City = x.City,
                        Address = x.Address,
                        Phone = x.Phone,
                        CompanyName = x.CompanyName,
                        Country = x.Country
                    }).Where(where).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

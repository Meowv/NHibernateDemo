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

        /// <summary>
        /// 获取单条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customers GetById(string id)
        {
            using (ISession session = NHibernateHelper.SessionFactory.OpenSession())
            {
                Customers customers = session.Get<Customers>(id);
                return customers;
            }
        }

        #region 增删改

        public bool Insert(Customers customers)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                var identifier = session.Save(customers);
                session.Flush();
                return string.IsNullOrEmpty(identifier.ToString());
            }
        }

        public void Update(Customers customers)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                session.SaveOrUpdate(customers);
                session.Flush();
            }
        }

        public void Delete(string id)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                var customer = session.Get<Customers>(id);
                session.Delete(customer);
                session.Flush();
            }
        }

        #endregion

    }
}

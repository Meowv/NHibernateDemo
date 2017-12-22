using Shop.Data;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Shop.Business
{
    public class CustomersBusiness
    {
        private CustomersData customersData;
        public CustomersBusiness()
        {
            customersData = new CustomersData();
        }

        /// <summary>
        /// 根据条件得到客户信息集合
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns>客户信息集合</returns>
        public IList<Customers> GetCustomersList(Expression<Func<Customers,bool>> where)
        {
            return customersData.GetCustomerList(where);
        }

        /// <summary>
        /// 获取单条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customers GetById(string id)
        {
            return customersData.GetById(id);
        }

        /// <summary>
        /// 增
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Insert(Customers customer)
        {
            return customersData.Insert(customer);
        }

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="customer"></param>
        public void Update(Customers customer)
        {
            customersData.Update(customer);
        }

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            customersData.Delete(id);
        }
    }
}

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Highway.Data;
using SimpleCustomerDatabase.Domain;

namespace SimpleCustomerDatabase.Web.Persistence
{
    public class FindById : Scalar<Customer>
    {
        public FindById(int id)
        {
            ContextQuery = c => c.AsQueryable<Customer>()
                .First(e => e.Id == id);
        }
    }
}
using SimpleCustomerDatabase.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Highway.Data;

namespace SimpleCustomerDatabase.Web.Persistence
{
    public class FindCustomerByLastName : Query<Customer>
    {
        public FindCustomerByLastName(string lastName)
        {
            ContextQuery = c => c.AsQueryable<Customer>()
                .Where(e => e.LastName == lastName);
        }

    }
}
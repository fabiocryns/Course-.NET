﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqModule.Model.Queries {
    public class AnyQuery : Query {
        public AnyQuery() : base("Senior hires", "Checks if an employee was over 50 years of age when hired.", QueryTypes.Quantifiers) { }

        public override object Execute() {
            return ObjectDatabase.Employees.Any(e => {
                TimeSpan difference = (TimeSpan)(e.HireDate - e.BirthDate);
                if(difference.TotalDays > 18250)
                {
                    return true;
                } else
                {
                    return false;
                }
            } );
        }
    }

    public class AllQuery : Query {
        public AllQuery() : base("Supplier phone numbers", "Checks whether all suppliers have a phone number.", QueryTypes.Quantifiers) { }

        public override object Execute() {
            return ObjectDatabase.Suppliers.All(s => s.Phone != null);
        }
    }

    public class ContainsQuery : Query {
        public ContainsQuery() : base("Product ordered?", "Checks whether the product with ID 11 has been ordered.", QueryTypes.Quantifiers) { }

        public override object Execute() {
            return ObjectDatabase.OrderDetails.Any(od => od.ProductID == 11);
        }
    }
}

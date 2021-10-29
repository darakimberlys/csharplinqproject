using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWithLambda.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Decimal TotalValue { get; set; }
    }
}

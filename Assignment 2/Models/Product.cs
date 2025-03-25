using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int product_quantity { get; set; }
    }
}
/*
create table product (
product_id int primary key,
product_name varchar(50) not null,
product_quantity int not null
);
*/
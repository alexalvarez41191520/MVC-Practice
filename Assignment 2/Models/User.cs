using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class User
    {
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_email { get; set; }
    }
}
/*
create table customer (
customer_id int primary key,
customer_name varchar(50) not null,
customer_email varchar(50) not null
);

INSERT INTO customer (customer_id, customer_name, customer_email)
VALUES (1, 'user', 'email');
*/
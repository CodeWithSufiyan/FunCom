using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.DB
{
    public class CustomerModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Birthday { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal_Code { get; set; }
        public string Country { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string Voice_Mail { get; set; }
        public string Password { get; set; }
        public string Name_on_Card { get; set; }
        public string Credit_Card_Number { get; set; }
        public string CVV { get; set; }
        public string Card_Exp_Month { get; set; }
        public string Card_Exp_Year { get; set; }
        public string Billing_Person_Name { get; set; }
        public string Billing_Address { get; set; }
        public string Billing_City { get; set; }
        public string Billing_State { get; set; }
        public string Billing_PostalCode { get; set; }
        public string Billing_Country { get; set; }
        public string Shipping_Address { get; set; }
        public string Shipping_City { get; set; }
        public string Shipping_State { get; set; }
        public string Shipping_PostalCode { get; set; }
        public string Shipping_Country { get; set; }
        public string Date_Entered { get; set; }
    }
}

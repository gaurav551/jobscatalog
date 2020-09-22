using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace JobsCatalog.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : Controller
    {
        [HttpPost]
        [Route("make-payment")]
        public IActionResult MakePayment([FromBody] Payment payment)
        {
            System.Console.WriteLine($"{payment.UserName} sent {payment.Amount} to {payment.AccountName}");

            return Ok(payment);
        }
        [HttpGet]



        [HttpGet]
        public Payment GetPaymentById(int id)
        {
            if (!Authenticate())
            {
                return null;
            }
            var payment = GetPayments();
            var data = payment.FirstOrDefault(x => x.Id == id);
            return data;
        }
        public List<Payment> GetPayments()
        {
            var a = new List<Payment>();
            for (int i = 1; i < 100; i++)
            {


                a.Add(new Payment() { Id = i, UserName = "Gaurav" + i, Amount = 12 * i, AccountName = "y8909" + i });
            }
            return a;


        }
        public bool Authenticate()
        {
            var allowedKeys = new[] { "Secret@123", "Secret#12", "SecretABC" };
            StringValues key = Request.Headers["Key"];
            int count = (from t in allowedKeys where t == key select t).Count();
          
            return count == 0 ? false : true;
        }


    }
    public class Payment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string AccountName { get; set; }
        public int Amount { get; set; }


    }

}
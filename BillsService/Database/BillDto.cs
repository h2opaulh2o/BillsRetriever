using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class BillDto
    {
        public int Id { get; set; }

        public int ProviderId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime PayDate { get; set; }

        public double Price { get; set; }

        public BillProviderDto BillProvider { get; set; }

        public static BillDto FromBill(Bill bill)
        {
            return new BillDto()
            {
                Id = bill.Id,
                ProviderId = bill.ProviderId,
                StartDate = bill.StartDate,
                EndDate = bill.EndDate,
                PayDate = bill.PayDate,
                Price = bill.Price
            };
        }

        public static Bill ToBill(BillDto bill)
        {
            return new Bill()
            {
                Id = bill.Id,
                ProviderId = bill.ProviderId,
                StartDate = bill.StartDate,
                EndDate = bill.EndDate,
                PayDate = bill.PayDate,
                Price = bill.Price
            };
        }
    }
}

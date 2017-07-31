using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class BillRepository
    {
        public BillDto Get(int id)
        {
            var context = new BillModel();
            var result = context.Bills.FirstOrDefault((x) => x.Id == id);
           
            return BillDto.FromBill(result);

        }

        public BillDto[] Get()
        {
            var context = new BillModel();
            var result = context.Bills.Select((x)=>BillDto.FromBill(x)).ToArray();
            return result;
        }

        public int Create(BillDto bill)
        {
            var newBill = BillDto.ToBill(bill);
            var context = new BillModel();
            context.Bills.Add(newBill);
            context.SaveChanges();
            return newBill.Id;
        }

        public void Update(BillDto bill)
        {
            var context = new BillModel();
            context.Bills.AddOrUpdate(BillDto.ToBill(bill));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var context=new BillModel();
            var bill = context.Bills.FirstOrDefault((x) => x.Id == id);
            context.Bills.Remove(bill);
            context.SaveChanges();
        }
    }
}

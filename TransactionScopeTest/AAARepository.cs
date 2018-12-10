using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransactionScopeTest
{
    public class AAARepository
    {
        private readonly TestDbContext _ctx;

        public AAARepository(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Insert()
        {
            var aaa = new AAA();
            aaa.Name = "Foo";
            aaa.Age = 20;
            _ctx.AAA.Add(aaa);
            _ctx.SaveChanges();
        }

        public IList<AAA> GetAll()
        {
            return _ctx.AAA.ToArray();
        }
    }
}
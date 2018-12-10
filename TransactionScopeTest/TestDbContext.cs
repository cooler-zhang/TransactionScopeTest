using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Web;

namespace TransactionScopeTest
{
    public class TestDbContext : DbContext, IDisposable
    {
        public DbSet<AAA> AAA { get; set; }

        private TransactionScope _transactionScope;

        public TestDbContext()
            : base()
        {
            var transactionScope = new TransactionOptions();
            transactionScope.IsolationLevel = IsolationLevel.Snapshot;
            _transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionScope);
        }

        public new void Dispose()
        {
            this.SaveChanges();
            _transactionScope.Complete();
            base.Dispose();
        }
    }
}
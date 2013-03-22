using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OrgPort.DB.Initializers
{
    public class DropCreateIfModelChangesOrgPortDBInitializer<TContext> : OrgPortDBInitializer<TContext> where TContext:DbContext
    {
        public override void InitializeDatabase(TContext context)
        {
            if (context == null)
            {
                throw new Exception("OrgPort database context is null");
            }
            var replacedContext = ReplaceSqlCeConnection(context);
            bool databaseExists;
            using (new TransactionScope(TransactionScopeOption.Suppress))
            {
                databaseExists = replacedContext.Database.Exists();
            }

            if (databaseExists)
            {
                if (!context.Database.CompatibleWithModel(throwIfNoMetadata: false))
                {
                    throw new InvalidOperationException(
                        string.Format(
                            "The model backing the '{0}' context has changed since the database was created. Either manually delete/update the database, or call Database.SetInitializer with an IDatabaseInitializer instance. For example, the DropCreateDatabaseIfModelChanges strategy will automatically delete and recreate the database, and optionally seed it with new data.",
                            context.GetType().Name));
                }
            }
            else
            {
                context.Database.Create();
                this.Seed(context);
                context.SaveChanges();
            }
        }
    }
}

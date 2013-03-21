﻿using OrgPort.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgPort.DB
{
    class RepositoryInitializer:IRepositoryInitializer
    {
        IUnitOfWork unitOfWork;

        public RepositoryInitializer(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new Exception("Unity of work is null");
            }
            this.unitOfWork = unitOfWork;
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");

            //Database.SetInitializer(new DropCreateIfModelChangesSqlCeInitializer<MileageStatsDbContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrgPortDBContext>());
        }


        public OrgPortDBContext Context
        {
            get { return (OrgPortDBContext)this.unitOfWork; }
        }

        public void Initialize()
        {
            
        }
    }
}


using Labs.Data;
using Labs.Models;
using Labs.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Labs.UOW
{
    public class UnitofWork : DbContext
    {
        ContextApp context = new ContextApp();
        Repository<Computers> computerRepository;

        public Repository<Computers> ComputerRepository
        {

            get
            {
                if (computerRepository == null)
                {
                   computerRepository = new Repository<Computers>(context);

                }
                return computerRepository;
            }


        }

        public void Commit()
        {
            context.SaveChanges();
        }




    }
}

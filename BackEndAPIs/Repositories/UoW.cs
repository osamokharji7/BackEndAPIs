using dbBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dbBackend.Repositories
{

    public class UoW : IUoW
    {
        public UoW (masterContext con)
        {
            context = con;
        }
        private masterContext context;
        public static IGeneralRepository<User> userRepository { get; set; }
        public static IGeneralRepository<State> stateRepository { get; set; }
        public static IGeneralRepository<City> cityRepository { get; set; }
    }
    public IGeneralRepository userRepository
    {
        get { return userRepository = userRepository ?? new GeneraleRepository(context); }
    }



    public void Commit()
    {
        context.SaveChanges();
    }

    public void Rollback()
    {
        context.Dispose();
    }
}
}

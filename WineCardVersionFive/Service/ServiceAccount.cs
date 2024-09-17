using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardVersionFive.Entities;

namespace WineCardVersionFive.Service
{
    public class ServiceAccount
    {
        private readonly DbContextWineCardVersionFive _context;

        public ServiceAccount(DbContextWineCardVersionFive context)
        {
            _context = context;
        }

        public Account FindAccount(string username)
        {
            return _context.Accounts.AsNoTracking().FirstOrDefault(u => u.Username == username);
        }
    }
}

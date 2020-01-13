using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AuthJWT_WebApi.Entities;

namespace AuthJWT_WebApi.Data
{
    public class AuthJWT_WebApiContext : DbContext
    {
        public AuthJWT_WebApiContext (DbContextOptions<AuthJWT_WebApiContext> options)
            : base(options)
        {
        }

        public DbSet<AuthJWT_WebApi.Entities.User> User { get; set; }
    }
}

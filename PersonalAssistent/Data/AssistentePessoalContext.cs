using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PersonalAssistent.Data
{
    public class AssistentePessoalContext : IdentityDbContext
    {
        public AssistentePessoalContext(DbContextOptions<AssistentePessoalContext> options)
            : base(options)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using demo_api.Models;
using Microsoft.EntityFrameworkCore;

namespace demo_api.Data;

public partial class TestDeployContext : DbContext
{
    public TestDeployContext()
    {
    }

    public TestDeployContext(DbContextOptions<TestDeployContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

}

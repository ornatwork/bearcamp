﻿


//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;



namespace BearEF
{

public partial class bearcampEntities : DbContext
{
    public bearcampEntities()
        : base("name=bearcampEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Donor> Donors { get; set; }



    public DbSet<User> Users { get; set; }

    public DbSet<Donation> Donations { get; set; }

        public DbSet<CampaignEvent> CampaignEvents { get; set; }
        public DbSet<Employee> Employees { get; set; }
    public DbSet<Campaign> Campaigns { get; set; }



    public DbSet<Employee> Employees { get; set; }

}

}


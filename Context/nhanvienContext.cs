using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BaiThi.Models;

namespace BaiThi.Context
{
    public class nhanvienContext :DbContext
    {
        public nhanvienContext() : base("WingtipToys")
        {
        }
        public DbSet<nhanvien> nhanviens { get; set; }
    }
}
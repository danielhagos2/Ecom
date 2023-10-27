﻿using Ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository.IRepository
{
    public interface ICompany : IRepository<Company>
    {
        void Update(Company company);
    }
}

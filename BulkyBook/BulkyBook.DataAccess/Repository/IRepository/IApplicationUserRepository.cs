using System;
using System.Collections.Generic;
using System.Text;
using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository:IRepository<ApplicationUser>
    {
        

    }
}

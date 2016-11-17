using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smile_Shop.ViewModels.Infrastructure;
using Smile_Shop.Data.Models;

namespace Smile_Shop.ViewModels.User
{
    public class UserTypeVM : IMapFrom<UserType>
    {
        public int Id { get; set; }

        public string Type { get; set; }
    }
}

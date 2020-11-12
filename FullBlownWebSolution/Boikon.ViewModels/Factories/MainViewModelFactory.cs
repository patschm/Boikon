using Boikon.Entities;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Boikon.ViewModels.Factories
{
    public abstract class MainViewModelFactory
    {
        public abstract Task<MainViewModel> CreateModelAsync(int page = 0, int size = 10);
        public abstract Task<bool> InsertAsync(Person p);
    }
}

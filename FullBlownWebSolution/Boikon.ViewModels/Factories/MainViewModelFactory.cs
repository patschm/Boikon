using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boikon.ViewModels.Factories
{
    public abstract class MainViewModelFactory
    {
        public abstract Task<MainViewModel> CreateModelAsync(int page = 0, int size = 10);
    }
}

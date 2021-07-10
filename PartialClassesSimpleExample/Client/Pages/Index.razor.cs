using PartialClassesSimpleExample.Client.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesSimpleExample.Client.Pages
{
    public partial class Index
    {
        private List<Data> d;
        protected override void OnInitialized()
        {
            d = new List<Data>()
            {
                new Data(){Id=101,Name="Amit",Address="Noida"},
                new Data(){Id=101,Name="Amit",Address="Noida"},
                new Data(){Id=101,Name="Amit",Address="Noida"},
                new Data(){Id=101,Name="Amit",Address="Noida"},
                new Data(){Id=101,Name="Amit",Address="Noida"},
                new Data(){Id=101,Name="Amit",Address="Noida"}
            };
        }
    }
}

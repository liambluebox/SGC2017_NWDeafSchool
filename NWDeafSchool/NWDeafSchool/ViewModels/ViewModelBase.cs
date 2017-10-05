using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmHelpers;
using Xamarin.Forms;

namespace NWDeafSchool
{
    public class ViewModelBase : BaseViewModel
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>() ?? new MockDataStore();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xfm.Models;

namespace Xfm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        
        public DetailPage(Item gangMember)
        {
            InitializeComponent();
            BindingContext = gangMember;
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xfm.ViewModels
{
    public abstract class BaseViewModel : BindableObject  
    {
        private bool isBusy;

        public bool IsBusy
        {
            get => isBusy; 
            set { isBusy = value; OnPropertyChanged(); } // onPro avisa que o valr foi alterado

        }

        public bool IsNotBusy => !IsBusy;

        public async Task ExecuteBusyAction(Func<Task> theBuysAction)
        {
            if (isBusy)
                return;
            try
            {
                isBusy = true;
                await theBuysAction();
            }
            catch (Exception ex)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex);

#endif
                throw;
            }
            finally
            {
                isBusy = false;
            }
        }

        public virtual Task Initialize()
            => Task.CompletedTask;
    }
}

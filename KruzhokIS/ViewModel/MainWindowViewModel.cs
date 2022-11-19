using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KruzhokIS.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        public Сотрудник1 Account { get; private set; }
        public ObservableCollection<ViewModelBase> ViewModelsCollection { get; private set; }

        private Page _currentPage;

        public Page СurrentPage
        {
            get => _currentPage;
            set
            {
                if(_currentPage != value)
                {
                    _currentPage = value;
                    PropertyChange("CurrentPage");
                }
            }
        }

        public MainWindowViewModel()
        {
            Account = AuthorizationViewModel.Account;
            ViewModelsCollection = new ObservableCollection<ViewModelBase>();
            ViewModelsCollection.Add(new DirektorViewModel());
            if (Account.id_должности != 1)
                ViewModelsCollection.Add(new ViewModelBase());
            if (Account.id_должности == 2)
                ViewModelsCollection.Add(new ViewModelBase());
            SelectedViewModel = ViewModelsCollection[0];
        }

    }
}

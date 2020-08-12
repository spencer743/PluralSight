using FriendOrganizer.Model;
using FriendOrganizer.Ui.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.Ui.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private readonly IFriendDataService _dataService;

        private Friend _friend;

        public FriendDetailViewModel(IFriendDataService dataService)
        {
            _dataService = dataService;
        }



        public Friend Friend
        {
            get { return _friend; }
            private set
            {
                _friend = value;
                OnPropertyChanged();
            }
        }


        public async Task LoadAsync(int friendId)
        {
            Friend = await _dataService.GetByIDAsync(friendId);

        }
    }
}

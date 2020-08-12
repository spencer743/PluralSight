using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.Ui.Data
{
    public interface IFriendDataService
    {
        Task<List<Friend>> GetAllAsync();

        Task<Friend> GetByIDAsync(int friendId);
        Task SaveAsync(Friend friend);
    }
}
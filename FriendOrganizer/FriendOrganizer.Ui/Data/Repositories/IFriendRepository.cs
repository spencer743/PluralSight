using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.Ui.Data.Repositories
{
    public interface IFriendRepository
    {
        Task<List<Friend>> GetAllAsync();

        Task<Friend> GetByIDAsync(int friendId);
        Task SaveAsync();
    }
}
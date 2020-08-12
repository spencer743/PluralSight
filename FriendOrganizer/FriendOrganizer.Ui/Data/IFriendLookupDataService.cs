using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.Ui.Data
{
    public interface IFriendLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetFriendLookupAsync();
    }
}
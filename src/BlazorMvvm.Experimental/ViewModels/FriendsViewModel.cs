using System.Collections.Generic;
using BlazorMvvm.Experimental.Helpers;

namespace BlazorMvvm.Experimental.ViewModels
{
    public class FriendsViewModel : IHandleFriends
    {
        public FriendsViewModel()
        {
            AddNewFriendCommand = new DelegateCommand(_ => AddNewFriend(), _ => !string.IsNullOrEmpty(NewFriendName));
            Friends = new List<FriendViewModel>();
        }

        private void AddNewFriend()
        {
            Friends.Add(new FriendViewModel(NewFriendName, this));
            NewFriendName = string.Empty;
        }
        public List<FriendViewModel> Friends { get; }
        public string NewFriendName { get; set; }
        public DelegateCommand AddNewFriendCommand { get; }
        public void RemoveFriend(FriendViewModel friend)
        {
            Friends.Remove(friend);
        }
    }
}
using System.Windows.Input;
using BlazorMvvm.Experimental.Helpers;

namespace BlazorMvvm.Experimental.ViewModels
{
    public class FriendViewModel
    {
        public FriendViewModel(string name, IHandleFriends friendsHandler)
        {
            Name = name;
            RemoveFriendCommand = new DelegateCommand(_ => friendsHandler?.RemoveFriend(this));
        }

        public string Name { get; }
        public ICommand RemoveFriendCommand { get; }
    }
}
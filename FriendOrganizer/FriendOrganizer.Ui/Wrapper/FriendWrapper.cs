using FriendOrganizer.Model;
using System;

namespace FriendOrganizer.Ui.Wrapper
{
    public class FriendWrapper : NotifyDataErrorInfoBase
    {
        public FriendWrapper(Friend model)
        {
            Model = model;
        }

        public Friend Model { get; }

        public int Id => Model.Id;

        public string FirstName
        {
            get => Model.FirstName;
            set
            {
                Model.FirstName = value;
                OnPropertyChanged();
                ValidateProperty(nameof(FirstName));
            }
        }

        private void ValidateProperty(string propertyName)
        {
            ClearErrors(propertyName);
            switch (propertyName)
            {
                case nameof(FirstName):
                    if (string.Equals(FirstName, "Robot", StringComparison.OrdinalIgnoreCase))
                    {
                        AddError(propertyName, "Robot is not a valid first name");
                    }
                    break;
            }
        }

        public string LastName
        {
            get => Model.LastName;
            set
            {
                Model.LastName = value;
                OnPropertyChanged();
            }
        }


        public string Email
        {
            get { return Model.Email; }
            set
            {
                Model.Email = value;
                OnPropertyChanged();
            }
        }


    }

}

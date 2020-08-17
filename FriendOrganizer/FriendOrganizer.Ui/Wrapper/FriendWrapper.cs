using FriendOrganizer.Model;
using System;

namespace FriendOrganizer.Ui.Wrapper
{

    public class FriendWrapper : ModelWrapper<Friend>
    {
        public FriendWrapper(Friend model) : base(model)
        {
        }

        public int Id => Model.Id;

        public string FirstName
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
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
            get => GetValue<string>();
            set => SetValue(value);
        }


        public string Email
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


    }

}

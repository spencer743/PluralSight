using FriendOrganizer.Model;
using System;
using System.Collections.Generic;

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
            set => SetValue(value);
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

        protected override IEnumerable<string> ValidateProperty(string propertyName)
        {
            switch (propertyName)
            {
                case nameof(FirstName):
                    if (string.Equals(FirstName, "Robot", StringComparison.OrdinalIgnoreCase))
                    {
                        yield return "Robot is not a valid first name";
                    }
                    break;
            }
        }


        }

}

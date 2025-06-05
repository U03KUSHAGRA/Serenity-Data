using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SerenityData.SerenityData
{
    public partial class CustomerAddressesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SerenityData.SerenityData.CustomerAddressesEditor";

        public CustomerAddressesEditorAttribute()
            : base(Key)
        {
        }
    }
}

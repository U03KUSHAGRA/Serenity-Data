using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SerenityData.SerenityData
{
    public partial class CustomerDevicesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SerenityData.SerenityData.CustomerDevicesEditor";

        public CustomerDevicesEditorAttribute()
            : base(Key)
        {
        }
    }
}

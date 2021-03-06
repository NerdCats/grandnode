﻿using Grand.Web.Framework.Mvc;
using Grand.Web.Models.Common;

namespace Grand.Web.Models.Customer
{
    public partial class CustomerAddressEditModel : BaseGrandModel
    {
        public CustomerAddressEditModel()
        {
            this.Address = new AddressModel();
        }
        public AddressModel Address { get; set; }
    }
}
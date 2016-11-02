using System;

namespace TeduShop.Model.Models
{
    internal class ForeignAttribute : Attribute
    {
        private string v;

        public ForeignAttribute(string v)
        {
            this.v = v;
        }
    }
}
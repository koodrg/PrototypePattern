using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Address
    {
        public string Province { get; set; }

        public string Ward { get; set; }

        public string District { get; set; }

        public Address(string province, string ward, string district)
        {
            this.Province = province;
            this.Ward = ward;
            this.District = district;
        }

        public Address() { }

        //public Object ShallowCopy()
        //{
        //    return new Address(this);
        //}

        //public Object DeepCopy()
        //{
        //    return new Address(this);
        //}
    }
}

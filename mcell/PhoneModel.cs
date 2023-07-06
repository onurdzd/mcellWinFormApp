using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcell
{
    internal class PhoneModel
    {

        public int imei { get; set; }
        public string phoneName { get; set; }

        public PhoneModel(int imei, string phoneName) {

            this.imei = imei;
            this.phoneName = phoneName;
        }

        public string FullDetails { get { return $"{imei}  {phoneName}"; } }

    }
}

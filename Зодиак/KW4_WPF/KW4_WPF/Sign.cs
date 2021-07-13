using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KW4_WPF
{
    class Sign
    {
        public String Name { get; set; }
        public BitmapImage Picture { get; set; }
        public String Description { get; set; }
        public String Planet { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
        
        public List<String> CompatibleSigns { get; set; }
        public Sign() {
            CompatibleSigns = new List<String>();

        }


    }
}

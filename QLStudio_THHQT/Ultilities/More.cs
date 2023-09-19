using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLStudio_THHQT.Ultilities
{
    public static class More
    {
        public static void showNotice(int state, string nameAction)
        {
            if(state == 1)
            {
                MessageBox.Show(nameAction + " thành công !");
            }
            else{
                MessageBox.Show(nameAction + " không thành công !");
            }
        }
    }
}

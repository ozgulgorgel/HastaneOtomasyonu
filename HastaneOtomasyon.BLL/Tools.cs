using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.BLL
{
  public static  class Tools
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control c in koleksiyon)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txt.Clear();
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                }
                else if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox)c;
                    cmb.Text = "";
                    //cmb.SelectedIndex = 0;
                }
            }
        }

    }
}


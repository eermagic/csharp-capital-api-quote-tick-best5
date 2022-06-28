using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future2.Classes
{
    public class ComboUtil
    {
        /// <summary>
        /// 取得值
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public static ComboboxItem GetItem(ComboBox cbo)
        {
            ComboboxItem item = new ComboboxItem("", "");
            if (cbo.SelectedIndex > -1)
            {
                item = cbo.Items[cbo.SelectedIndex] as ComboboxItem;
            }
            return item;
        }
    }

    public class ComboboxItem
    {
        public ComboboxItem(string value, string text)
        {
            Value = value;
            Text = text;
        }
        public string Value
        {
            get;
            set;
        }
        public string Text
        {
            get;
            set;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}

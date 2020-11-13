using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileClient
{
    public partial class MainWindow : Form
    {
        private Control con;
        private ItemList itemlist = null;

        private string SelectedItem = "";
        public string ip = "";

        public MainWindow(string ipp)
        {
            InitializeComponent();
            ip = ipp;
            con = new Control(this);
            itemlist = (ItemList)FindResource("itemlist");
        }

        public void ListUpdate(string number, string str)
        {
            string[] token = str.Split('#');
            
            for(int i=0; i<int.Parse(number);i++)
            {
                int indexs = i + 1;
                try
                {
                    Dispatcher.Invoke(new Action(() => { itemlist.Add(new ItemActivation() { Index = indexs, Items = token[i] }); }));
                }
                catch(Exception)
                {
                    MessageBox.Show("리스트파일 추가에러");
                }
            }
        }

        private void ListView_SelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectedItem = itemlist[listView1.SelectedIndex].Items;
        }
    }
}

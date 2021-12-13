using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource sotrBindingSourse;
        private void Form1_Load(object sender, EventArgs e)
        {
            товарыTableAdapter1.Fill(rbProductDataSet1.Товары);
            sotrBindingSourse = new BindingSource(rbProductDataSet1, "Товары");
            FamtextBox.DataBindings.Add("Text", sotrBindingSourse, "Наименование");
            NametextBox.DataBindings.Add("Text", sotrBindingSourse, "Цена, $");
            SectiontextBox.DataBindings.Add("Text", sotrBindingSourse, "Код поставщика");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MoveNext();
        }
    }
}

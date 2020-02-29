using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilShopNet
{
    public partial class deleteOffice : Form
    {
        public deleteOffice()
        {
            InitializeComponent();
        }
        //Нажатие на кнопку "Удалить"
        private void DelBtm_Click(object sender, EventArgs e)
        {
            //Если поля заполнены
            if (txtOfficeName.TextLength > 0)
            {
                //Удаляем
                BdControler.DeleteOffice(txtOfficeName.Text);
                Close();
            }
            //Если есть пустое поле
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class MainForm : Form
    {
        mainControl control;
        Size panelSize;
        //Конструктор
        public MainForm()
        {
            InitializeComponent();
            //Инициализируем доступный размер панели
            panelSize = new Size();
            //Иницеализируем контролер
            control = new mainControl();
            panelSize = tabPage1.Size;
            //Добавляем обработчик события обновления списков
            control.update += update;
            //Очищаем все вкладки
            OfficeTabControl.TabPages.Clear();
            //Добавляем обработчик событи переключения вкладки
            OfficeTabControl.SelectedIndexChanged += NewTab;
            //Заполняем информацию о офисе
            MobilShopTownOffice office = new MobilShopTownOffice();
            office = control.getOffices()[0];
            lblHouse.Text = office.House;
            lblMail.Text = office.Email;
            lblRegion.Text = office.Region;
            lblStreet.Text = office.Street;
            lblTown.Text = office.Town;
            lblWeb.Text = office.Web;
            lblName.Text = office.Name;
            //Обнавляемся
            update();
        }
        //Меню - закрыть
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Меню - добавить офис
        private void AddOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.addOffice();
        }
        //Обновление
        private void update()
        {
            OfficeTabControl.TabPages.Clear();
            foreach(MobilShopTownOffice townOffice in control.getOffices())
            {
                TabPage tab = new TabPage();
                tab.Text = townOffice.Name;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Size = panelSize;
                foreach (MobilShop shop in townOffice.GetListOfShops())
                {
                    Button newShop = new Button();
                    Size size = new Size();
                    size.Width = 190;
                    size.Height = 95;
                    newShop.Size = size;
                    newShop.Text = shop.Name;
                    newShop.Click += ClickToShop;
                    panel.Controls.Add(newShop);
                }
                tab.Controls.Add(panel);
                OfficeTabControl.TabPages.Add(tab);

            }
            
        }
        //Метод обработки клика на магазин
        private void ClickToShop(object obj, EventArgs e)
        {
            Button btm = (Button)obj;
            control.ShopInfo(OfficeTabControl.SelectedTab.Text, btm.Text);
        }
        //Меню - удалить офис
        private void DelOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.deleteOffice();
        }
        //Меню - сохранить в БД
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.save();
        }
        //Меню - добавить магазин
        private void ShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.addShop();
        }
        //Обработчик переключения вкладки
        private void NewTab(object sender, EventArgs e)
        {
            MobilShopTownOffice office = new MobilShopTownOffice();
            if(OfficeTabControl.SelectedIndex < 0)
                office = control.getOffices()[0];
            else
                office = control.getOffices()[OfficeTabControl.SelectedIndex];
            lblHouse.Text = office.House;
            lblMail.Text = office.Email;
            lblRegion.Text = office.Region;
            lblStreet.Text = office.Street;
            lblTown.Text = office.Town;
            lblWeb.Text = office.Web;
            lblName.Text = office.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_2;

namespace Пр_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //Запись имени кораблей из текстбокса
            string Name1 = txtName1.Text;
            string Name2 = txtName2.Text;

            //Запись грузоподъемности из текстбокса
            int Weight1 = Convert.ToInt32(txtWeight1.Text);
            int Weight2 = Convert.ToInt32(txtWeight2.Text);

            //Конструктор
            CargoShip cs1 = new CargoShip(Name1, Weight1);
            CargoShip cs2 = new CargoShip(Name2, Weight2);

            //Показ информации о кораблях
            MessageBox.Show(cs1.ShowInfo());
            MessageBox.Show(cs2.ShowInfo());

            //Сравнение кораблей
            int comprez = cs1.CompareTo(cs2);
            if (comprez == -1) MessageBox.Show("Грузоподъемность первого корабля больше второго");
            if (comprez == 1) MessageBox.Show("Грузоподъемность второго корабля больше первого");
            if (comprez == 0) MessageBox.Show("Грузоподъемность равная");
        }

        //Ввод имени 1 корабля
        private void txtName1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        //Ввод имени 2 корабля
        private void txtName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        //Ввод веса 1 корабля
        private void txtWeight1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        //Ввод веса 2 корабля
        private void txtWeight2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал программист Подъяблонский Д.В \n" +
                "Практическая 8.Текст задания:\n" +
                "Создать интерфейсы - корабль, грузовой транспорт. \n" +
                "Создать класс грузовой корабль. \n" +
                "Класс должен включать конструктор, функцию для формирования строки информации о корабле \n" +
                "Сравнение производить по грузоподъемности");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал программист Подъяблонский Д.В \n" +
                "Практическая 8.Текст задания:\n" +
                "Создать интерфейсы - корабль, грузовой транспорт. \n" +
                "Создать класс грузовой корабль. \n" +
                "Класс должен включать конструктор, функцию для формирования строки информации о корабле \n" +
                "Сравнение производить по грузоподъемности");
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

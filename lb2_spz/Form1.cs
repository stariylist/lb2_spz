using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lb2_spz
{
    public partial class Form1 : Form
    {
        static List<University> universities = new List<University>();//создаем список экземпляров класса
        DataTable table = new DataTable(); //создаем таблицу для gridDataView
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//при загрузке формы происходит отрисовка DataGridView
        {
            table.Columns.Add("Name", typeof(string)) ;
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Num of rooms", typeof(int));
            table.Columns.Add("Num of personal", typeof(int));
            table.Columns.Add("Num of students", typeof(int));
            table.Columns.Add("Accomodation fee", typeof(decimal));
            dataGridView1.DataSource = table;
        }

        private void button_inputData_Click(object sender, EventArgs e)//обработка нажатия кнопки Input Data
        {
            //создаем нужные нам переменные
            string university_name, address;
            int num_of_rooms, num_of_staff, num_of_students;
            double fee, income;
            bool flag = false;
            //проверка на корректность ввода названия университета
            if (!Regex.IsMatch(textBox_name.Text, @"^[а-яА-ЯA-za-z ]+$") || String.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("Invalid university name!", "Error");//вывод сообщения об ошибке
                textBox_name.Clear();//очищаем текстбокс
                flag = true;//флаг ошибки ставим в истину
            }
            //проверка на наличие содержимого в строке адреса
            if (String.IsNullOrEmpty(textBox_address.Text))
            {
                MessageBox.Show("Empty address line!", "Error");//вывод сообщения об ошибке
                textBox_address.Clear();//очистка строки
                flag = true;//флаг ошибки ставим в истину
            }
            //если ввод данных корректен
            if (!flag)
            {
                //присваиваем значения переменным из контейнеров данных
                university_name = textBox_name.Text;
                address = textBox_address.Text;
                num_of_rooms = decimal.ToInt32(numericUpDown_rooms.Value);
                num_of_staff = decimal.ToInt32(numericUpDown_staff.Value);
                num_of_students = decimal.ToInt32(numericUpDown_students.Value);
                fee = decimal.ToDouble(numericUpDown_fee.Value);
                //создаем экземпляр класса
                University university = new University(university_name, address, num_of_rooms, num_of_staff, num_of_students, fee);
                //добавляем его в список
                universities.Add(university);
                //очищаем поля для ввода
                textBox_name.Clear();
                textBox_address.Clear();
                numericUpDown_rooms.Value = numericUpDown_rooms.Minimum;
                numericUpDown_staff.Value = numericUpDown_staff.Minimum;
                numericUpDown_students.Value = numericUpDown_students.Minimum;
                numericUpDown_fee.Value = numericUpDown_fee.Minimum;
            }
        }

        private void button_outputData_Click(object sender, EventArgs e)//обработка нажатия кнопки Output Data
        {
            table.Clear();//очистка таблицы
            for (int i = 0; i < universities.Count; i++)//проходим по всем экземплярам класса
            {
                //используем наши геттеры
                table.Rows.Add(universities[i].University_name, universities[i].Address, universities[i].Num_of_rooms, universities[i].Num_of_staff, universities[i].Num_of_students, universities[i].Fee);
            }
            //присваиваем источник для DataGridView
            dataGridView1.DataSource = table;
        }

        private void button_addCanteen_Click(object sender, EventArgs e)//обработка нажатия кнопки Add Canteen
        {
            if (universities.Count() > 0)
                universities[universities.Count() - 1].CanteenIncome();//для последнего экземпляра класса вызываем метод CanteenIncome
        }

        private void button_createCopy_Click(object sender, EventArgs e)//обработка нажатия кнопки Create Copy
        {
            if (universities.Count() > 0)
            {
                University university = (University)universities[universities.Count() - 1].Clone();// клонируем последний экземпляр класса
                universities.Add(university);//отправляем его в список
            }
        }

        private void button_increaseRooms_Click(object sender, EventArgs e)//обработка нажатия кнопки Increase the number of rooms
        {
            if (universities.Count() > 0)
                universities[universities.Count() - 1].IncreaseNumberOfRooms(decimal.ToInt32(numericUpDown_increaseRooms.Value));//вызов метода увеличения кол-ва комнат для последнего экземпляра класса
            numericUpDown_increaseRooms.Value = numericUpDown_increaseRooms.Minimum;//сбрасываем значение
        }

        private void button_settle_Click(object sender, EventArgs e)//обработка нажатия кнопки Settle a student
        {
            if (universities.Count() > 0)
                universities[universities.Count() - 1].SettleStudent(decimal.ToInt32(numericUpDown_settle.Value));//вызов метода увеличения кол-ва студентов для последнего экземпляра класса
            numericUpDown_settle.Value = numericUpDown_settle.Minimum;//сброс
        }

        private void button_evict_Click(object sender, EventArgs e)
        {
            if (universities.Count() > 0)
            {
                //проверка на достаточное количество студентов для выселения
                if (universities[universities.Count() - 1].Num_of_students >= decimal.ToInt32(numericUpDown_evict.Value))
                    universities[universities.Count() - 1].EvictStudent(decimal.ToInt32(numericUpDown_evict.Value));//вызов метода уменьшения кол-ва студентов для последнего экземпляра класса
                else//если выселяющихся>текущих
                    MessageBox.Show("Insufficient number of students!", "Error");//вывод сообщния об ошибке
            }
            numericUpDown_evict.Value = numericUpDown_evict.Minimum;//сброс
        }

        private void button_monthlyIncome_Click(object sender, EventArgs e)//обработка нажатия кнопки Monthly Income
        {
            if (universities.Count() > 0)//вызываем метод подсчета прибыли за месяц, а также используем метод ToString(по заданию)
                textBox_monthly.Text = universities[universities.Count() - 1].MontlyIncome().ToString() + " UAH";
        }

        private void button_semiIncome_Click(object sender, EventArgs e)//обработка нажатия кнопки Semi-annual income
        {
            if (universities.Count() > 0)
                textBox_semi.Text = universities[universities.Count() - 1].SemiAnnualIncome().ToString() + " UAH";//аналогично
        }

        private void button_annualIncome_Click(object sender, EventArgs e)//обработка нажатия кнопки Annual income
        {
            if (universities.Count() > 0)
                textBox_annual.Text = universities[universities.Count() - 1].AnnualIncome().ToString()+" UAH";//аналогично
        }
    }
}

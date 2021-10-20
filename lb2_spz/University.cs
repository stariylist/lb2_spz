using System;

namespace lb2_spz
{
    public static class Canteen //класс столовой
    {
        public static double AddCanteen(this double income, int num_of_students, ref int num_of_staff, double fee)//метод подсчета прибыли и персонала со столовой
        {
            if (income == 0)
                income = fee * num_of_students;
            income += income * 0.2;
            num_of_staff += 5;
            return income;
        }
    }
    public class University : ICloneable
    {
        //создаем нужные нам переменные
        string university_name, address;
        int num_of_rooms, num_of_staff, num_of_students;
        double fee, income;
        bool flag = false;
        //создаем инициализирующий конструктор с параметрами
        public University(string university_name, string address, int num_of_rooms, int num_of_staff, int num_of_students, double fee)
        {
            this.university_name = university_name;
            this.address = address;
            this.num_of_rooms = num_of_rooms;
            this.num_of_staff = num_of_staff;
            this.num_of_students = num_of_students;
            this.fee = fee;
        }
        //создаем геттеры
        public string University_name => university_name;
        public string Address => address;
        public int Num_of_rooms => num_of_rooms;
        public int Num_of_staff => num_of_staff;
        public int Num_of_students => num_of_students;
        public double Fee => fee;
        public double Income => income;
        public object Clone()//реализация интерфейса ICloneable
        {
            University university = new University(this.university_name, this.address, this.num_of_rooms, this.num_of_staff, this.num_of_students, this.fee);
            return university;
        }
        public void IncreaseNumberOfRooms(int value)//метод увеличения колличества комнат
        {
            num_of_rooms += value;
        }
        public void SettleStudent(int value)//метод заселения студентов
        {
            num_of_students += value;
        }
        public void EvictStudent(int value)//метод выселения студентов
        {
            num_of_students -= value;
        }
        public double MontlyIncome()//метод вычисления месячной прибыли
        {
            if(!flag)
                income = fee * num_of_students;
            return income;
        }
        public double SemiAnnualIncome()//метод вычисления полугодовой прибыли
        {
            if (flag)
                return income * 6;
            else
                return fee * num_of_students * 6;
        }
        public double AnnualIncome()//метод вычисления годовой прибыли
        {
            if (flag)
                return income * 12;
            else
                return fee * num_of_students * 12;
        }
        public void CanteenIncome()//метод вычисления прибыли со столовой
        {
            flag = true;
            income = income.AddCanteen(num_of_students, ref num_of_staff, fee);
        }
    }
}

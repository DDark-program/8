using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_2
{
    //Интерфейс 
    interface ICloneable
    {
        object Clone();
    }


    //Интерфейс
    interface IComporable
    {
        int CompairTo(object obj);
    }

    //Интерфейс
    interface ICargoTransport
    {
        void SetWeight(int Weight);
    }

    //Интерфейс 
    interface IShip
    {
        string ShowInfo();
    }

    public class CargoShip : ICargoTransport, IShip, ICloneable, IComparable
    {
        //Поля имя и вес
        private string _name;
        private int _weight;

        //Конструктор
        public CargoShip(string Name, int Weight)
        {
            this.Name = Name;
            this.Weight = Weight;
        }

        public string Name { get => _name; set => _name = value; }
        public int Weight { get => _weight; set => _weight = value; }

        //Клонирование объекта
        public object Clone()
        {
            return new CargoShip(Name, Weight);
        }
        //Сравнивание объектов
        public int CompareTo(object obj)
        {
            CargoShip cargoShip = obj as CargoShip;
            if (Weight > cargoShip.Weight) return -1;
            if (Weight < cargoShip.Weight) return 1;
            return 0;
        }
        //Метод выставления значения веса
        public void SetWeight(int Weight)
        {
            Weight = this.Weight;
        }
        //Метод показа информации
        public string ShowInfo()
        {
            return "Имя корабля: " + Name + " " + "," + " " + "Грузоподъемность: " + " " + Weight;
        }
    }
}

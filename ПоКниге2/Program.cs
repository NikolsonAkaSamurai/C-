
using System.Windows.Forms;
using Microsoft.VisualBasic;


//Класс это чертеж панельного блока
//По образцу строятся объекты - непосредственно сами блоки
//блоки состоят из окон и дверей - данные и функции
//так же классы содержат свойства, индексаторы и события
//данные и функции класса называются полями и методами (члены класса)


     class Program
    {
        
        static void Main()
        {
            string name;

            name = Interaction.InputBox("Как вас зоут?", "Давайте знакомиться");

            string msg = "Очень приятно," + name + "!";

            string title = "Окно приветствия";

            MessageBox.Show(msg,title,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
        }
    }


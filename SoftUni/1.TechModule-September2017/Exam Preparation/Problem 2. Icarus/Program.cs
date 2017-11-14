using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var index = int.Parse(Console.ReadLine());
            var currIndex = index;  //тука си въвеждаме промениливата, тъй като при всяко завъртане на ляво или надясно започваме от различен индекс(последния елемент от предишното завъртане).При първото ни действие започваме от въведения индекс, после го презаписваме..
            var damage = 1; //въвеждаме си и променлива damage, тъй като според броя излизания от масива може да стигне до 300-примерно
            var stepsMade = 0; // тази променлива я въвеждаме, за да знаем кога да спрем ходовете надясно или наляво
            
            var command = Console.ReadLine()
                .Split(' ');
            var direction = command[0];


            while (direction != "Supernova")
            {
                var steps = int.Parse(command[1]);
                if (direction == "left")
                {
                    for (int i = currIndex - 1; i >= -1; i--)//ако първати ни стъпка е наляво започваме от елемента от лявата страна на въведения от конзолата индекс
                    {
                        if (stepsMade == steps)//винаги първо проверяваме дали направените стъпки са равни на желаните, защото примерно ако имаме left 0(а то го има в джъджа ;))ще влезем в безкраен цикъл, ако тази проверка не ни е на първо място
                        {
                            break;//ако стигнем до желания брой стъпки излизаме от цикъла;
                        }
                        if (i!=-1)//тук правим проверка дали сме в рамките на масива, т.е най-много i=0;
                        {
                            currIndex = i;//ако примерно последната ни стъпка наляво  е 0, презаписваме currIndeks на тази позиция
                        }
                        else //ако сме превъртяли масива и i=-1
                        {
                            i = input.Length-1; //вече въртенето почва от последния елемент
                            damage++; //с увеличен с едно damage
                            currIndex = input.Length-1; //и примерно ако това ни е последния ход на ляво презаписваме, че сме на тази позиция
                        }
                        input[i] = input[i] - damage; //при всички положение всяки елемент намаляме с damage и съответно броим броя на направените стъпки
                        stepsMade++;
                    }
                    stepsMade = 0;
                }
                //ЗА ХОДОВЕТЕ НАДЯСНО Е АНАЛОГИЧНО
                else if (direction == "right")
                {
                    for (int i = currIndex + 1; i <= input.Length; i++)
                    {
                        if (stepsMade == steps)
                        {
                            break;
                        }
                        if (i != input.Length)
                        {
                           currIndex = i;
                        }
                        else
                        {
                            damage++;
                            i = 0;
                            currIndex = 0;
                        }
                        input[i] = input[i] - damage;
                        stepsMade++;
                      
                    }
                    stepsMade = 0;
                }
                command = Console.ReadLine()
                    .Split(' ');
                direction = command[0];
            }
            Console.WriteLine(String.Join((" "),input));
        }
    }
}

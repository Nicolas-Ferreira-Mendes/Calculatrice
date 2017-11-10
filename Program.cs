using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string strOp;
            double dblVal1,dblVal2,dblRep = 0;
            bool isOpIncorrect = false;
            

            Console.WriteLine("Calculatrice");
            Console.WriteLine("------------");

            //Saisie des opérandes, avec vérification de ces dernières
            Console.Write("Saisir la 1ère valeur : ");
            while(!double.TryParse(Console.ReadLine(),out dblVal1))
            {
                Console.Write("Saisir à nouveau la 1ère valeur : ");
            }

            Console.Write("Saisir la 2ère valeur : ");
            while (!double.TryParse(Console.ReadLine(), out dblVal2))
            {
                Console.Write("Saisir à nouveau la 2ème valeur : ");
            }

            //Saisie du choix de l'opérateur
            Console.Write("Opération à choix [+ - * / ^] : ");
            while (!isOpIncorrect)
            {


                strOp = Console.ReadLine();
                isOpIncorrect = false;

                switch (strOp)
                {
                    default:
                        Console.WriteLine("Opération non reconnue par le système");
                        Console.Write("Veuillez saisir a nouveau l'opérateur [+ - * / ^] : ");
                        isOpIncorrect = true;
                        break;
                    case "+":
                        dblRep = Outils.Additon(dblVal1, dblVal2);
                        Console.Write(dblRep.ToString());
                        break;

                    case "-":
                        dblRep = Outils.Soustraction(dblVal1, dblVal2);
                        Console.Write(dblRep.ToString());
                        break;

                    case "*":
                        dblRep = Outils.Multiplication(dblVal1, dblVal2);
                        Console.Write(dblRep.ToString());
                        break;

                    case "/":
                        dblRep = Outils.Soustraction(dblVal1, dblVal2);
                        Console.Write(dblRep.ToString()); ;
                        break;
                    case "^":
                        dblRep = 0;
                        break;

                }
            }
         
            Console.ReadKey();
        }
    }
}

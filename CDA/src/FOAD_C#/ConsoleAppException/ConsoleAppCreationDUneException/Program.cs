using ConsoleAppCreationDUneException.ExceptionOfFraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCreationDUneException
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tester la construction de la Fraction
            // cas normal
            try
            {
                Fraction f2 = new Fraction(1, 2);
                Console.WriteLine("Le code fonctionne");
            }
            catch (Exception e)
            {
                Console.WriteLine("Division par zero impossible");
            }

            // cas denominateur vaut 0
            try
            {
                Fraction f2 = new Fraction(1, 0);
                Console.WriteLine("Le code fonctionne");
            }
            catch (ZeroDenominatorImpossibleException e)
            {
                Console.WriteLine("Division par zero impossible");
            }
            #endregion
            #region tester Evaluer
            //cas normal evaluer
            try
            {
                Fraction f = new Fraction(1, 2);
                f.Evaluer();
                Console.WriteLine("Le code fonctionne");
            }
            catch (ImpossibleEvaluationOfFraction e)
            {
                Console.WriteLine("Evaluation impossible : Le denominator ne doit pas etre egal a zero dans une fraction ");
            }
            //cas denominateur vaut zero
            try
            {
                Fraction f = new Fraction(1, 2);
                f.Denominator = 0;
                f.Evaluer();
                Console.WriteLine("Le code fonctionne");
            }
            catch (ImpossibleEvaluationOfFraction e)
            {
                Console.WriteLine("Evaluation impossible : Le denominator ne doit pas etre egal a zero dans une fraction ");
            }
            #endregion
            #region tester Inverser
            //cas normal inverser
            try
            {
                Fraction f = new Fraction(1, 2);
                f.Inverser();
                Console.WriteLine("Le code fonctionne");
            }
            catch (ImpossibleDInverserLaFraction e)
            {
                Console.WriteLine("Inversion impossible : Impossible d'inverser la fraction lorsque le numerateur est egal à zero");
            }
            //cas numerateur vaut zero
            try
            {
                Fraction f = new Fraction(0, 2);
                f.Inverser();
                Console.WriteLine("Le code fonctionne");
            }
            catch (ImpossibleDInverserLaFraction e)
            {
                Console.WriteLine("Inversion impossible : Impossible d'inverser la fraction lorsque le numerateur est egal à zero");
                Console.WriteLine(e.Message);
            }
            #endregion
            Console.ReadLine();

        }
    }
}

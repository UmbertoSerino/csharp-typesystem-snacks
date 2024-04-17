using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System;
using System.Security.Authentication;
using System.Diagnostics.CodeAnalysis;

namespace csharp_typesystem_snacks

{
    internal class Program
{
        static void Main(string[] args)
        {
            //{
            //---snack 1
            //l’utente inserisce due numeri in successione.
            //il software stampa il maggiore.
            // Richiesta
            //Console.WriteLine("Confronta numeri: Inserisci un numero");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Confronta numeri: Inserisci un secondo numero");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            // Confrontare se il primo valore ricevuto è superiore
            //if (numberOne > numberTwo) {
            //  Console.WriteLine($"Il numero {numberOne} è più alto di {numberTwo}");
            //} else if (numberOne < numberTwo)
            //{
            //  Console.WriteLine($"Il numero {numberTwo} è più alto di {numberOne}");
            //} else
            //{
            //  Console.WriteLine($"I numeri sono uguali, primo numero: {numberOne}, secondo numero:{numberTwo}");
            //}
            //}
            //---snack 2
            //l’utente inserisce due parole in successione.
            //il software stampa prima la parola più corta, poi la parola più lunga.
            //{
            //  Console.WriteLine("Confronta parole: Inserisci una parola");
            //string firstWord = Console.ReadLine();
            //Console.WriteLine("Confronta parole: Inserisci una seconda parola");
            //string secondWord = Console.ReadLine();
            //if (firstWord.Length > secondWord.Length)
            //{
            //Console.WriteLine($"La parola più lunga è {firstWord}, {firstWord.Length} lettere");
            //} else if (secondWord.Length > firstWord.Length)
            //{
            //Console.WriteLine($"La parola più lunga è {secondWord}, {secondWord.Length} lettere");

            //} else
            //{
            //Console.WriteLine($"Le parole hanno la stessa lunghezza {secondWord}, {secondWord.Length} lettere e {firstWord}, {firstWord.Length} ");

            //}
            //}
            //---snack 3
            //il software deve chiedere per 10 volte all’utente di inserire un numero.
            //il programma stampa la somma di tutti i numeri inseriti.
            //{
            // ci creiamo una variabile iniziale
            //int numberList = 0;

            //Console.WriteLine("Inserisci 10 numeri");
            //for (int i = 0; i < 10; i++)
            //{
            // Prendiamo i numeri inseriti dall'utente
            //int number = Convert.ToInt32(Console.ReadLine());
            // La somma, la inseriamo al valore iniziale
            //numberList = numberList + number;
            //}
            // Diamo al cliente il risultato dei numeri dati
            //Console.WriteLine($"La somma dei tuoi numeri è {numberList}");
            //}
            //---snack 4
            //calcola la somma e la media dei numeri da 2 a 10.
            //{
            //  int[] myList = { 2, 3, 4, 5, 6, 7, 8, 9, 9 };
            //int sum = 0;
            //foreach (int number in myList) 
            //{
            //  sum += number;
            //}
            //decimal average = (decimal)sum / myList.Length;
            //Console.WriteLine($"La somma totale è {sum:F3}, la sua media invece è {average:F3}");
            //}
            //---snack 5
            //il software chiede all’utente di inserire un numero se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            //{
            //  Console.WriteLine("Inserisci un numero, oggi ti sto chiedendo tanto");
            //int choiceNumber = Convert.ToInt32(Console.ReadLine());
            //if (choiceNumber % 2 == 0) 
            //{
            //  Console.WriteLine($"Il numero inserito è pari: {choiceNumber}");
            //}
            //else
            //{
            //  Console.WriteLine($"Il numero inserito è dispari: {choiceNumber}");

            //}
            //}
            /*{
                //---snack 6
                //in un array sono contenuti i nomi degli invitati alla festa del grande gatsby. chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
                string[] greatGasby = { "One", "Two", "Three", "Four" };
                Console.WriteLine("Qual è il suo nome? controllo se è in lista");
                string myNameIs = Console.ReadLine();
                bool isFound = false;
                foreach (string name in greatGasby) 
                {
                    if (name == myNameIs)
                    {
                        isFound = true;
                        break;
                        
                    }
                }
                if (isFound)
                {
                    Console.WriteLine("Ok, sei dentro");
                } else
                {
                    Console.WriteLine($"Ma guarda che tu non sei in lista!");

                }
            }
            */
            /*{

            //---snack 7
            //crea un array vuoto.
            //chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
                int[] myArray= new int[6];
                int index = 0;
                for (int i = 0; i < myArray.Length; i++) 
                {
                    Console.WriteLine("Inserisci dei numeri");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if(number % 2 == 0)
                    {
                        
                        myArray[index] = number;
                        index++;
                    }
                }

                Console.WriteLine("Numeri pari inseriti nell'array:");
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
            */
            /*            {
                //---snack 8
                //crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
                int[] integerArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int sum = 0;
                for (int i = 0; i < integerArray.Length; i += 2)
                {
                    sum += integerArray[i];
                    Console.WriteLine(sum);
                }
                Console.WriteLine($"La somma totale è: {sum}");
            }
            */
            /*{
                //---snack 9
                //crea un array vuoto e chiedi all’utente un numero da inserire nell’array.continua a chiedere i numeri all’utente e a inserirli
                //nell’array, fino a quando la somma degli elementi è minore di 50.
                {
                    int[] myArray = new int[50];
                    int sum = 0;
                    int index = 0;

                    Console.WriteLine("Inserisci un numero");
                    while (sum <= 50)
                    {
                        int number = Convert.ToInt32(Console.ReadLine());

                        if (number <= (50 - sum))
                        {
                            myArray[index] = number;
                            sum += number;
                            index++;
                            Console.WriteLine("Bravo!");
                        }
                        else
                        {
                            Console.WriteLine("La somma degli elementi è >= di 50.");
                        }

                    }
                    Console.WriteLine($"Totale mio array: {myArray[index]}, totale sum {sum}");

                }
            }
            */
            //---snack 10
            //fai inserire un numero, che chiameremo n, all’utente.
            //genera n array, ognuno formato da 10 numeri casuali tra 1 e 100.
            //ogni volta che ne crei uno, stampalo a schermo.
            //buon lavoro!
        }
    }
}

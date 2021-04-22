﻿using System;

namespace KonsolProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization of H1ElevKlasse class
            H1ElevKlasse elevKlasse = new H1ElevKlasse();

            //Call the method with the elevKlasse object
            var elevInfo = elevKlasse.GetElevInfo();

            Console.WriteLine("Klasse eksempel \n");
            Console.WriteLine("-------------------------");


            Console.WriteLine(
                "Fornavn: "+ elevInfo.Fornavn +
                "\n Efternavn: " + elevInfo.Efternavn +
                "\n Telefon: " + elevInfo.Telefonnr +
                "\n Anden H1 Fag: " + elevInfo.AlleH1Fag[1]                
                );

            Console.WriteLine("\nStruct eksempel ");
            Console.WriteLine("------------------------- \n");


            //Initialize struct with a parameter
            StructKlasse udregningStruct = new StructKlasse(elevInfo.H1Afslutdato);

            //call method with the struct object
            var datoTilbage = udregningStruct.BeregnAfslutDato();
            Console.WriteLine("dato tilbage: " + datoTilbage);

           


            Console.WriteLine("\n records eksempel ");
            Console.WriteLine("------------------------- \n");

            //initialize records type with parameters
            KontaktInfo kontaktInfo= new KontaktInfo(elevInfo.Fornavn, elevInfo.Efternavn, elevInfo.Telefonnr, elevInfo.Fødelsesdato, elevInfo.Køn);           
            
            //print records data
            Console.WriteLine(kontaktInfo);



            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }
}

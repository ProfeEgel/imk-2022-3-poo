﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DentalCare
{
    internal class Program
    {
        static Agenda agenda;

        static void Main(string[] args)
        {
            agenda = new Agenda();

            int option = 0;
            do
            {
                Clear();
                WriteLine("**********************************************");
                WriteLine("*        DENTAL CARE (MENU PRINCIPAL)        *");
                WriteLine("**********************************************");
                WriteLine();
                WriteLine("1. Consultas");
                WriteLine("2. Citas");
                WriteLine("0. Salir");
                Write("\nElige una opción: ");
                option = Convert.ToInt32(ReadLine());
                
                switch (option)
                {
                    case 1:
                        SubmenuConsultas();
                        break;

                    case 2:
                        SubmenuCitas();
                        break;

                    case 0:
                        WriteLine("\n¡GRACIAS POR UTILIZAR EL PROGRAMA!");
                        break;

                    default:
                        WriteLine("\n¡OPCIÓN NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (option != 0);
        }

        static void SubmenuConsultas()
        {
            int option = 0;
            do
            {
                Clear();
                WriteLine("**********************************************");
                WriteLine("*             SUBMENU CONSULTAS              *");
                WriteLine("**********************************************");
                WriteLine();
                WriteLine("1. Citas por paciente");
                WriteLine("2. Citas por día");
                WriteLine("0. Volver");
                Write("\nElige una opción: ");
                option = Convert.ToInt32(ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            List<AppointmentWithInfo> result = agenda.GetCitasPorPaciente();

                            Clear();
                            WriteLine("**********************************************");
                            WriteLine("*             CITAS POR PACIENTE             *");
                            WriteLine("**********************************************");
                            WriteLine();

                            if (result.Count > 0)
                            {
                                result.ForEach(a =>
                                    WriteLine($"{a.Patient.FullName}, {a.Day.Name}, {a.Time.Description}"));

                                ReadKey();
                            }
                            else
                            {
                                WriteLine("\n¡No hay citas pendientes!");
                                ReadKey();
                            }
                        }
                        break;

                    case 2:
                        {
                            Clear();
                            WriteLine("**********************************************");
                            WriteLine("*               CITAS POR DIA                *");
                            WriteLine("**********************************************");

                            List<Day> days = agenda.GetDays();
                            foreach (Day day in days)
                            {
                                WriteLine($"\n-- {day.Name} --");

                                List<AppointmentWithInfo> result = agenda.GetCitasPorDia(day);
                                if (result.Count > 0)
                                {
                                    result.ForEach(a =>
                                        WriteLine($"\t{a.Time.Description}, {a.Patient.FullName}"));
                                }
                                else
                                {
                                    WriteLine("\t¡No hay citas pendientes!");
                                }
                            }

                            ReadKey();
                        }
                        break;

                    case 0:
                        break;

                    default:
                        WriteLine("\n¡OPCIÓN NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (option != 0);
        }

        static void SubmenuCitas()
        {
            int option = 0;
            do
            {
                Clear();
                WriteLine("**********************************************");
                WriteLine("*               SUBMENU CITAS                *");
                WriteLine("**********************************************");
                WriteLine();
                WriteLine("1. Agendar");
                WriteLine("2. Cancelar");
                WriteLine("0. Volver");
                Write("\nElige una opción: ");
                option = Convert.ToInt32(ReadLine());

                switch (option)
                {
                    case 1:
                    case 2:
                        WriteLine("\n¡OPCIÓN NO IMPLEMENTADA!");
                        ReadKey();
                        break;

                    case 0:
                        break;

                    default:
                        WriteLine("\n¡OPCIÓN NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (option != 0);
        }
    }
}

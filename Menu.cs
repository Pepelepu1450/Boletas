using System;
using System.Collections.Generic;

namespace Boletas
{
    class Menu
    {
        static DateTime fechaHoy = System.DateTime.Today;
        static string nombreArchivoAlumnos = "alumnos " + fechaHoy.ToString("dd-MM-yyyy") + ".txt";
        Alumno alumno = new Alumno(nombreArchivoAlumnos);


        static string nombreArchivoMaterias = "materias " + fechaHoy.ToString("dd-MM-yyyy") + ".txt";
        Materias materias = new Materias(nombreArchivoMaterias);



        private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        private int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        private void DisplayMainMenuOptions()
        {
            System.Console.WriteLine("1) Capturar un nuevo alumno");
            System.Console.WriteLine("2) Borrar alumnos");
            System.Console.WriteLine("3) Exportar alumnos");
            System.Console.WriteLine("4) Capturar nueva materia");
            System.Console.WriteLine("5) Borrar materias");
            System.Console.WriteLine("6) Exportar materias");
            System.Console.WriteLine("7) Capturar calificaciones");
            System.Console.WriteLine("8) Exportar califiaciones");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("Elige una opcion");
            System.Console.WriteLine();
        }

        void CapturarCalificaciones()
        {
            System.Console.WriteLine("TO DO");
        }

        void ExportarCalificaciones()
        {
            System.Console.WriteLine("TO DO");
        }

        public void Display()
        {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1:
                        alumno.CapturarAlumnos();
                        break;

                    case 2:
                        alumno.BorrarAlumnos();
                        break;

                    case 3:
                        alumno.ExportarAlumnos();
                        break;

                    case 4:
                        materias.CapturarMaterias();
                        break;

                    case 5:
                        materias.BorrarMaterias();
                        break;

                    case 6:
                        materias.ExportarMaterias();
                        break;

                    case 7:
                        CapturarCalificaciones();
                        break;

                    case 8:
                        ExportarCalificaciones();
                        break;


                }
            }

            System.Console.WriteLine("Adios");

        }
    }
}
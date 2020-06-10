using System;
using System.IO;

namespace Boletas
{
    class Alumno 
    {

        string nombreArchivo = "";

        public Alumno(string nombreArchivo) {
            this.nombreArchivo = nombreArchivo;
        }

        public void CapturarAlumnos() {
            System.Console.WriteLine("Agregar alumno");
            System.Console.WriteLine("Escribe el nombre completo del alumno:");
            string nota = Console.ReadLine();

            //Archivos: abrir, (modificar)[, flush, cerrar]
            bool append = true;
            using (var file = new StreamWriter(this.nombreArchivo, append)) {
                file.WriteLine(nota);
            }
            System.Console.WriteLine("Alumno agregado");
        }

        public void ExportarAlumnos() {
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Alumnos:");
            System.Console.WriteLine("");
            string[] lineas = File.ReadAllLines(this.nombreArchivo);
            foreach (var linea in lineas)
            {
                System.Console.WriteLine(linea);
            }
            System.Console.WriteLine("--------------");
        }

        public void BorrarAlumnos() {
            System.Console.WriteLine("Borrar Alumnos");
            bool append = false;
            using (var file = new StreamWriter(this.nombreArchivo, append)) {
                file.WriteLine("");
            }
            System.Console.WriteLine("Alumnos borrados");
        }
    }
}
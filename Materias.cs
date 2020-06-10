using System;
using System.IO;

namespace Boletas
{
    class Materias
    {

        string nombreArchivo = "";

        public Materias(string nombreArchivo) {
            this.nombreArchivo = nombreArchivo;
        }

        public void CapturarMaterias() {
            System.Console.WriteLine("Agregar materia");
            System.Console.WriteLine("Escribe el nombre de la materia:");
            string nota = Console.ReadLine();

            //Archivos: abrir, (modificar)[, flush, cerrar]
            bool append = true;
            using (var file = new StreamWriter(this.nombreArchivo, append)) {
                file.WriteLine(nota);
            }
            System.Console.WriteLine("Materia agregada");
        }

        public void ExportarMaterias() {
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Materias:");
            System.Console.WriteLine("");
            string[] lineas = File.ReadAllLines(this.nombreArchivo);
            foreach (var linea in lineas)
            {
                System.Console.WriteLine(linea);
            }
            System.Console.WriteLine("--------------");
        }

        public void BorrarMaterias() {
            System.Console.WriteLine("Borrar materias");
            bool append = false;
            using (var file = new StreamWriter(this.nombreArchivo, append)) {
                file.WriteLine("");
            }
            System.Console.WriteLine("Materias borrados");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio70
{
    class Program
    {
        static void Main(string[] args)
        {
			//Definir NombreAlumno, MayorAlumno, PeorAlumno Como Caracter;
			//Definir PromedioAlumno, MejorPromedio, PeorPromedio, MediaPromedio Como Real;
			//Definir CantidadAprobados, CantidadDesaprobados Como Entero;
			//Definir ContadorAlumnos, contadorNotas Como Entero;
			//Definir CantidadX Como Entero;
			//Definir Nota Como Entero;
			//Definir noSalir Como Logico;
			////Ciclo para validar la cantidad de alumnos que se vayan a ingresar
			//noSalir = Verdadero;
			//Repetir
			//	Escribir "Ingrese la cantidad de alumnos:";
			//Leer CantidadX;
			//Si CantidadX> 0 Entonces
			//	 noSalir = Falso;
			//SiNo
			//	Escribir "La cantidad debe ser superior a 0.... Reingresar";
			//FinSi
		 //   Mientras Que noSalir;
			//MejorPromedio = 0;
			//PeorPromedio = 11;
			//Para ContadorAlumnos = 1 Hasta CantidadX Con Paso 1 Hacer
			//	  //Ingreso del alumno
			//	  Escribir "Ingrese el nombre del alumno nro ",ContadorAlumnos,":";
			//Leer NombreAlumno;
			////Ciclo del ingreso de las 3 notas
			//PromedioAlumno = 0;
			//Para ContadorNotas = 1 Hasta 3 Con Paso 1 Hacer
			//	  //Ciclo para validar cada nota ingresada 
			//	  noSalir = Verdadero;
			//Repetir
			//	Escribir "Ingrese la nota ",ContadorNotas,":";
			//Leer Nota;
			//Si Nota>= 1 & Nota <= 10 Entonces
			//	   noSalir = Falso;
			//SiNo
			//	Escribir "La nota debe estar entre 1 y 10";
			//FinSi

		 //   Mientras Que noSalir;
			//PromedioAlumno = PromedioAlumno + Nota;
			//Fin Para
		 //   //Calculo del promedio
			//PromedioAlumno = PromedioAlumno / 3;
			//Escribir "Promedio Del Alumno:",PromedioAlumno;
			////verificar si el alumno aprobò o nò 
			//Si PromedioAlumno>= 7 Entonces
			//	 CantidadAprobados = CantidadAprobados + 1;
			//SiNo
			//	CantidadDesaprobados = CantidadDesaprobados + 1;
			//Fin Si


		 //   MediaPromedio = MediaPromedio + PromedioAlumno;//Para obtener luego la media de promedios

			////Busqueda del mejor y peor promedio
			//Si PromedioAlumno> MejorAlumnos; Entonces //Chequear que el promedio obtenido si es mayor al menor promedio			
			//	 MejorPromedio = PromedioAlumno;
			//MejorAlumnos = NombreAlumno;
			//FinSi
			//Si PromedioAlumno < PeorPromedio Entonces
			//	  PeorPromedio = PromedioAlumno;
			//PeorAlumno = NombreAlumno;
			//FinSi

		 //   Fin Para
		 //   Escribir "Castidad de Aprobados=", CantidadAprobados;
			//Escribir "Cantidad de Desaprobados=",CantidadDesaprobados;
			//Escribir "Media de Desaprobados=",MediaPromedio / CantidadX;
			//Escribir "El mejor alumno es ",MejorAlumnos, " con un promedio de ",MejorPromedio;
			//Escribir "El peor alumno es ",PeorAlumno, " con un promedio de ", PeorPromedio;
		}
    }
}

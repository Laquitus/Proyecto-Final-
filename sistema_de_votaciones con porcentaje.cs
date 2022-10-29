// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class sistema_de_votaciones {

		static void Main(string[] args) {
			double cv;
			int f;
			int i;
			double if;
			string p1;
			string p2;
			string p3;
			double porcentaje1;
			double porcentaje2;
			double porcentaje3;
			double v;
			int vc1;
			int vc2;
			int vc3;
			int ver;
			int vn;
			int voto;
			string[] votantes = new string[100];
			// fin de votaciones 1-si 0-no
			// verificar existencias de sufragante 
			f = 0;
			ver = 0;
			vc1 = 0;
			vc2 = 0;
			vc3 = 0;
			vn = 0;
			while ((f==0)) {
				Console.WriteLine("Ingrese una identificacion para ingresar: ");
				Console.WriteLine("o ingrese 0 para ver los resultados");
				v = Console.ReadLine();
				if ((v!=0)) {
					for (i=1;i<=100;i++) {
						if ((votantes[i-1]==v)) {
							ver = 1;
						} else {
							ver = 0;
							votantes[i-1] = v;
						}
					}
					if ((ver==1)) {
						Console.Clear();
						Console.WriteLine("!Esta persona no puede votar dos veces!");
					} else {
						Console.Clear();
						Console.WriteLine("*** Seleccione un candidato ***");
						Console.WriteLine("1. Juan Carlos Merida");
						Console.WriteLine("2. Jose Leonel Perez");
						Console.WriteLine("3. Maria Eugenia Alarcon");
						Console.WriteLine("Ingresa el numero correspondiente al candidato");
						voto = int.Parse(Console.ReadLine());
						switch (voto) {
						case 1:
							vc1 = vc1+1;
							break;
						case 2:
							vc2 = vc2+1;
							break;
						case 3:
							vc3 = vc3+1;
							break;
						default:
							vn = vn+1;
						}
					}
					// Stiven Del Cid añade sistema de porcentajes
					cv = vc1+vc2+vc3;
					porcentaje1 = (vc1/cv)*100;
					porcentaje2 = (vc2/cv)*100;
					porcentaje3 = (vc3/cv)*100;
				} else {
					Console.WriteLine("*** Resultados de las elecciones***");
					if ((vc1>vc2 && vc1>vc3)) {
						Console.WriteLine("El ganador es Juan Carlos Merida: "+vc1+" votos"+" con el "+porcentaje1+"%");
						if ((vc2>vc3)) {
							Console.WriteLine("Jose Leonel Perez tiene: "+vc2+" votos"+" con el: "+porcentaje2+"%");
							Console.WriteLine("Maria Eugenia Alarcon tiene: "+vc3+" votos"+" con el:  "+porcentaje3+"%");
						} else {
							Console.WriteLine("Maria Eugenia Alarcon tiene: "+vc3+" votos"+" con el: "+porcentaje3+"%");
							Console.WriteLine("Jose Leonel Perez tiene: "+vc2+" votos"+" con el:  "+porcentaje2+"%");
						}
					} else {
						if ((vc2>vc1 && vc2>vc3)) {
							Console.WriteLine("El ganador es Jose Leonel Perez con: "+vc2+" votos"+" con el:  "+porcentaje2+"%");
							if ((vc1>vc3)) {
								Console.WriteLine("Juan Carlos Merida tiene: "+vc1+" votos"+" con el:  "+porcentaje1+"%");
								Console.WriteLine("Maria Eugenia Alarcon tiene: "+vc3+" votos"+" con el:  "+porcentaje3+"%");
							} else {
								Console.WriteLine("Maria Eugenia Alarcon tiene: "+vc3+" votos"+" con el:  "+porcentaje3+"%");
								Console.WriteLine("Juan Carlos Merida tiene: "+vc1+" votos"+" con el:  "+porcentaje1+"%");
							}
						} else {
							if ((vc3>vc1 && vc3>vc2)) {
								Console.WriteLine("El ganador fue Maria Eugenia Alarcon con: "+vc3+" votos"+" con el:  "+porcentaje3+"%");
								if ((vc2>vc1)) {
									Console.WriteLine("Jose Leonel Perez tiene: "+vc2+" votos"+" con el:  "+porcentaje2+"%");
									Console.WriteLine("Juan Carlos Merida tiene: "+vc1+" votos"+" con el:  "+porcentaje1+"%");
								} else {
									Console.WriteLine("Juan Carlos Merida tiene: "+vc1+" votos"+" con el:  "+porcentaje1+"%");
									Console.WriteLine("Jose Leonel Perez tiene: "+vc2+" votos"+" con el:  "+porcentaje2+"%");
								}
							} else {
								Console.WriteLine("Existe un empate entre candidatos, se deben repetir las elecciones");
							}
						}
					}
					Console.WriteLine("votos no validos: "+vn);
					if = 1;
				}
			}
		}

	}

}


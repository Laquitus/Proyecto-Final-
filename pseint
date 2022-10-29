Algoritmo sistema_de_votaciones
		Definir vc1, vc2, vc3 Como Entero
		Definir p1, p2, p3 Como Caracter
		Definir vn Como Entero
		Dimension votantes[100]
		Definir f Como Entero // fin de votaciones 1-si 0-no
		Definir ver Como Entero // verificar existencias de sufragante 
		f <- 0
		ver <- 0
		vc1 <- 0
		vc2 <- 0
		vc3 <- 0
		vn <- 0
		Mientras (f==0) hacer 
			Escribir "Ingrese una identificacion para ingresar: "
			Escribir "o ingrese 0 para ver los resultados"
			leer v
			si (v <> 0) Entonces
				para i<-1 Hasta 100 con paso 1 hacer 
					si (votantes[i]==v) Entonces
						ver = 1;
					SiNo
						ver = 0;
						votantes[i]<-v
					FinSi
				FinPara
				si (ver==1) Entonces
					Limpiar Pantalla
					Escribir "!Esta persona no puede votar dos veces!"
				SiNo
					Limpiar Pantalla
					Escribir "*** Seleccione un candidato ***"
					Escribir "1. Juan Carlos Merida"
					Escribir "2. Jose Leonel Perez"
					Escribir "3. Maria Eugenia Alarcon"
					Escribir "Ingresa el numero correspondiente al candidato"
					leer voto
					segun voto Hacer
						1:
							vc1 <- vc1 + 1
						2:
							vc2 <- vc2 + 1
						3: 
							vc3 <- vc3 + 1
						De Otro Modo:
							vn <- vn + 1
					FinSegun
					
				FinSi
				
				//Stiven Del Cid añade sistema de porcentajes
				CV = vc1 + vc2 + vc3
				Porcentaje1 = (Vc1 / CV) * 100
				Porcentaje2 = (Vc2 / CV) * 100
				Porcentaje3 = (Vc3 / CV) * 100
				
			SiNo
				Escribir "*** Resultados de las elecciones***"
				si (vc1>vc2 y vc1>vc3) Entonces
					Escribir "El ganador es Juan Carlos Merida: ",vc1," votos" " con el " ,porcentaje1 "%"
					si (vc2>vc3) Entonces
						Escribir "Jose Leonel Perez tiene: ",vc2," votos" " con el: " ,porcentaje2 "%"
						Escribir "Maria Eugenia Alarcon tiene: ",vc3," votos" " con el:  " ,porcentaje3 "%"
					SiNo
						Escribir "Maria Eugenia Alarcon tiene: ", vc3, " votos" " con el: " ,porcentaje3 "%"
						Escribir "Jose Leonel Perez tiene: ", vc2, " votos" " con el:  " ,porcentaje2 "%"
					FinSi
				SiNo
					si (vc2>vc1 y vc2>vc3) Entonces
						Escribir "El ganador es Jose Leonel Perez con: ",vc2," votos" " con el:  " ,porcentaje2 "%"
						si (vc1>vc3) Entonces
							Escribir "Juan Carlos Merida tiene: ",vc1," votos" " con el:  " ,porcentaje1 "%"
							Escribir "Maria Eugenia Alarcon tiene: ",vc3," votos" " con el:  " ,porcentaje3 "%"
						SiNo
							Escribir "Maria Eugenia Alarcon tiene: ",vc3," votos" " con el:  " ,porcentaje3 "%"
							Escribir "Juan Carlos Merida tiene: ",vc1," votos" " con el:  " ,porcentaje1 "%"
						FinSi
					SiNo
						si (vc3>vc1 y vc3>vc2) Entonces
							Escribir "El ganador fue Maria Eugenia Alarcon con: ",vc3," votos" " con el:  " ,porcentaje3 "%"
							si (vc2>vc1) Entonces
								Escribir "Jose Leonel Perez tiene: ",vc2," votos" " con el:  " ,porcentaje2 "%"
								Escribir "Juan Carlos Merida tiene: ",vc1," votos" " con el:  " ,porcentaje1 "%"
							SiNo
								Escribir "Juan Carlos Merida tiene: ",vc1," votos" " con el:  " ,porcentaje1 "%"
								Escribir "Jose Leonel Perez tiene: ",vc2," votos" " con el:  " ,porcentaje2 "%"
							FinSi
						SiNo
							Escribir "Existe un empate entre candidatos, se deben repetir las elecciones"
						FinSi
					FinSi
				FinSi
				Escribir "votos no validos: ",vn
				if<-1
			FinSi
		FinMientras
		
FinAlgoritmo


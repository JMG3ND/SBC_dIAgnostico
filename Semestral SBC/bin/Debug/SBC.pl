enfermedadMental("Ansiedad",27).
enfermedadMental("Depresión",20).
enfermedadMental("Trastorno Alimentario",10).
enfermedadMental("Trastorno de Conducta",7).

cargar(A):-exists_file(A),consult(A).
gravedad(Enfermedad,Puntaje,4):-enfermedadMental(Enfermedad,X), Puntaje >= X/2.
gravedad(Enfermedad,Puntaje,3):-enfermedadMental(Enfermedad,X), Puntaje >= X/4 , Puntaje < X/2.
gravedad(Enfermedad,Puntaje,2):-enfermedadMental(Enfermedad,X), Puntaje < X/4 , Puntaje > 0.
gravedad(Enfermedad,Puntaje,1):- enfermedadMental(Enfermedad,_), Puntaje = 0.


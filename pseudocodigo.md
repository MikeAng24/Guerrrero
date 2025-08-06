Inicio del programa

// Variables globales
energia (entero) ← 100
fuerza (entero) ← 10
resistencia (entero) ← 10
nivel (entero) ← 1
experiencia (entero) ← 0
exit (booleano) ← falso

//------Métodos
METODO MostrarInfo()
    Imprimir "----- ESTADO -----"
    Imprimir "Energía: " + energia
    Imprimir "Fuerza: " + fuerza
    Imprimir "Resistencia: " + resistencia
    Imprimir "Nivel: " + nivel
    Imprimir "Experiencia: " + experiencia + "/" + (nivel * 50)
FIN METODO

METODO VerEstado()
    LLAMAR MostrarInfo()
FIN METODO

METODO EntrenarFuerza()
    DEFINIR maxHoras COMO ENTERO = energia / 5
    SI maxHoras < 1 ENTONCES
        Imprimir "No tienes suficiente energía para entrenar"
        RETORNAR
    FIN SI
    
    Imprimir "¿Cuántas horas vas a entrenar fuerza? Máximo permitido: " + min(maxHoras, 6)
    LEER horas
    
    SI horas > maxHoras O horas > 6 O horas < 1 ENTONCES
        Imprimir "Horas no válidas"
        RETORNAR
    FIN SI
    
    PARA i DESDE 1 HASTA horas HACER
        fuerza ← fuerza + 6
        energia ← energia - 5
        experiencia ← experiencia + 1
    FIN PARA
    
    experiencia ← experiencia + 5
    Imprimir "¡Entrenamiento completado!"
    LLAMAR SumarNivel()
    LLAMAR MostrarInfo()
FIN METODO

// --- MÉTODO NUEVO: EntrenarResistencia ---
METODO EntrenarResistencia()
    DEFINIR maxHoras COMO ENTERO = energia / 4  // La resistencia consume menos energía por hora
    
    SI maxHoras < 1 ENTONCES
        Imprimir "No tienes suficiente energía para entrenar resistencia"
        RETORNAR
    FIN SI
    
    Imprimir "¿Cuántas horas vas a entrenar resistencia? Máximo permitido: " + min(maxHoras, 8)
    LEER horas
    
    SI horas > maxHoras O horas > 8 O horas < 1 ENTONCES
        Imprimir "Horas no válidas"
        RETORNAR
    FIN SI
    
    PARA i DESDE 1 HASTA horas HACER
        resistencia ← resistencia + 5  // Gana 5 puntos de resistencia por hora
        energia ← energia - 4         // Pierde 4 puntos de energía por hora
        experiencia ← experiencia + 2 // Gana 2 puntos de experiencia por hora
    FIN PARA
    
    experiencia ← experiencia + 10  // Bonus adicional por completar el entrenamiento
    Imprimir "¡Entrenamiento de resistencia completado!"
    LLAMAR SumarNivel()
    LLAMAR MostrarInfo()
FIN METODO

// --- MÉTODO NUEVO: PelearEnemigo ---
METODO PelearEnemigo()
    // Requiere 30 puntos de energía para pelear
    SI energia < 30 ENTONCES
        Imprimir "No tienes suficiente energía para pelear (necesitas al menos 30)"
        RETORNAR
    FIN SI
    
    // Calcula poder del enemigo basado en tu nivel
    DEFINIR poderEnemigo COMO ENTERO ← (nivel * 15) + aleatorio(5, 25)
    DEFINIR miPoder COMO ENTERO ← (fuerza + resistencia) / 2
    
    // Consume energía al pelear
    energia ← energia - 30
    
    SI miPoder > poderEnemigo ENTONCES
        // Victoria: ganas más experiencia
        experiencia ← experiencia + 50
        Imprimir "¡Has derrotado al enemigo! +50 puntos de experiencia"
        
        // Posible recompensa adicional (33% de probabilidad)
        SI aleatorio(1, 3) = 1 ENTONCES
            fuerza ← fuerza + 3
            Imprimir "¡Has ganado 3 puntos extra de fuerza!"
        FIN SI
    SINO
        // Derrota: ganas menos experiencia
        experiencia ← experiencia + 20
        Imprimir "Has perdido contra el enemigo... pero ganaste 20 puntos de experiencia"
    FIN SI
    
    LLAMAR SumarNivel()
    LLAMAR MostrarInfo()
FIN METODO

METODO Dormir()
    energia ← 100
    Imprimir "Has descansado. Energía recuperada al 100%"
    LLAMAR MostrarInfo()
FIN METODO

METODO SumarNivel()
    MIENTRAS experiencia >= (nivel * 50) HACER
        experiencia ← experiencia - (nivel * 50)
        nivel ← nivel + 1
        fuerza ← fuerza + 5
        resistencia ← resistencia + 5
        Imprimir "¡Subiste al nivel " + nivel + "!"
        Imprimir "¡Has ganado 5 puntos en fuerza y resistencia!"
    FIN MIENTRAS
FIN METODO

//----Programa principal
REPETIR
    //----Menú
    MOSTRAR "----- MENÚ PRINCIPAL -----"
    MOSTRAR "1. Ver estado del personaje"
    MOSTRAR "2. Entrenar Fuerza"
    MOSTRAR "3. Entrenar Resistencia"
    MOSTRAR "4. Pelear contra un enemigo"
    MOSTRAR "5. Dormir para recuperar energía"
    MOSTRAR "6. Salir del juego"
    MOSTRAR "Elige una opción (1-6):"
    
    LEER opcion
    
    SEGUN opcion HACER
        CASO 1:
            LLAMAR VerEstado()
        
        CASO 2:
            LLAMAR EntrenarFuerza()
        
        CASO 3:
            LLAMAR EntrenarResistencia()
        
        CASO 4:
            LLAMAR PelearEnemigo()
        
        CASO 5:
            LLAMAR Dormir()
        
        CASO 6:
            exit ← verdadero
            Imprimir "¡Gracias por jugar!"
        
        OTRO CASO:
            Imprimir "Opción no válida. Por favor elige del 1 al 6"
    FIN SEGUN
HASTA QUE exit = verdadero

Fin del programa
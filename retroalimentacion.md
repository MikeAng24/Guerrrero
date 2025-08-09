# 🛡️ Hoja de Observación - Prueba cruzada de guerreros

## 1. Datos generales del guerrero evaluado

| Método        | Valor |
|-----------------|-------|
| Mostrar info   |    ✅   |
| Entrenar fuerza |   ✅    |
| entrenar resistencia       |    ✅   |
| Ataque     |     ✅  |
| Dormir   |    ✅   |

---

## 2. Pruebas de combate con enemigos personalizados

El enemigo usualmente tiene poco poder comparado con el Guerrero.

---

## 3. Evaluación del sistema de entrenamiento

### A. Entrenar fuerza

- ¿Aumenta la fuerza después de entrenar?  ❌  
- ¿Consume energía de forma proporcional a las horas? ✅ 
- ¿El entrenamiento respeta el límite de 6 horas? ✅
- Observaciones:  
  - Revisa el puntaje de tu enemigo.

### B. Entrenar resistencia

- ¿Aumenta la resistencia? ✅ 
- ¿Afecta otras estadísticas? (por ejemplo, menos energía) ✅  
- Observaciones:  
  - sin observaciones

### C. Dormir / Descansar

- ¿Recupera energía al descansar? ✅ 
- ¿Se evita sobrecargar la energía (por ejemplo, pasar de 100)? ✅ 
- Observaciones:  
  - sin observaciones

---

## 4. Progresión y balance

- ¿El personaje sube de nivel correctamente con la experiencia acumulada? ✅ 
- ¿Se siente balanceado el avance del personaje? ✅ 
- ¿Hay consecuencias claras si no tiene energía (por ejemplo, no puede entrenar)? ✅
- Observaciones:  
  - sin observaciones

---

## 5. Revisión de requisitos técnicos del código

| Requisito                                                        | Cumple ✅ / ❌ | Comentarios |
|------------------------------------------------------------------|---------------|-------------|
| Menú interactivo con `switch` que se repite                     |       ✅        |             |
| Al menos una función por actividad (Ej: `EntrenarFuerza()`)     |       ✅        |             |
| Uso de operadores aritméticos, lógicos y de comparación         |        ❌       |   Falta %          |
| Condiciones para subir de nivel, agotarse o perder una batalla |        ✅        |             |
| Validaciones de energía y límites                               |        ✅       |             |
| Decisión del usuario sobre cuántas horas invertir por acción   |         ✅      |             |
| Uso de estructuras de control (`if`, `for`, `do-while`, etc.)   |        ❌       |     Falta  `for`, `do-while`y el `while` de Verificar nivel puede ser mejorado.        |

---

## 6. Retroalimentación general

_Escribe aquí recomendaciones, mejoras o errores encontrados en la lógica del juego o en la estructura del código._  

-  
-  
-

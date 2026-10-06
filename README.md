# ConsultasSQL

Repositorio correspondiente a una entrega compuesta por **seis ejercicios desarrollados en C#**, orientados a la práctica de estructuras de datos, generación dinámica de consultas SQL, recursividad, estructuras de control, números aleatorios y sobrecarga de métodos.

## Contenido de la entrega

| Proyecto | Descripción |
|---|---|
| **Dictionary** | Utiliza un `Dictionary<string, object>` para almacenar los datos de un producto, incluyendo nombre, precio y cantidad. A partir de las claves del diccionario se construye dinámicamente una cláusula `SET` utilizando parámetros. |
| **Dictionary2** | Amplía el ejercicio anterior. Además de generar la cláusula `SET`, utiliza las claves del diccionario para construir dinámicamente una sentencia SQL `INSERT INTO productos`, incluyendo las columnas y sus respectivos parámetros. |
| **Dictionary3** | Implementa un diccionario para almacenar datos relacionados con un usuario, utilizando las claves `ID`, `Usuario` y `Rol`. Posteriormente recorre las claves mediante un ciclo `foreach` y las muestra en consola. |
| **Factorial** | Calcula y muestra los factoriales de los números del 0 al 10. El cálculo se realiza mediante un método recursivo que se llama a sí mismo hasta alcanzar el caso base. |
| **Frecuencias** | Simula **6000 lanzamientos de un dado de seis caras** utilizando la clase `Random`. Mediante una estructura `switch` contabiliza la frecuencia con la que aparece cada cara y finalmente presenta los resultados en consola. |
| **SobreCargaMetodos** | Demuestra el concepto de **sobrecarga de métodos** mediante dos versiones del método `Cuadrado`: una recibe valores de tipo `int` y otra valores de tipo `double`. El programa ejecuta ambos métodos y muestra sus resultados. |

## Conceptos aplicados

En los diferentes ejercicios se ponen en práctica conceptos fundamentales de programación en C#, entre ellos:

- Diccionarios (`Dictionary`)
- Listas (`List`)
- Ciclos `for` y `foreach`
- Estructuras `switch`
- Generación de números aleatorios con `Random`
- Métodos
- Recursividad
- Sobrecarga de métodos
- Manejo de tipos `int`, `long`, `double`, `decimal`, `string` y `object`
- Interpolación y construcción de cadenas
- Generación dinámica de sentencias SQL
- Aplicaciones de consola

## Estructura del repositorio

```text
ConsultasSQL/
│
├── Dictionary/
├── Dictionary2/
├── Dictionary3/
├── Factorial/
├── Frecuencias/
├── SobreCargaMetodos/
└── ConsultasSQL.slnx
```

Cada carpeta corresponde a un proyecto independiente dentro de una misma solución.

## Tecnologías utilizadas

**Lenguaje:** C#  
**Framework:** .NET 10.0  
**Entorno de desarrollo:** Visual Studio  
**Tipo de aplicación:** Aplicaciones de consola  


## Objetivo

El propósito de esta entrega es reforzar el uso de diferentes herramientas del lenguaje C# mediante ejercicios independientes, permitiendo practicar el manejo de colecciones, ciclos, estructuras de selección, métodos recursivos, sobrecarga y construcción dinámica de cadenas utilizadas en consultas SQL.


## Resultados


# Dictionary

<img width="1477" height="235" alt="image" src="https://github.com/user-attachments/assets/e92f18bb-0740-40e9-a81a-8d5a6b7700cf" />


# Dictionary 2

<img width="1485" height="301" alt="image" src="https://github.com/user-attachments/assets/ac9aacd9-7034-43b6-910a-2745ddb00bbd" />


# Dictionary 3

<img width="1480" height="287" alt="image" src="https://github.com/user-attachments/assets/608200eb-1f4d-428d-a9cd-2b9f5ae1ead5" />


# Factorial

<img width="1485" height="465" alt="image" src="https://github.com/user-attachments/assets/ba8302e7-089c-478e-91dd-ce1bad6a786f" />


# Frecuencias

<img width="1080" height="397" alt="image" src="https://github.com/user-attachments/assets/eedd382b-92f7-4b9f-8b1a-f6539d04a393" />


# Sobrecarga de Métodos

<img width="652" height="400" alt="image" src="https://github.com/user-attachments/assets/f2731482-1737-4ea8-989c-a3d646b7aada" />





## Autor

**Aimee Matias 4-751-2038**

Fecha: 5/10/2026

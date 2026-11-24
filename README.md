# Programación Orientada a Objetos, Arreglos y Archivos de Texto

## 1. Integrantes
- **Génesis Altagracia de la Cruz Perozo** | Matrícula: 25-SISN-2-051
- **Dalbert Yordani Hernández Alcántara** | Matrícula: 26-EISN-2-014
- **Emmanuel Javier Mercedes** | Matrícula: 26-EISN-2-023
- **Urihel Soto De Peña** | Matrícula: 26-EISN-2-032
- **Yokenddy Amparo Silvestre** | Matrícula: 26-EISN-2-002
- **Antoni Ramírez Mercedes** | Matrícula: 26-EISN-2-019

---

## 2. Descripción del Programa
Aplicación de consola desarrollada en **C#** que implementa los principios de la Programación Orientada a Objetos (POO), el manejo de arreglos unidimensionales de objetos y la persistencia de datos en disco. El sistema permite registrar la información bibliográfica de 5 libros mediante la clase `Libros`, visualizarlos de forma estructurada en pantalla y almacenarlos permanentemente en un archivo de texto plano (`.txt`).

---

## 3. Cómo Ejecutar
1. Clona este repositorio o descarga los archivos fuente del proyecto.
2. Abre la solución o carpeta del proyecto en tu entorno de desarrollo compatible con C# (Visual Studio o Visual Studio Code).
3. Compila y ejecuta el archivo principal (`Program.cs`) desde la terminal utilizando el comando `dotnet run` o iniciando la depuración en el IDE.
4. Verifica que tras finalizar la captura de datos se genere el archivo de texto correspondiente en el directorio de salida del proyecto.

---

## 4. Entrada
El usuario ingresa por teclado los datos correspondientes a **5 libros**. Para cada instancia se solicitan los siguientes atributos:
- **Código:** Identificador único del libro (Texto o entero).
- **Título:** Nombre de la obra (Texto).
- **Autor:** Nombre del autor o autores (Texto).
- **Año:** Año de publicación (Número entero).
- **Editorial:** Casa editora (Texto).
- **Número de páginas:** Cantidad total de páginas (Número entero).

---

## 5. Proceso
1. **Definición de la Clase:** Se declara la clase `Libros` encapsulando las propiedades requeridas (`Codigo`, `Titulo`, `Autor`, `Anio`, `Editorial`, `NumeroPaginas`).
2. **Almacenamiento en Memoria:** Se instancia un arreglo de objetos de tipo `Libros` con capacidad fija para 5 elementos (`Libros[] biblioteca = new Libros[5]`).
3. **Captura Iterativa:** Mediante un bucle (`for`), se recorre el arreglo solicitando cada propiedad por consola e instanciando cada objeto.
4. **Persistencia en Disco:** Haciendo uso de clases de flujo de entrada/salida (`StreamWriter` del espacio de nombres `System.IO`), se recorre el arreglo para escribir y guardar toda la información recopilada dentro de un archivo de texto (ej. `libros.txt`).

---

## 6. Salida
- **Visualización en Consola:** Imprime de forma ordenada los datos de cada libro registrado, precedidos por su respectivo encabezado identificador (`Libro 1`, `Libro 2`, `Libro 3`, `Libro 4`, `Libro 5`).
- **Archivo en Disco:** Genera o actualiza un archivo `.txt` con el respaldo completo de los 5 registros ingresados, junto con un mensaje de confirmación en consola.

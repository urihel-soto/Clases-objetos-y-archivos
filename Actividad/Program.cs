// =================================================================
        // PARTE 2 - ANTONI RAMIREZ
        // Esta es mi parte del código: hago la captura de datos, donde se
        // le piden al usuario los datos de cada uno de los 5 libros.
        // Sigue Dalbert Hernandez.
        // =================================================================

        // Captura de datos
        for (int i = 0; i < biblioteca.Length; i++)
        {
            Console.WriteLine("\n===== LIBRO " + (i + 1) + " =====");

            biblioteca[i] = new Libros();

            Console.Write("Código: ");
            biblioteca[i].Codigo = Console.ReadLine();

            Console.Write("Título: ");
            biblioteca[i].Titulo = Console.ReadLine();

            Console.Write("Autor: ");
            biblioteca[i].Autor = Console.ReadLine();

            Console.Write("Año de publicación: ");
            biblioteca[i].Anio = int.Parse(Console.ReadLine());

            Console.Write("Editorial: ");
            biblioteca[i].Editorial = Console.ReadLine();

            Console.Write("Número de páginas: ");
            biblioteca[i].NumeroPaginas = int.Parse(Console.ReadLine());
        }
// =================================================================
        // PARTE 4 - EMMANUEL
        // Esta es mi parte del código: guardo la información en el archivo
        // libros.txt, muestro el mensaje final y cierro el programa.
        // Fin del código.
        // =================================================================

        // Guardar información en archivo de texto
        using (StreamWriter archivo = new StreamWriter("libros.txt"))
        {
            for (int i = 0; i < biblioteca.Length; i++)
            {
                archivo.WriteLine("LIBRO " + (i + 1));
                archivo.WriteLine("Código: " + biblioteca[i].Codigo);
                archivo.WriteLine("Título: " + biblioteca[i].Titulo);
                archivo.WriteLine("Autor: " + biblioteca[i].Autor);
                archivo.WriteLine("Año: " + biblioteca[i].Anio);
                archivo.WriteLine("Editorial: " + biblioteca[i].Editorial);
                archivo.WriteLine("Páginas: " + biblioteca[i].NumeroPaginas);
                archivo.WriteLine("---------------------------");
            }
        }

        Console.WriteLine("\nLos datos se guardaron correctamente en libros.txt");

        Console.ReadKey();
    }
}

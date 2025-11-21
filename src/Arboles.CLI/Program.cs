internal class Program
{
    private static void Main(string[] args)
    {
        Arbol arbolito = new Arbol();
        Nodo raiz = new Nodo();
        int opc=0;

        do
        {
            Console.WriteLine("[Menu de opciones para arboles]");
            Console.WriteLine("[1. Creacion del arbol]");
            Console.WriteLine("[2. Recorrido en preorden]");
            Console.WriteLine("[3. Recorrido en inorden]");
            Console.WriteLine("[4. Recorrido en postorden]");
            Console.WriteLine("[5. Buscar un elemento del arbol]");
            Console.WriteLine("[6. Contar elementos del arbol]");
            Console.WriteLine("[7. Mostrar arbol de forma grafica]");
            Console.WriteLine("[8. Salir del programa]");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    arbolito.crear_arbol(raiz);
                    break;
                case 2:
                    Console.WriteLine("[Recorrido en preorden]");
                    arbolito.preorden(raiz);
                    break;
                case 3:
                    Console.WriteLine("[Recorrido en inorden]");
                    arbolito.inorden(raiz);
                    break;
                case 4:
                    Console.WriteLine("[Recorrido en postorden]");
                    arbolito.postorden(raiz);
                    break;
                case 5:
                    Console.WriteLine("[Buscar un elemento del arbol]");
                    arbolito.bucar(raiz);
                    break;
                case 6:
                    Console.WriteLine("[Contar elementos del arbol]");
                    arbolito.Contar();
                    break;
                case 7:
                    Console.WriteLine("[Mostrar arbol de forma grafica]");
                    arbolito.MostrarArbol(raiz);
                    break;
                case 8:
                    Console.WriteLine("[Saliendo del programa]");
                    break;
                default:
                    Console.WriteLine("[Opcion no valida]");
                    break;
            }
        } while (opc != 8);
    }
}
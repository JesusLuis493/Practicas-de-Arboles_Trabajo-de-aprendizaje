using System.Linq.Expressions;
internal class Arbol
{
    public void crear_arbol(Nodo apnodo)
    {
        char res;
        Console.WriteLine("[Introduce el valor del nodo del arbol]");
        apnodo.info = char.Parse(Console.ReadLine());
        Console.WriteLine("[Existe nodo izquierdo en {0} si o no?]", apnodo.info);
        res = char.Parse(Console.ReadLine());
        if (res == 's')
        {
            Nodo otro = new Nodo();
            apnodo.izq = otro;      //enlaza el nodo actual por la izquierda del mismo nodo
            crear_arbol(apnodo.izq);      //llamada recurva a crear arbol para crear otro nodo izquierdo
        }
        else
        {
            apnodo.izq = null;
        }
        Console.WriteLine("[Existe nodo derecho en {0} si o no]", apnodo.info);
        res = char.Parse(Console.ReadLine());
        if (res == 's')
        {
            Nodo otro = new Nodo();
            apnodo.der = otro;
            crear_arbol(apnodo.der);
        }
        else
        {
            apnodo.der = null;  //si ya no hay mas nodos por derecha se enlaza a null
        }
    }
}
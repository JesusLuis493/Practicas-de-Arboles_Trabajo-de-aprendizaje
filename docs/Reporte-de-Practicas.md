# Reporte de practicas de arboles y arboles binarios
<!-- esto solo esta para que el proyecto sea mas formal, el formato de entrega para el dosente es en docx -->

## Introduccion
Como parte de las practicas para esta unidad, se llevaron acabo las practicas de arboles, a manera de un ejemplo
un arbol en programacion es una de las estructuras prinsipales junto con las listas, colas y pilas, en este caso
lo que hace especial a los arboles (aparte de su llamativa representacion grafica) podria ser que usan posisiones
de memoria no contigua, lo que significa que no son posisiones seguidas de memoria cmo en arrelos, esto por su
composision de nodos y aristas.

Un punto importante a resaltar es que los nodos de los arboles, aparte de tener todos una clasificasion espesifica, estan compuesto de manera diferente, teniendo estos dos o mas partes para el apuntador en lugar de una como en las listas.

## Indice                           
Program.cs/      <!-- intermediario para interactura y mostrar -->                                         
└── main                <!--para poder crear un nuevo arbol-->                         
Nodo.cs/     <!-- nodo -->                                             
└── Internal class nodo <!--estructura basica del nodo-->                        
Arbol.cs/       <!-- Metodos -->                                        
├── Metodo Craer arbol  <!--metodo para llevar acabo la creacion del arbol-->                              
├── Recorrido preorden                                        
├── Recorrido inorden                                    
├── Recorrido posorden                                       
├── Buscar un elemento en el arbol                              
├── Contar elementos del arbol                                      
└── Ejercicio personal de arboles                                       

## Codigos
- [Main](src/Arboles.CLI/Program.cs)
- [Estructura_del_Nodo](src/Arboles.CORE/Nodo.cs)
- [Creador_nuevo_arbol](src/Arboles.CORE/Arbol.cs)

## Capturas de pantalla
Para fines practicos y no saturar el archivo se cargaran los resultados de los test en este apartado,
sin dejar de lado la posibilidad de algunas imagenes a manera de demostracion con fines de presentacion. 

<img width="1191" height="990" alt="Captura desde 2025-11-22 16-15-44" src="https://github.com/user-attachments/assets/ef7c61d2-41ce-4ce2-955d-37f3f8a26aff" />
<img width="1191" height="990" alt="Captura desde 2025-11-22 16-15-59" src="https://github.com/user-attachments/assets/02d53b7e-e315-4e46-b133-7631983602bb" />

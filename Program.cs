// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Console.Write("Ingrese el valor pagado del primer trimestre ");
// int trimestre1 = Int32.Parse(Console.ReadLine());


// Console.Write("Ingrese el valor pagado del segundo trimestre ");
// int trimestre2 = Int32.Parse(Console.ReadLine());

// Console.Write("Ingrese el valor pagado del tercer trimestre ");
// int trimestre3 = Int32.Parse(Console.ReadLine());

// Console.Write("Ingrese el valor pagado del cuarto trimestre ");
// int trimestre4 = Int32.Parse(Console.ReadLine());

// int renta_anual= (trimestre1+trimestre2+trimestre3+trimestre4);
// Console.Write("Su renta anual es:  "+renta_anual); 

// if(renta_anual<10000){
// Console.Write("\n El total de renta a opagar es: "+(renta_anual*0.05)+"\n El impuestso agregado fue del 5%");
// }
// if(renta_anual>=10000 && renta_anual <20000){
// Console.Write("El total de renta a opagar es: "+(renta_anual*0.1)+"El impuestso agregado fue del 10%");
// }
// if(renta_anual>=20000 && renta_anual <35000){
// Console.Write("El total de renta a opagar es: "+(renta_anual*0.15)+"El impuestso agregado fue del 15%");
// }
// if(renta_anual>=35000 && renta_anual <45000){
// Console.Write("El total de renta a opagar es: "+(renta_anual*0.20)+"El impuestso agregado fue del 20%");    
// }
// if(renta_anual>45000){
// Console.Write("El total de renta a opagar es: "+(renta_anual*0.30)+"El impuestso agregado fue del 30%");            

// }


//punto2 Escribir un programa para una sala de juegos que quiere calcular de forma automática el precio que debe cobrar a sus clientes
//por ingresar. El software solicita al usuario el nombre completo y la edad del cliente para que  muestra al final el nombre completo,
//el precio de la entrada y su descuento si lo tiene. Si el cliente es menor de 4 años puede entrar gratis, si tiene entre 4 y 18 años 
//debe pagar la entrada y tendrá un descuento del 5% y si es mayor de 18 años debe pagar la entrada y tendrá un descuento del 3%. La entrada tiene un valor de 15000$.
// Console.Write("Ingrese su nombre completo:");
// String nombre= Console.ReadLine();

// Console.Write("Ingrese su edad:");
// int edad= Int32.Parse(Console.ReadLine());

// int entrada= 15000;

// if(edad<4){
//     Console.Write(nombre+"  "+entrada+" "+"Por ser menor de edad, su entrada no tiene costo.");

// }
// if(edad>=4 && edad <=18){
//     Console.Write("Su entrada tiene un descuento del 5%, su descuento es de: "+(entrada*5/100)+" "+"El valor a pagar es: "+(entrada*-5/100+entrada));

// }
// if(edad>18){
// Console.Write("Su entrada tiene un descuento del 3%, su descuento es de: "+(entrada*3/100)+" "+"El valor a pagar es: "+(entrada*-3/100+entrada));
// }

//punto 3 ) Una pizzería llamada Pizzas el Fercho tiene pizzas vegetarianas y no vegetarianas. Los ingredientes para cada una de las pizzas aparecen a continuación.

// Ingredientes pizza vegetariana: Pimiento y champiñones.
// Ingredientes pizza no vegetarianos: Pepperoni, Salami y Pollo.

// Codificar un programa que solicite al usuario qué tipo de pizza desea, y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija uno 
// de ellos, además todas las pizzas llevan mozzarella y tomate. Al final se debe mostrar por pantalla si la pizza es vegetariana o no y todos los ingredientes que lleva.
// int opcion;
// Console.WriteLine("Elija el tipo de pizza que desea ordenar:"+
// "1: pizza vegetariana \n"+
// "2: pizza no vegetarianos \n"+
// "3: salir \n");
// int input = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// switch (input)
// {
//     case 1:

//         Console.WriteLine("Selecionar ingredientes");
//         Console.WriteLine("1 - Pimiento");
//         Console.WriteLine("2 - Champiñones");
//         input = Convert.ToInt32(Console.ReadLine());
//         Console.Clear();
//         switch (input)
//         {
//             case 1:
//                 Console.WriteLine(" La pizza es vegetariana y los Ingredientes : Pimiento, Mozzarella y Tomate ");
//                 break;

//             case 2:
//                 Console.WriteLine(" La pizza es vegetariana y los Ingredientes : Champiñones, Mozzarella y Tomate ");
//                 break;
//             default:
//                 Console.WriteLine("Salir");
//                 break;
//         }

//         break;
//     case 2:
//         Console.WriteLine("Ingredientes");
//         Console.WriteLine("1 - Pepperoni");
//         Console.WriteLine("2 - Salami");
//         Console.WriteLine("3 - Pollo");
//         input = Convert.ToInt32(Console.ReadLine());
//         Console.Clear();
//         switch (input)
//         {
//             case 1:
//                 Console.WriteLine(" La pizza no vegetariana y los Ingredientes : Pepperoni, Mozzarella y Tomate ");
//                 break;

//             case 2:
//                 Console.WriteLine(" La pizza no vegetariana y los Ingredientes : Salami, Mozzarella y Tomate ");
//                 break;

//             case 3:
//                 Console.WriteLine(" La pizza no vegetariana y los Ingredientes : Pollo, mozzarella y tomate ");
//                 break;
//             default:
//                 Console.WriteLine("Salir");
//                 break;
//         }
//         break;
//     case 3:
//         Console.WriteLine("Atras");

//         break;
//     default:
//         Console.WriteLine("Salir");
//         break;
// }
// //Punto4 En una empresa, los empleados son premiados al final de cada año por su rendimiento. 
// Los puntos que pueden tener en la evaluación son: 0.0, 0.4 y 0.6. pero no pueden tener valores
// intermedios entre las cifras mencionadas. A continuación se muestra una tabla con los niveles 
// correspondientes a cada puntuación. La bonificación de dinero de cada nivel es de 50000$ multiplicada
// por la puntuación del nivel. Al final del programa se debe imprimir el nivel de evaluación y la 
// bonificación ganada.

// Console.WriteLine("Ingrese su puntuacion para su respectiva bonificacion: ");
// double evaluación=Convert.ToDouble(Console.ReadLine());

// if(evaluación == 0.0){
//     Console.Write("Su bono es de: "+(5000*0.0)+" "+"Y su nivel fue Inaceptable.");
// }
// if(evaluación == 0.4){
//     Console.Write("Su bono es de: "+(5000*0.4)+" "+"Y su nivel fue Aceptable.");
// }
// if(evaluación == 0.6){
//     Console.Write("Su bono es de: "+(5000*0.6)+" "+"Y su nivel fue Meritorio.");
// }




        

        








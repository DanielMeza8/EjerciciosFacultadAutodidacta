using System.Xml.Linq;

class Test
{

    public double calificacionFinal(double x, double y, double z, double a, double b)
    {
        double promedio = (x + y + z) / 3;
        double parcial = promedio * .55;
        double examen = a * .3;
        double actividades = b * .15;

        double cFinal = parcial + examen + actividades;

        Console.WriteLine("Tu calficacion final es " + cFinal);

        return 0;
    }

    public double sueldoTotal(double x)
    {
        double comision = .10;
        double extraS = x * comision;


        Console.WriteLine("Numero de Comisiones en el mes: ");
        int com = Convert.ToInt32(Console.ReadLine());

        double sueldoComision = extraS * com;
        double sTotal = x + sueldoComision;

        Console.WriteLine("El sueldo total del trabajador con comision es = " + sTotal);
        Console.ReadKey();
        return 0;

    }

    public double descuentoCompra(double x)
    {
        double descuento = .15;
        double compraDescuento = x * descuento;
        double compraTotal = x - compraDescuento;

        Console.WriteLine("El total de la compra con descuento es de " + compraTotal);
        Console.ReadKey();
        return 0;

    }

    public int conversionHoras(int x)
    {
        int hora = 60;
        int horaC = x / hora;
        int horaD = x % hora;

        Console.WriteLine("\n" + x + "m equivalen a " + horaC + " h " + horaD + "m");
        Console.ReadKey();
        return 0;
    }

    public double mediaTresNumeros(double x , double y, double a)
    {
        double sumaNMumeros = x + y + a;
        double media = sumaNMumeros / 3;

        Console.WriteLine("\nla media es = " + media);
        Console.ReadKey();
        return 0;
    }

    public double conversionCelcius(double x)
    {
        double c = ((x - 32) * 5) / 9;

        Console.WriteLine("Los grados Farenheint ingresados son " + x + "\nLa conversion a grados Celcius es = " + c);
        Console.ReadKey();
        return 0;

    }

    public void gradosFarenheint()
    {
        Console.WriteLine("\nIngresa los grados Farenheint a convertis a grados Celcius ");
        double a = Convert.ToDouble(Console.ReadLine());
        conversionCelcius(a);

    }

    public double procesoOperaciones(double x, double y)
    {

        double suma = x + y;
        double resta = x - y;
        double multiplicacion = x * y;
        double division = x / y;
        Console.WriteLine("\nLos numeros ingresados son  " + x + " y " + y +
                            "\nLa suma de ambos es = " + suma +
                            "\nLa resta de ambos es = " + resta +
                            "\nLa multiplicacion de ambos es = " + multiplicacion +
                            "\nLa division de ambos es = " + division);
        Console.ReadKey();
        return 0;

    }

    public void pedirDosNumeros()
    {
        Console.WriteLine("\nIngresa un numero ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero cual sea ");
        double b = Convert.ToDouble(Console.ReadLine());

        procesoOperaciones(a, b);

    }

    public double procesoHipotenusa(double x, double y)
    {
        double h = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));

        Console.WriteLine("La hipotenusa del rectangulo es = " + h) ;
        Console.ReadKey();
        return 0;

    }

    public void datosTriangulo()
    {
        Console.WriteLine("\nIngresa el cateto a del tringulo ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el cateto b del tringulo ");
        double b = Convert.ToDouble(Console.ReadLine());

        procesoHipotenusa(a, b);

    }

    public double procesoAreaPerimetro(double x, double y)
    {
        double perimetro = 2 * (x + y);
        double area = x * y;

        Console.WriteLine("El perimetro del rectangulo es de " + perimetro + " y el area es igual a " + area);
        Console.ReadKey();
        return 0;
        
    }

    public void area_Perimetro()
    {
        Console.WriteLine("\nIngresa la base del rectangulo ");
        double bas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa la altura del rectangulo ");
        double altura = Convert.ToDouble(Console.ReadLine());

        procesoAreaPerimetro(bas, altura);  

    }

    public void nombre()
    {
        Console.WriteLine("Escribe tu nombre ");
        string nombre = Console.ReadLine(); 
        Console.WriteLine("Hola, como estas " + nombre);
        Console.ReadKey();
    }


    static void Main(String[] args)
    {
        Test obj = new Test();
        obj.nombre();
        obj.area_Perimetro();
        obj.datosTriangulo();
        obj.pedirDosNumeros();
        obj.gradosFarenheint();
        obj.mediaTresNumeros(2, 4.5, 6.8);
        obj.conversionHoras(1000);
        obj.descuentoCompra(1000);
        obj.sueldoTotal(1000);
        obj.calificacionFinal(10, 8, 9 ,10, 8);
    }
}
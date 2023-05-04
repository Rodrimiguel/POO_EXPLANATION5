var cuenta3=new Cuenta();
var cuenta1=new CajaAhorro();
cuenta1.CBU=11113131;
cuenta1.Numero=333;

var cuenta2=new CuentaCorriente();
cuenta2.Descubierto=5000;
cuenta2.Numero=444;
// cuenta2.Password="1234"; NO LO VA A TOMAR PORQUE EN LA CLASE DERIVADA EL METODO DE ACCESIBILIDAD ES PRIVADO.
cuenta1.MostrarValores();
//cuenta1.Protegido="valor cargado"; (SOLO SE PUEDE USAR EN LA CLASE BASE Y DERIVADA) DECLARADO COMO PROTECTED.
//Console.WriteLine(cuenta1.Protegido);
cuenta1.Depositar(100);
cuenta1.Extraer(50);

cuenta2.Depositar(200);
cuenta2.Extraer(100);

//cuenta1.Saldo=1000000;


var tipo1= cuenta1.GetType(); // Me devuelve el tipo del objeto 
// var tipo1 le vamos a asignar el tipo de la cuenta1
// el tipo es la clase = ESTE OBJETO DE CUENTA 1 DE QUE TIPO (CUENTA, CAJA DE AHORRO O CUENTA CORRIENTE)
Console.WriteLine(tipo1.ToString());

if(cuenta2.GetType()==typeof(CajaAhorro)){// el tipo de esta cuenta es igual a la cuenta caja de ahorro.
// el tipo este es igual a este tipo.
//typeof para las comparaciones.
    Console.WriteLine("cuenta 1 es una caja de ahorro");
}
else{

}

if(cuenta1.GetType().ToString()=="Cajaahorrro"){ // ME DEVUELVE UN STRING CON LA PALABRA CAJA DE AHORRO.

}

if(cuenta1 is Tarjeta){ // tipo de la cuenta 1 pertenece a todo el arbol. Al arbol de cuenta.

}

class Empleado{

}

class Tarjeta{

}
class Credito:Tarjeta{}
class Debito:Tarjeta{}

// SISTEMA PARA MANEJAR CUENTAS DEL BANCO.

class Cuenta{ // CLASE BASE (PADRE)
    private string Password{get;set;}

    protected string Protegido{get;set;}="valor inicial";

    internal int CBU{get;set;}
    public enum eTipoCta{
        Pesos,
        Dolares
    }
    public eTipoCta TipoCta{get;set;}
    public int Numero{get;set;}
    public string Cuil {get;set;}

    public string Nombre{get;set;}
    public string Apellido{get;set;}

    protected double Saldo{get;set;} // //cuenta1.Saldo=1000000; NO LO PUEDO HACER AFUERA, PORQUE ESTA DECLARARO COMO PROTEGIDO.
   
    

    public void Depositar(double monto){
        Saldo+=monto;
    }
}
class CajaAhorro:Cuenta { // CLASE DERIVADA (HIJA)
    

    public enum eTipoCaja{
        Comun,
        Sueldo
    }

    public eTipoCaja Tipo{get;set;}

    public int Millas{get;set;}
    public void MostrarValores(){
        Console.WriteLine("Mostrar el valor de protegido:" + Protegido); //  protected string Protegido{get;set;}="valor inicial"; (SE PODRA UTILIZAR EN CUENTA Y EN SUS CLASES DERIVADAS)
    }

    public void Extraer(double monto){
        Saldo-=monto;
        
    }
}


 
class CuentaCorriente: Cuenta{  // CLASE DERIVADA (HIJA)
    public double Descubierto{get;set;}
    public bool Chequera{get;set;}

    public void Extraer(double monto){

    }
}


// ALCANCE DE LOS MIEMBROS


// public desde cualquier proyecto (desde todos lados)

// privado solo en la clase que lo declaramos, no accesible desde afuera.

// protected desde donde lo declaramos y sus clases deriadas

// internal  (desde la liberia de clases si (proyecto modelos), no desde el programa(proyectos))

// protected internal (en sus derivadas y en el proyecto)
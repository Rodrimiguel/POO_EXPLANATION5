var cuenta3=new Cuenta();
var cuenta1=new CajaAhorro();
cuenta1.CBU=11113131;
cuenta1.Numero=333;

var cuenta2=new CuentaCorriente();
cuenta2.Descubierto=5000;
cuenta2.Numero=444;
//cuenta2.Password="1234";
cuenta1.MostrarValores();
//cuenta1.Protegido="valor cargado";
//Console.WriteLine(cuenta1.Protegido);
cuenta1.Depositar(100);
cuenta1.Extraer(50);

cuenta2.Depositar(200);
cuenta2.Extraer(100);

//cuenta1.Saldo=1000000;

var tipo1= cuenta1.GetType(); // ne devuelve el tipo
Console.WriteLine(tipo1.ToString());

if(cuenta1.GetType()==typeof(CajaAhorro)){// el tipo de esta cuenta es igual a la cuenta caja de ahorro.
//typeof para las comparaciones.
    Console.WriteLine("cuenta 1 es una caja de ahorro");
}
else{

}

if(cuenta1.GetType().ToString()=="Cajaahorrro"){

}

if(cuenta1 is Tarjeta){ // tipo de la cuenta 1 pertenece a todo el arbol. Al arbol de cuenta.

}

class Empleado{

}

class Tarjeta{

}
class Credito:Tarjeta{}
class Debito:Tarjeta{}

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

    protected double Saldo{get;set;}

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
        Console.WriteLine("Mostrar el valor de protegido:" + Protegido);
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

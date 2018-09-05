using System;
using System.Collections.Generic;

public class Principal{
	public static void Main(){
		System.Console.WriteLine("Hello World");
	}
}

class Enum{
	enum TipoCiudad {Lima, Trujillo, Chiclayo};
	enum TipoTarjeta {VISA, MASTERCARD};
}

class Sede{
	private string id;
	private string nombre;
	private TipoCiudad ciudad;
	private string direccion;
	private List<Cuenta> cuentas;
}

class Cuenta{
	private string numCuenta;
	private Cliente cliente; 

	public virtual string consultarDatos(){

	}
}

class CuentaAhorros : Cuenta{
	private float interes;
	private float saldoDisp;
	private DateTime fechaAp;

	public override string consultarDatos(){
		return numCuenta + 
		saldoDisp;
	}
}

class CuentaCredito : Cuenta{
	private float montoOtorg;
	private float montoDisp;
	private float intCompras;
	private float intRetiros;
	private DateTime fechaAp;

	public override string consultarDatos(){
		return numCuenta + 
		montoDisp;
	}
}

class Tarjeta : IConsultable{
	private string numero;
	private TipoTarjeta tipo;

	public string consultarDatos(){
		return numero + tipo;
	}
}

class Cliente : IConsultable{
	private int id;

	private virtual string consultarDatos(){

	}
}

class PersonaNatural : Cliente{
	private string dni;
	private string nombres;
	private string apPaterno;
	private string apMaterno;
	private char sexo;
	private int edad;
	private string direccion;
	private string telefono;
	private string email;
	private DateTime fechaAfili;

	public PersonaNatural(int id, 
		string dni, string nombres,
		string apPaterno, string apMaterno) :
	base(id){
		this.dni = dni;
		this.nombres = nombres;
		this.apPaterno = apPaterno;
		this.apMaterno = apMaterno;
	}

	public override string consultarDatos(){
		return dni + nombres + 
		apPaterno + apMaterno;
	}
}

class Empresa : Cliente{
	private string ruc;
	private string razonSocial;
	private string actividad;
	private string direccion;
	private string telefono;
	private string email;
	private DateTime fechaAfili;

	public Cliente(int id, 
		string ruc, string razonSocial) :
	base(id){
		this.ruc = ruc;
		this.razonSocial = razonSocial;
	}

	public override string consultarDatos(){
		return ruc + razonSocial;
	}
}

interface IConsultable{
	string consultarDatos();
}


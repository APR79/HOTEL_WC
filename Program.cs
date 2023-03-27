// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello,World Hotel!");

Console.WriteLine("Hotel WCG");
//Datos de entrada
Console.WriteLine("Cantidad de Huesped");
short _num_huesped = short.Parse(Console.ReadLine());

Console.WriteLine("Nombre Habitacion");
string _nom_hab = Console.ReadLine();

Console.WriteLine("Cantidad de dias");
short _num_dias = short.Parse(Console.ReadLine());

//Instanciar HotelGestion
var hotelUno = new HotelGestion(){
    CantidadDeHuesped = _num_huesped,
    NombreHabitacion = _nom_hab,
    NumeroDias = _num_dias
};

hotelUno.CuentaCobro();
class HotelGestion
    {
        //Propiedades
        public short CantidadDeHuesped { get; set; }
        public string NombreHabitacion { get; set; }
        public short NumeroDias { get; get; }

        //Funciones
        public short ValorEstadia(short huesp, short cantd){
            short INDIVIDUAL = 2500;
            short DOBLE = 4600;
            short FAMILIAR = 5200;

            short _precio_base = 0;
            //short _precio_con_iva = 0;
            //short _precio_con_dcto = 0;

            switch (CantidadDeHuesped)
            {
                case 1:
                    _precio_base = (short) (INDIVIDUAL * NumeroDias);
                    //_precio_con_iva = (short) (_precio_base * IVA + _precio_base);
                    //_precio_con_dcto = (short) (_precio_con_iva - DCTOUNO * _precio_con_iva);
                    break;
                case 2:
                    _precio_base = (short) (DOBLE * NumeroDias);
                    //_precio_con_iva = (short) (_precio_base * IVA + _precio_base);
                    //_precio_con_dcto = (short) (_precio_con_iva - DCTODOS * _precio_con_iva);
                    break;
                case >2:
                    _precio_base = (short) (FAMILIAR * NumeroDias);
                    //_precio_con_iva = (short) (_precio_base * IVA + _precio_base);
                    //_precio_con_dcto = (short) (_precio_con_iva - DCTOTRES * _precio_con_iva);
                    break;

                default:
                _precio_base = 0;
                //_precio_con_dcto = 0;
                break;
            }        
        }

        public short PrecioConIva(){
            double IVA = 0.19;
            short _precio_base = 0;
            _precio_base = ValorEstadia(CantidadDeHuesped, NumeroDias);
            short _precio_con_iva = 0;
            _precio_con_iva = (short) (_precio_base * IVA + _precio_base);

            return _precio_con_iva;
        }

        public short PrecioConDcto(short PrecioConIva){
            double DCTOUNO = 0.05;
            double DCTODOS = 0.09;
            double DCTOTRES = 0.15;
            short _precio_iva = PrecioConIva();
            short _precio_con_dcto = 0;


            if (CantidadDeHuesped == 1)
            {
                _precio_con_dcto = (short) (_precio_iva - DCTOUNO * _precio_iva);
            } else
            {
                if (CantidadDeHuesped == 2)
                {
                    _precio_con_dcto = (short) (_precio_iva - DCTODOS * _precio_iva);
                } else
                {
                    if (CantidadDeHuesped >= 3)
                    {
                        _precio_con_dcto = (short) (_precio_iva - DCTOTRES * _precio_iva);
                    } else
                    {
                        _precio_con_dcto = 0;
                    }
                }
            }
            return _precio_con_dcto;
        }

        public void CuentaCobro(){
            short _precio_con_iva = PrecioConIva();
            //short _precio_con_dcto = PrecioConDcto(_precio_con_iva);
            //short _precio_a_pagar = (short) (_precio_con_iva - _precio_con_dcto);
            short _precio_a_pagar = PrecioConDcto(_precio_con_iva);

            //Datos de salida
            Console.WriteLine($"Valor a pagar: ${_precio_a_pagar}");
        }

    }

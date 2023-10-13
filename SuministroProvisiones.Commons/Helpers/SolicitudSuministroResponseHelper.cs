namespace SuministroProvisiones.Commons.Helpers
{
    public static class SolicitudSuministroResponseHelper
    {
        public static TimeSpan ObtenerTiempo(string tipoClima, TimeSpan hora)
        {
            return tipoClima switch
            {
                "Soleado" => (EsHoraDeManana(hora) ? TiempoRandom(4, 6) : TiempoRandom(3, 5)),
                "Lluvioso" => (EsHoraDeManana(hora) || EsHoraDeTarde(hora)) ? TiempoRandom(6, 8) : TiempoRandom(0, 0),
                _ => EsHoraDeNoche(hora) ? TiempoRandom(2, 3) : TiempoRandom(0, 0)
            };
        }

        public static int GenerarCantidadProvisionesEntregar(int unidades)
        {
            return (unidades > 10) ? CantidadProvisionesEntregarPorOtros(unidades) : CantidadProvisionesEntregarPorFibonacci(unidades);
        }

        private static int CantidadProvisionesEntregarPorFibonacci(int numeroUnidades)
        {
            int[] serieFibonacci = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            return serieFibonacci[numeroUnidades - 1];
        }

        private static int CantidadProvisionesEntregarPorOtros(int numeroUnidades)
        {
            return (numeroUnidades > 10 && numeroUnidades <= 30) ? 30 : numeroUnidades + 2;
        }

        private static TimeSpan TiempoRandom(int minHoras, int maxHoras)
        {
            Random random = new Random();
            return new TimeSpan(random.Next(minHoras, maxHoras + 1), 0, 0);
        }

        private static bool EsHoraDeManana(TimeSpan hora)
        {
            return hora.Hours >= 6 && hora.Hours < 12;
        }

        private static bool EsHoraDeTarde(TimeSpan hora)
        {
            return hora.Hours >= 12 && hora.Hours < 19;
        }

        private static bool EsHoraDeNoche(TimeSpan hora)
        {
            return hora.Hours >= 19 && hora.Hours < 24;
        }
    }
}

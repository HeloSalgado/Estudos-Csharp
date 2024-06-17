using System.Globalization;

namespace Datas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var data = new DateTime; // Cria nova estrutura, vem com a data padrão
            // var data = new DateTime(2020, 10, 02, 8, 23, 14); // Pode criar de diferentes formas - ano, mês, dia, hora, minutos, segundos
            var data = DateTime.Now;

            // Y - year, M - mês, d - dia, h - hora, s - segundo, f - fração de segundo, z - zona
            var formatada = string.Format("{0:dd/MM/yyyy hh:mm:ss}", data);

            // t - short datetime (só a hora), d - data (sem os zeros na frente), T - hora longa, D - data longa
            // f - combina data e hora, g - combina data e hora só que curtas, r - coloca no padrão do sistema, u - padrão universal, s - utilizados nas datas JSON 
            var formatadaShort = string.Format("{0:u}", data); 

            Console.WriteLine(data); 
            //adicionarValores(data);
            //comparandoDatas(data);
            //cultureInfo(data);
            //timeZones();
            //timeSpan();

            Console.WriteLine(DateTime.DaysInMonth(2024, 2));
            Console.WriteLine(isWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // esta em horario de verão?
        }

        public static bool isWeekend(DayOfWeek today){
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }   

        public static void adicionarValores(DateTime data){
            
            Console.WriteLine(data.AddDays(-12));

            Console.WriteLine(data.AddMonths(1));

            Console.WriteLine(data.AddYears(1));
        }

        public static void comparandoDatas(DateTime data){
            // Mesmo comparadores dos inteiros 
            if(data.Date == DateTime.Now.Date){
                Console.WriteLine("É igual");
            }
        }

        public static void cultureInfo(DateTime data){
            var br = new CultureInfo("pt-BR");
            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(data.ToString("D", atual));
        }

        public static void timeZones(){
            var utcDate = DateTime.UtcNow; // utilizar em aplicações globais

            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime());

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
            Console.WriteLine(horaAustralia);

            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timeZones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("____________");
            }
        }

        public static void timeSpan(){
            var timeSpan = new TimeSpan(); // unidade de medida - calculos de hora (fração de hora, por exemplo)
            Console.WriteLine(timeSpan); // inicia vazio

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos); 

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8); // 3 parametros cria uma hora
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);           
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilisegundo = new TimeSpan(3, 5, 50, 10, 41);           
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilisegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        }
    }
}

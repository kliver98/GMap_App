using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace model
{
    public class GestionArchivo
    {
        public const String SERVICIOS = "/servicios.txt";
        public const String COORD_CALI = "/coordenadasCALI.txt";
        public const String INFO_COMUNAS = "/informacionComunas/";
        public const String BARRIOS_COMUNAS = "/barriosComunas/";
        public const String SERV_CALI = "/archivoServCALI.txt";
        private Dictionary<string, int> barriosCali;
        private string[] servicios;
        private string[,] coordenadasCALI;

        public GestionArchivo()
        {
            string path = Path.GetFullPath(@"..\..\..\") + "/data";
            /**if (!abrirDiccionarioBarrios(path+"/barrios.xml")) //Creando el diccionario con los barrios de cali si no existe
            {
                
                guardarBarriosCali(path + "/barrios.xml");
            }**/
            barriosCali = new Dictionary<string, int>();
            for (int i = 1; i < 23; i++)
            {
                string tmp = path + BARRIOS_COMUNAS + "comuna" + i + ".txt";
                string[] barriosActuales = leerArchivo(tmp);
                foreach (var item in barriosActuales)
                {
                    barriosCali[item] = i;
                }
            }
            servicios = darServicios();
        }

        private String[] leerArchivo(string path)
        {
            if (!File.Exists(path) || new FileInfo(path).Length == 0)
            {
                return null;
            }
            Stream s = File.OpenRead(path);
            String[] lectura = File.ReadAllLines(path);
            s.Close();
            return lectura;
        }

        /**private bool abrirDiccionarioBarrios(string path)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(Dictionary<string,int>));
            if (!File.Exists(path))
            {
                var ar = File.Create(path);
                ar.Close();
                return false;
            } else if(new FileInfo(path).Length==0)
            {
                return false;
            }
            Stream s = File.OpenRead(path);
            barriosCali = (Dictionary<string, int>)xmlSer.Deserialize(s);
            s.Close();
            return true;
        }

        private bool guardarBarriosCali(string path)
        {
            try
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(Dictionary<string, int>));
                Stream s = File.OpenRead(path);
                xmlSer.Serialize(s, barriosCali);
                s.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }**/

        public string[,] darCoordenadasCALI()
        {
            string path = Path.GetFullPath(@"..\..\..\") + "/data";
            coordenadasCALI = new string[23,2];
            string[] c = leerArchivo(path+COORD_CALI);
            for (int i = 0; i < 23; i++)
            {
                string[] tmp = c[i].Split(',');
                coordenadasCALI[i, 0] = tmp[0];
                coordenadasCALI[i, 1] = tmp[1];
            }
            return coordenadasCALI;
        }

        public int darNumeroComuna(String barrio)
        {
            return barriosCali[barrio];
        }

        public string[] darBarrios()
        {
            string[] b = new string[barriosCali.Count];
            int i = 0;
            foreach (var item in barriosCali)
            {
                b[i] = item.Key;
                i++;
            }
            Array.Sort<string>(b);
            return b;
        }

        public string[] darServicios()
        {
            string path = Path.GetFullPath(@"..\..\..\") + "/data";
            string[] rsp = leerArchivo(path+SERVICIOS);
            return rsp;
        }

        private int darNumeroServicio(String nombreServicio)
        {
            bool encontrado = false;
            int numero = 0;
            for (int i = 0; i < servicios.Length && !encontrado; i++)
            {
                if (string.Equals(nombreServicio, servicios[i], StringComparison.OrdinalIgnoreCase))
                {
                    numero = i + 1;
                    encontrado = true;
                }
            }
            return numero;
        }

        public bool tieneServicio(String nombreBarrio, String nombreServicio)
        {
            int numeroServicio = darNumeroServicio(nombreServicio);
            bool encontrado = false;
            if (barriosCali.ContainsKey(nombreBarrio))
            {
                if (servicios.Contains(nombreServicio))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public string[,] darCoordenadasCALIEncontradas(string barrio, string servicio)
        {
            string path = Path.GetFullPath(@"..\..\..\") + "/data";
            int comuna = darNumeroComuna(barrio);
            int num_servicio = darNumeroServicio(servicio);
            string[] arc = leerArchivo(path+SERV_CALI);
            List<int> asd = new List<int>();
            for (int i = 0; i < arc.Length; i++) //Recorre los 22 cali y ve si contiene servicio que usuario necesita
            {
                string[] temp = arc[i].Split(',');
                foreach (var item in temp)
                {
                    if (item.Equals(num_servicio.ToString()))
                    {
                        asd.Add(i);
                        break;
                    }
                }
            }
            string[,] rst = new string[asd.Count,2];
            for (int i = 0; i < asd.Count; i++)
            {
                rst[i, 0] = coordenadasCALI[asd[i],0];
                rst[i, 1] = coordenadasCALI[asd[i], 1];
            }
            return rst;
        }

        public string[] darInformacionCALI(int cali) {
            string path = Path.GetFullPath(@"..\..\..\") + "/data"+ INFO_COMUNAS;
            return leerArchivo(path+"info"+cali+".txt");
        }

    }
}

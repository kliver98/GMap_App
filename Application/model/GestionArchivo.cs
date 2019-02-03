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
        private const String SERVICIOS = "/servicios.txt";
        private const String COORD_CALI = "/coordenadasCALI.txt";
        private const String INFO_COMUNAS = "/informacionComunas/";
        private const String BARRIOS_COMUNAS = "/barriosComunas/";
        private Dictionary<string, int> barriosCali;

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
            string[,] coord = new string[23,2];
            string[] c = leerArchivo(path+COORD_CALI);
            for (int i = 0; i < 23; i++)
            {
                coord[i, 1] = c[i];
            }
            return coord;
        }

        public int darNumeroComuna(String barrio)
        {
            return barriosCali[barrio];
        }

    }
}

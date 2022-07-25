using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetoweb_Currículo
{
    public class Util
    {
        public static bool validarEMAIL(string email)
        {
            bool Validar = false;
            int Analisar = email.IndexOf("@");
            if (Analisar > 5)
            {
                if (email.IndexOf("@", Analisar + 1) > 0)
                {
                    return Validar;
                }
                int i = email.IndexOf(".", Analisar);
                if (i - 1 > Analisar)
                {
                    if (i + 1 < email.Length)
                    {
                        string r = email.Substring(i + 1, 1);
                        if (r != ".")
                        {
                            Validar = true;
                        }
                    }
                }
            }
            return Validar;
        }

        public static bool validarSite_Blog(string site)
        {
            bool Validar = false;

            if (site.StartsWith("https://") || site.StartsWith("http://"))
            {
                if (site.EndsWith(".com") || site.EndsWith(".com.br"))
                {
                    Validar = true;

                }
                else
                {
                    Console.WriteLine("Seu site deve terminar com '.com' ou '.com.br'.");

                }

            }
            else
            {
                Console.WriteLine("Seu site deve começar com 'https://' ou 'http://.");
            }
            return Validar;
        }






    }


    }


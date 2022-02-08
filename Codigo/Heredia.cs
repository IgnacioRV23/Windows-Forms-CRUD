using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioEmpresa.Codigo
{
    internal class Heredia
    {
        public String[] cantones() {
            String[] cantones = new String[] {
                "Heredia",
                "Barba",
                "Santo Domingo",
                "Santa Bárbara",
                "San Rafael",
                "San Isidro",
                "Belen",
                "Flores",
                "San Pablo",
                "Sarapiquí"
            };
            return cantones;
        }

        public String[] distritos(string canton) {
            string[] distritos = new String[] { };

            switch (canton) {
                case "Heredia":
                    String[] distritosHeredia = new String[] {
                        "Heredia",
                        "Mercedes",
                        "San Francisco",
                        "Ulloa",
                        "Vara Blanca"
                    };
                    distritos = distritosHeredia;
                    break;

                case "Barba":
                    String[] distritosBarba = new String[]{
                        "Barva",
                        "San Pedro",
                        "San Pablo",
                        "San Roque",
                        "Santa Lucía",
                        "San José de la Montaña"
                    };
                    distritos = distritosBarba;
                    break;

                case "Santo Domingo":
                    String[] distritosSantoDomingo = new String[]{
                        "Santo Domingo",
                        "San Vicente",
                        "San Miguel",
                        "Paracito",
                        "Santo Tomás",
                        "Santa Rosa",
                        "Tures",
                        "Pará"
                    };
                    distritos = distritosSantoDomingo;
                    break;

                case "Santa Bárbara":
                    String[] distritosSantaBarbara = new String[]{
                        "Santa Bárbara",
                        "San Pedro",
                        "San Juan",
                        "Jesús",
                        "Santo Domingo del Roble",
                        "Puraba"
                    };
                    distritos = distritosSantaBarbara;
                    break;

                case "San Rafael":
                    String[] distritosSanRafael = new String[]{
                        "San Rafael",
                        "San Josecito",
                        "Santiago",
                        "Angeles",
                        "Concepción"
                    };
                    distritos = distritosSanRafael;
                    break;

                case "San Isidro":
                    String[] distritosSanIsidro = new String[]{
                        "San Isidro",
                        "San José",
                        "Concepción",
                        "San Francisco"
                    };
                    distritos = distritosSanIsidro;
                    break;

                case "Belen":
                    String[] distritosBelen = new String[]{
                        "San Antonio",
                        "La Rivera",
                        "Asunción"
                    };
                    distritos = distritosBelen;
                    break;

                case "Flores":
                    String[] distritosFlores = new String[]{
                        "San Joaquín",
                        "Barrantes",
                        "Llorente"
                    };
                    distritos = distritosFlores;
                    break;

                case "San Pablo":
                    String[] distritosSanPablo = new String[]{
                        "San Pablo"
                    };
                    distritos = distritosSanPablo;
                    break;

                case "Sarapiquí":
                    String[] distritosSarapiqui = new String[]{
                        "Puerto Viejo",
                        "La Virgen",
                        "Horquetas",
                        "Llanuras del Gaspar",
                        "Cureña"
                    };
                    distritos = distritosSarapiqui;
                    break;
            }
            return distritos;
        }
    }
}
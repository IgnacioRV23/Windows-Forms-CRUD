using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioEmpresa.Codigo
{
    internal class Alajuela
    {
        public String[] cantones() {
            String[] cantones = new String[] {
                "Alajuela",
                "San Ramón",
                "Grecia",
                "San Mateo",
                "Atenas",
                "Naranjo",
                "Palmares",
                "Poas",
                "Orotina",
                "San Carlos",
                "Alfaro Ruiz",
                "Valverde Vega",
                "Upala",
                "Los Chiles",
                "Guatuso"
            };

            return cantones;
        }

        public String[] distritos(String caton) {
            String[] distritos = new String[] { };

            switch (caton)
            {
                case "Alajuela":
                    String[] distritosAlajuela = new String[] {
                        "Alajuela",
                        "San José",
                        "Carrizal",
                        "San Antonio",
                        "Guácima",
                        "San Isidro",
                        "Sabanilla",
                        "San Rafael",
                        "Río Segundo",
                        "Desamparados",
                        "Turrucares",
                        "Tambor",
                        "La Garita",
                        "Sarapiquí"
                    };
                    distritos = distritosAlajuela;
                    break;

                case "San Ramón":
                    String[] distritosSanRamon = new String[] {
                        "San Ramón",
                        "Santiago",
                        "San Juan",
                        "Piedades Norte",
                        "Piedades Sur",
                        "San Rafael",
                        "San Isidro",
                        "Angeles",
                        "Alfaro",
                        "Volio",
                        "Concepción",
                        "Zapotal",
                        "San Isidro de Peñas Blancas"
                    };
                    distritos = distritosSanRamon;
                    break;

                case "Grecia":
                    String[] distritosGrecia = new String[] {
                        "Grecia",
                        "San Isidro",
                        "San José",
                        "San Roque",
                        "Tacares",
                        "Río Cuarto",
                        "Puente Piedra",
                        "Bolívar"
                    };
                    distritos = distritosGrecia;
                    break;

                case "San Mateo":
                    String[] distritosSanMateo = new String[] {
                        "San Mateo",
                        "Desmonte",
                        "Jesús María"
                    };
                    distritos = distritosSanMateo;
                    break;

                case "Atenas":
                    String[] distritosAtenas = new String[] {
                        "Atenas",
                        "Jesús",
                        "Mercedes",
                        "San Isidro",
                        "Concepción",
                        "San José",
                        "Santa Eulalia",
                        "Escobal"
                    };
                    distritos = distritosAtenas;
                    break;

                case "Naranjo":
                    String[] distritosNaranjo = new String[] {
                        "Naranjo",
                        "San Miguel",
                        "San José",
                        "Cirrí Sur",
                        "San Jerónimo",
                        "San Juan",
                        "Rosario"
                    };
                    distritos = distritosNaranjo;
                    break;

                case "Palmares":
                    String[] distritosPalmares = new String[] {
                        "Palmares",
                        "Zaragoza",
                        "Buenos Aires",
                        "Santiago",
                        "Candelaria",
                        "Esquipulas",
                        "La Granja"
                    };
                    distritos = distritosPalmares;
                    break;

                case "Poas":
                    String[] distritosPoas = new String[] {
                        "San Pedro",
                        "San Juan",
                        "San Rafael",
                        "Carrillos",
                        "Sabana Redonda"
                    };
                    distritos = distritosPoas;
                    break;

                case "Orotina":
                    String[] distritosOrotina = new String[] {
                        "Orotina",
                        "Mastate",
                        "Hacienda Vieja",
                        "Coyolar",
                        "Ceiba"
                    };
                    distritos = distritosOrotina;
                    break;

                case "San Carlos":
                    String[] distritosSanCarlos = new String[] {
                        "Quesada",
                        "Florencia",
                        "Buenavista",
                        "Aguas Zarcas",
                        "Venecia",
                        "Pital",
                        "Fortuna",
                        "Tigra",
                        "Palmera",
                        "Venado",
                        "Cutris",
                        "Monterrey",
                        "Pocosol"
                    };
                    distritos = distritosSanCarlos;
                    break;

                case "Alfaro Ruiz":
                    String[] distritosAlfaroRuiz = new String[] {
                        "Zarcero",
                        "Laguna",
                        "Tapezco",
                        "Guadalupe",
                        "Palmira",
                        "Zapote",
                        "Brisas"
                    };
                    distritos = distritosAlfaroRuiz;
                    break;

                case "Valverde Vega":
                    String[] distritosValverdeVega = new String[] {
                        "Sarchí Norte",
                        "Sarchí Sur",
                        "Toro Amarillo",
                        "San Pedro",
                        "Rodríguez"
                    };
                    distritos = distritosValverdeVega;
                    break;

                case "Upala":
                    String[] distritosUpala = new String[] {
                        "Upala",
                        "Aguas Claras",
                        "San José o Pizote",
                        "Bijagua",
                        "Delicias",
                        "Dos Ríos",
                        "Yolillal"
                    };
                    distritos = distritosUpala;
                    break;

                case "Los Chiles":
                    String[] distritosLosChiles = new String[] {
                        "Los Chiles",
                        "Caño Negro",
                        "Amparo",
                        "San Jorge"
                    };
                    distritos = distritosLosChiles;
                    break;

                case "Guatuso":
                    String[] distritosGuatuso = new String[] {
                        "San Rafael",
                        "Buenavista",
                        "Cote"
                    };
                    distritos = distritosGuatuso;
                    break;
            }
            return distritos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioEmpresa.Codigo
{
    internal class Puntarenas
    {
        public String[] cantones() {
            String[] cantones = {
                "Puntarenas",
                "Esparza",
                "Buenos Aires",
                "Montes de Oro",
                "Osa",
                "Aguirre",
                "Golfito",
                "Coto Brus",
                "Parrita",
                "Corredores",
                "Garabito",
            };
            return cantones;
        }

        public String[] distritos(string canton) {
            string[] distritos = { };

            switch (canton) {
                case "Puntarenas":
                    String[] distritosPuntarenas = new String[] {
                        "Puntarenas",
                        "Pitahaya",
                        "Chomes",
                        "Lepanto",
                        "Paquera",
                        "Manzanillo",
                        "Guacimal",
                        "Barranca",
                        "Monte Verde",
                        "Isla del Coco",
                        "Cóbano",
                        "Chacarita",
                        "Chira (Isla)",
                        "Acapulco",
                        "El Roble",
                        "Arancibia"
                    };
                    distritos = distritosPuntarenas;
                    break;

                case "Esparza":
                    String[] distritosEsparza = new String[] {
                        "Espíritu Santo",
                        "San Juan Grande",
                        "Macacona",
                        "San Rafael",
                        "San Jerónimo"
                    };
                    distritos = distritosEsparza;
                    break;

                case "Buenos Aires":
                    String[] distritosBuenosAires = new String[] {
                        "Buenos Aires",
                        "Volcán",
                        "Potrero Grande",
                        "Boruca",
                        "Pilas",
                        "Colinas o Bajo de Maíz",
                        "Chánguena",
                        "Bioley",
                        "Brunka"
                    };
                    distritos = distritosBuenosAires;
                    break;

                case "Montes de Oro":
                    String[] distritosMontesDeOro = new String[]{
                        "Miramar",
                        "Unión",
                        "San Isidro"
                    };
                    distritos = distritosMontesDeOro;
                    break;

                case "Osa":
                    String[] distritosOsa = new String[] {
                        "Puerto Cortés",
                        "Palmar",
                        "Sierpe",
                        "Bahía Ballena",
                        "Piedras Blancas"
                    };
                    distritos = distritosOsa;
                    break;

                case "Aguirre":
                    String[] distritosAguirre = new String[] {
                        "Quepos",
                        "Savegre",
                        "Naranjito"
                    };
                    distritos = distritosAguirre;
                    break;

                case "Golfito":
                    String[] distritosGolfito = new String[] {
                        "Golfito",
                        "Puerto Jiménez",
                        "Guaycará",
                        "Pavones o Villa Conte"
                    };
                    distritos = distritosGolfito;
                    break;

                case "Coto Brus":
                    String[] distritosCotoBrus = new String[] {
                        "San Vito",
                        "Sabalito",
                        "Agua Buena",
                        "Limoncito",
                        "Pittier"
                    };
                    distritos = distritosCotoBrus;
                    break;

                case "Parrita":
                    String[] distritosParrita = new String[] {
                        "Parrita"
                    };
                    distritos = distritosParrita;
                    break;

                case "Corredores":
                    String[] distritosCorredores = new String[] {
                        "Corredores",
                        "La Cuesta",
                        "Paso Canoas",
                        "Laurel"
                    };
                    distritos = distritosCorredores;
                    break;

                case "Garabito":
                    String[] distritosGarabito = new String[] {
                        "Jacó",
                        "Tárcoles"
                    };
                    distritos = distritosGarabito;
                    break;
            }
            return distritos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioEmpresa.Codigo
{
    internal class Guanacaste
    {
        public String[] cantones(){
            String[] cantones = new String[] {
                "Liberia",
                "Nicoya",
                "Santa Cruz",
                "Bagaces",
                "Carrillo",
                "Cañas",
                "Abangares",
                "Tilarán",
                "Nandayure",
                "La Cruz",
                "Hojancha"
            };
            return cantones;
        }

        public String[] distritos(string canton) {
            String[] distritos = new String[] { };

            switch (canton) {
                case "Liberia":
                    String[] distritosLiberia = new String[]{
                        "Liberia",
                        "Cañas Dulces",
                        "Mayorga",
                        "Nacascolo",
                        "Curubande"
                    };
                    distritos = distritosLiberia;
                    break;

                case "Nicoya":
                    String[] distritosNicoya = new String[] {
                        "Nicoya",
                        "Mansión",
                        "San Antonio",
                        "Quebrada Honda",
                        "Sámara",
                        "Nosara",
                        "Belén de Nosarita"
                    };
                    distritos = distritosNicoya;
                    break;

                case "Santa Cruz":
                    String[] distritosSantaCruz = new String[] {
                        "Santa Cruz",
                        "Bolsón",
                        "Veintisiete de Abril",
                        "Tempate",
                        "Cartagena",
                        "Cuajiniquil",
                        "Diriá",
                        "Cabo Velas",
                        "Tamarindo"
                    };
                    distritos = distritosSantaCruz;
                    break;

                case "Bagaces":
                    String[] distritosBagaces = new String[] {
                        "Bagaces",
                        "Fortuna",
                        "Mogote",
                        "Río Naranjo"
                    };
                    distritos = distritosBagaces;
                    break;

                case "Carrillo":
                    String[] distritosCarrillo = new String[] {
                        "Filadelfia",
                        "Palmira",
                        "Sardinal",
                        "Belén"
                    };
                    distritos = distritosCarrillo;
                    break;

                case "Cañas":
                    String[] distritosCanias = new String[] {
                        "Cañas",
                        "Palmira",
                        "San Miguel",
                        "Bebedero",
                        "Porozal"
                    };
                    distritos = distritosCanias;
                    break;

                case "Abangares":
                    String[] distritosAbangares = new String[] {
                        "Juntas",
                        "Sierra",
                        "San Juan",
                        "Colorado"
                    };
                    distritos = distritosAbangares;
                    break;

                case "Tilarán":
                    String[] distritosTilaran = new String[] {
                        "Tilarán",
                        "Quebrada Grande",
                        "Tronadora",
                        "Santa Rosa",
                        "Líbano",
                        "Tierras Morenas",
                        "Arenal"
                    };
                    distritos = distritosTilaran;
                    break;

                case "Nandayure":
                    String[] distritosNandayure = new String[] {
                        "Carmona",
                        "Santa Rita",
                        "Zapotal",
                        "San Pablo",
                        "Porvenir",
                        "Bejuco"
                    };
                    distritos = distritosNandayure;
                    break;

                case "La Cruz":
                    String[] distritosLaCruz = new String[] {
                        "La Cruz",
                        "Santa Cecilia",
                        "Garita",
                        "Santa Elena"
                    };
                    distritos = distritosLaCruz;
                    break;

                case "Hojancha":
                    String[] distritosHojancha = new String[] {
                        "Hojancha",
                        "Monte Romo",
                        "Puerto Carrillo",
                        "Huacas"
                    };
                    distritos = distritosHojancha;
                    break;
            }

            return distritos;
        }
    }
}

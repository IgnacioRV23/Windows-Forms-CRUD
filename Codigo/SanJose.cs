using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioEmpresa.Codigo
{
    public class SanJose
    {
        public String[] cantones()
        {
            String[] cantones = new String[]
            {
                "San José",
                "Escazú",
                "Desamparados",
                "Puriscal",
                "Tarrazú",
                "Aserrí",
                "Mora",
                "Goicoechea",
                "Santa Ana",
                "Alajuelita",
                "Coronado",
                "Tibás",
                "Moravia",
                "Montes de Oca",
                "Turrubares",
                "Dota",
                "Curridabat",
                "Pérez Zeledón",
                "León Cortés"
            };
            return cantones;
        }

        public String[] distritos(String canton)
        {
            String[] distritos = new String[] { };

            switch (canton)
            {
                case "San José":
                    String[] distritosSanJose = new string[] {
                        "Carmen",
                        "Merced",
                        "Hospital",
                        "Catedral",
                        "Zapote",
                        "San Francisco de Dos Ríos",
                        "Uruca",
                        "Mata Redonda",
                        "Pavas",
                        "Hatillo",
                        "San Sebastián"
                    };
                    distritos = distritosSanJose;
                    break;

                case "Escazú":
                    String[] distritosEscazu = new string[] {
                        "Escazú",
                        "San Antonio",
                        "San Rafael"
                    };
                    distritos = distritosEscazu;
                    break;

                case "Desamparados":
                    String[] distritosDesamparados = new String[] {
                        "Desamparados",
                        "San Miguel",
                        "San Juan de Dios",
                        "San Rafael Arriba",
                        "San Antonio",
                        "Frailes",
                        "Patarrá",
                        "San Cristóbal",
                        "Rosario",
                        "Damas",
                        "San Rafael Abajo",
                        "Gravilias",
                        "Los Guido"
                    };
                    distritos = distritosDesamparados;
                    break;

                case "Puriscal":
                    String[] distritosPuriscal = new String[]{
                        "Santiago",
                        "Mercedes Sur",
                        "Barbacoas",
                        "Grifo Alto",
                        "San Rafael",
                        "Candelaria",
                        "Desamparaditos",
                        "San Antonio",
                        "Chires"
                    };
                    distritos = distritosPuriscal;
                    break;

                case "Tarrazú":
                    String[] distritosTarrazu = new String[] {
                        "San Marcos",
                        "San Lorenzo",
                        "San Calos"
                    };
                    distritos = distritosTarrazu;
                    break;

                case "Aserrí":
                    String[] distritosAserri = new String[] {
                        "Aserrí",
                        "Tarbaca o Praga",
                        "Vuelta de Jorco",
                        "San Gabriel",
                        "La Legua",
                        "Monterrey",
                        "Salitrillos"
                    };
                    distritos = distritosAserri;
                    break;

                case "Mora":
                    String[] distritosMora = new String[] {
                        "Colón",
                        "Guayabo",
                        "Tabarcia",
                        "Piedras Negras",
                        "Picagres"
                    };
                    distritos = distritosMora;
                    break;

                case "Goicoechea":
                    String[] distritosGoicoechea = new String[] {
                        "Guadalupe",
                        "San Francisco",
                        "Calle Blancos",
                        "Mata de Plátano",
                        "Ipís",
                        "Rancho Redondo",
                        "Purral"
                    };
                    distritos = distritosGoicoechea;
                    break;

                case "Santa Ana":
                    String[] distritosSantaAna = new String[] {
                        "Santa Ana",
                        "Salitral",
                        "Pozos o Concepción",
                        "Uruca o San Joaquín",
                        "Piedades",
                        "Brasil"
                    };
                    distritos = distritosSantaAna;
                    break;

                case "Alajuelita":
                    String[] distritosAlajuelita = new String[] {
                        "Alajuelita",
                        "San Josecito",
                        "San Antonio",
                        "Concepción",
                        "San Felipe"
                    };
                    distritos = distritosAlajuelita;
                    break;

                case "Coronado":
                    String[] distritosCoronado = new String[] {
                        "San Isidro",
                        "San Rafael",
                        "Dulce Nombre o Jesús",
                        "Patalillo",
                        "Cascajal"
                    };
                    distritos = distritosCoronado;
                    break;

                case "Acosta":
                    String[] distritosAcosta = new String[] {
                        "San Ignacio",
                        "Guaitil",
                        "Palmichal",
                        "Cangrejal",
                        "Sabanillas"
                    };
                    distritos = distritosAcosta;
                    break;

                case "Tibás":
                    String[] distritosTibas = new String[] {
                        "San Juan",
                        "Cinco Esquinas",
                        "Anselmo Llorente",
                        "León XIII",
                        "Colima"
                    };
                    distritos = distritosTibas;
                    break;

                case "Moravia":
                    String[] distritosMoravia = new String[] {
                        "San Vicente",
                        "San Jerónimo",
                        "La Trinidad"
                    };
                    distritos = distritosMoravia;
                    break;

                case "Montes de Oca":
                    String[] distritosMontesDeOca = new String[] {
                        "San Pedro",
                        "Sabanilla",
                        "Mercedes o Betania",
                        "San Rafael"
                    };
                    distritos = distritosMontesDeOca;
                    break;

                case "Turrubares":
                    String[] distritosTurrubares = new String[] {
                        "San Pablo",
                        "San Pedro",
                        "San Juan de Mata",
                        "San Luis",
                        "Carara"
                    };
                    distritos = distritosTurrubares;
                    break;

                case "Dota":
                    String[] distritosDota = new String[] {
                        "Santa María",
                        "Jardín",
                        "Copey"
                    };
                    distritos = distritosDota;
                    break;

                case "Curridabat":
                    String[] distritosCurridabat = new String[] {
                        "Curridabat",
                        "Granadilla",
                        "Sánchez",
                        "Tirrases"
                    };
                    distritos = distritosCurridabat;
                    break;

                case "Pérez Zeledón":
                    String[] distritosPerezZeledon = new String[] {
                        "San Isidro",
                        "General",
                        "Daniel Flores",
                        "Rivas",
                        "San Pedro",
                        "Platanares",
                        "Pejibaye",
                        "Cajón o Carmen",
                        "Barú",
                        "Río Nuevo",
                        "Páramo"
                    };
                    distritos = distritosPerezZeledon;
                    break;

                case "León Cortés":
                    String[] distritosLeonCortes = new String[] {
                        "San Pablo",
                        "San Andrés",
                        "Llano Bonito",
                        "San Isidro",
                        "Santa Cruz",
                        "San Antonio"
                    };
                    distritos = distritosLeonCortes;
                    break;
            }
                return distritos;
        }
    }
}
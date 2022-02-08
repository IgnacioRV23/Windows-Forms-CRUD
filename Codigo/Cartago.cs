using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioEmpresa.Codigo
{
    internal class Cartago
    {
        public String[] cantones() {
            String[] cantones = new String[] {
                "Cartago",
                "Paraíso",
                "La Unión",
                "Jiménez",
                "Turrialba",
                "Alvarado",
                "Oreamuno",
                "Guarco",
            };
            return cantones;
        }

        public String[] distritos(string canton) {
            String[] distritos = new String[] { };

            switch (canton) {
                case "Cartago":
                    String[] distritosCartago = new String[] {
                        "Oriental",
                        "Occidental",
                        "Carmen",
                        "San Nicolás",
                        "Aguacaliente (San Francisco)",
                        "Guadalupe (Arenilla)",
                        "Corralillo",
                        "Tierra Blanca",
                        "Dulce Nombre",
                        "Llano Grande",
                        "Quebradilla"
                    };
                    distritos = distritosCartago;
                    break;

                case "Paraíso":
                    String[] distritosParaiso = new String[]{
                        "Paraíso",
                        "Santiago",
                        "Orosi",
                        "Cachí",
                        "Llanos de Sta Lucia"
                    };
                    distritos = distritosParaiso;
                    break;

                case "La Unión":
                    String[] distritosLaUnion = new String[]{
                        "Tres Ríos",
                        "San Diego",
                        "San Juan",
                        "San Rafael",
                        "Concepción",
                        "Dulce Nombre",
                        "San Ramón",
                        "Río Azul"
                    };
                    distritos = distritosLaUnion;
                    break;

                case "Jiménez":
                    String[] distritosJimenez = new String[]{
                        "Juan Viñas",
                        "Tucurrique",
                        "Pejibaye"
                    };
                    distritos = distritosJimenez;
                    break;

                case "Turrialba":
                    String[] distritosTurrialba = new String[]{
                        "Turrialba",
                        "La Suiza",
                        "Peralta",
                        "Santa Cruz",
                        "Santa Teresita",
                        "Pavones",
                        "Tuis",
                        "Tayutic",
                        "Santa Rosa",
                        "Tres Equis",
                        "La Isabel",
                        "Chirripo"
                    };
                    distritos = distritosTurrialba;
                    break;

                case "Alvarado":
                    String[] distritosAlvarado = new String[]{
                        "Pacayas",
                        "Cervantes",
                        "Capellades"
                    };
                    distritos = distritosAlvarado;
                    break;

                case "Oreamuno":
                    String[] distritosOreamuno = new String[]{
                        "San Rafael",
                        "Cot",
                        "Potrero Cerrado",
                        "Cipreses",
                        "Santa Rosa"
                    };
                    distritos = distritosOreamuno;
                    break;

                case "Guarco":
                    String[] distritosGuarco = new String[]{
                        "El Tejar",
                        "San Isidro",
                        "Tobosi",
                        "Patio de Agua"
                    };
                    distritos = distritosGuarco;
                    break;
            }

            return distritos;
        }
    }
}

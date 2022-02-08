using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioEmpresa.Codigo
{
    internal class Limon
    {
        public String[] cantones() {
            String[] cantones = new String[] {
                "Limón",
                "Pococí",
                "Siquirres",
                "Talamanca",
                "Matina",
                "Guacimo"
            };
            return cantones;
        }

        public String[] distritos(string canton) {
            string[] distritos = new String[] { };

            switch (canton) {
                case "Limón":
                    String[] distritosLimon = new String[] {
                        "Limón",
                        "Valle  La Estrella",
                        "Río Blanco",
                        "Matama"
                    };
                    distritos = distritosLimon;
                    break;

                case "Pococí":
                    String[] distritosPococi = new String[] {
                        "Guápiles",
                        "Jiménez",
                        "Rita",
                        "Roxana",
                        "Cariari",
                        "Colorado"
                    };
                    distritos = distritosPococi;
                    break;

                case "Siquirres":
                    String[] distritosSiquirres = new String[] {
                        "Siquirres",
                        "Pacuarito",
                        "Florida",
                        "Germania",
                        "Cairo",
                        "Alegría"
                    };
                    distritos = distritosSiquirres;
                    break;

                case "Talamanca":
                    String[] distritosTalamanca = new String[] {
                        "Bratsi",
                        "Sixaola",
                        "Cahuita",
                        "Telire"
                    };
                    distritos = distritosTalamanca;
                    break;

                case "Matina":
                    String[] distritosMatina = new String[] {
                        "Matina",
                        "Batán",
                        "Carrandí"

                    };
                    distritos = distritosMatina;
                    break;

                case "Guacimo":
                    String[] distritosGuacimo = new String[] {
                        "Guácimo",
                        "Mercedes",
                        "Pocora",
                        "Río Jiménez",
                        "Duacarí"
                    };
                    distritos = distritosGuacimo;
                    break;
            }

            return distritos;
        }
    }
}

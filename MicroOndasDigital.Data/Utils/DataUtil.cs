using MicroOndasDigital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Data.Utils
{
    public static class DataUtil
    {
        public static List<ProgramaModel> ProgramaLista = new List<ProgramaModel>() {
            new ProgramaModel(){
                 Nome = "Frango",
                 Descricao = "Assar frango inteiro rápido",
                 Potencia = 7,
                 TagList = new string[]{ "frango", "ave", "aves" },
                 TempoMin = 1,
                 TempoSeg = 00,
                 Pontuacao = "f"
            },
            new ProgramaModel(){
                 Nome = "Carne",
                 Descricao = "Assar carne 1kg",
                 Potencia = 8,
                 TagList = new string[]{ "boi", "costela", "alcatra", "carne" },
                 TempoMin = 2,
                 TempoSeg = 00,
                 Pontuacao = "c"
            },
            new ProgramaModel(){
                 Nome = "Pipoca",
                 Descricao = "Estourar pipoca padrão",
                 Potencia = 3,
                 TagList = new string[]{ "pipoca", "milho" },
                 TempoMin = 0,
                 TempoSeg = 5,
                 Pontuacao = "i"
            },
            new ProgramaModel(){
                 Nome = "Peixe",
                 Descricao = "Assar peixe",
                 Potencia = 6,
                 TagList = new string[]{ "peixe", "tilapia" },
                 TempoMin = 0,
                 TempoSeg = 30,
                 Pontuacao = "p"
            },
            new ProgramaModel(){
                 Nome = "Lasanha",
                 Descricao = "Cozinhar lasanha de microondas padrão",
                 Potencia = 5,
                 TagList = new string[]{ "lasanha" },
                 TempoMin = 0,
                 TempoSeg = 40,
                 Pontuacao = "l"
            }
        };
    }
}

using System;

namespace Educacional
{
    class Instituicao
    {
        // declaração dos atributos
        private string nomeInst;
        private string dataFundacao;
        private string areaAtuacao;
        private int qdeAnosExistencia;
        private int qdeCursos;

        // metodos 
        public void lerDados()
        {
            Console.Write("\n    Nome da Instituição:  ");
            nomeInst = Console.ReadLine();
            Console.Write("\n    Data da fundação:  ");
            dataFundacao = Console.ReadLine();
            Console.Write("\n    Área de atuação:  ");
            areaAtuacao = Console.ReadLine();
            Console.Write("\n    Anos de existência:  ");
            qdeAnosExistencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n    Quantidade de cursos:  ");
            qdeCursos = Convert.ToInt32(Console.ReadLine());
        }
        public void mostrarDados() => Console.WriteLine("\n ---- Dados da Intituição ----" +
                "\n Instituição: " + nomeInst +
                "\n Data de Fundação: " + dataFundacao +
                "\n Área de Atuação: " + areaAtuacao +
                "\n Quantidade de Anos de existência: " + qdeAnosExistencia + " anos " +
                "\n Quantidade de Cursos: " + qdeCursos);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Educacional
{
    class Curso
    {
        // declaração
        private string nomeCurso;
        private int    qdeAnos;
        private int    qdeSemestre;
        private int    cargaHoraria;
        // declaração de um objeto da classe Instituição
        // esse objeto é um atributo da classe Curso
        private Instituicao instituicao; 

        // métodos
        public void lerDados()
        {
            Console.WriteLine(" Dados da Instituição: ");
            instituicao = new Instituicao();
            instituicao.lerDados();
            Console.WriteLine(" Dados do curso: ");
            Console.Write("\n Nome do Curso: ");
            nomeCurso = Console.ReadLine();
            Console.Write("\n Duração do curso em anos: ");
            qdeAnos = Convert.ToInt32(Console.ReadLine());

            qdeSemestre = qdeAnos * 2;

            Console.Write("\n Carga Horária do Curso: ");
            cargaHoraria = Convert.ToInt32(Console.ReadLine());
        }
        public void mostrarDados()
        {
            instituicao.mostrarDados();
            Console.WriteLine("\n --- Dados do Curso ---" +
                "\n Nome do Curso: " + nomeCurso +
                "\n Duração do Curso: " + qdeAnos + " anos " +
                "\n Quantidade de Semestres: " + qdeSemestre +
                "\n Carga Horária: " + cargaHoraria + "h");
        }


        
    }
}

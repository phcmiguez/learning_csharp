using System.Collections.ObjectModel;

namespace learning_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alunos = new Dictionary<int, string>();
            alunos.Add(1, "Pedro");
            alunos.Add(2, "Adriele");
            alunos.Add(3, "Théo");
            alunos.Add(4, "Alice");

            bool checkRepeated(string name, Dictionary<int, string> dict)
            {
                return dict.ContainsValue(name) ? true : false;
            }

            foreach (var aluno in alunos)
            {
                string name = aluno.ToString();
                if(!checkRepeated(name, alunos))
                {
                    Console.WriteLine($"Chave => {aluno.Key} --- Valor => {aluno.Value}");
                }
            }

        }
        
    }
}
using _247Locacao.Domain.Entities.DicionarioDeDados;
using Projeto247Locacao.Domain.Entities;
using System;

namespace _247Locacao.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma nova instância da entidade
            Entity myEntity = new Entity();

            // Configura o campo 'Name' da entidade (observe que o campo 'Id' é somente leitura)
            myEntity.Name.DefaultValue = "Nome Exemplo";  // Lembre-se, isso apenas muda o valor padrão, não o valor atual
            myEntity.Name.IsReadOnly = false;
            myEntity.Name.Label = "Nome Completo";

            // Imprime os valores dos campos no console
            Console.WriteLine("ID: " + myEntity.Id.DefaultValue);  // ID é um campo somente leitura
            Console.WriteLine("Nome: " + myEntity.Name.DefaultValue);
            Console.WriteLine("É somente leitura: " + myEntity.Name.IsReadOnly);
            Console.WriteLine("Rótulo: " + myEntity.Name.Label);
            Console.WriteLine("Descrição: " + myEntity.Name.FieldDescription);

            // Mantém o console aberto até que uma tecla seja pressionada
            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();            // Cria uma nova instância dos campos associados ao usuário e testa.
        }
    }
}

namespace ConsoleApplication;

class Program {
    static void Main(string[] args) {
        string pastaProcura = @"\\profiles\usersprofiles$\tc829242\Desktop\pasta_Teste";

        if (Directory.Exists(pastaProcura)) {

            DateTime dataCriacao = DateTime.Now.AddDays(-1);

            string[] arquivos = Directory.GetFiles(pastaProcura, "*.txt", SearchOption.AllDirectories);

            foreach (string arquivo in arquivos) {

                FileInfo info = new FileInfo(arquivo);

                if (info.CreationTime < dataCriacao) {

                    Console.WriteLine("Arquivo: {0} - Data: {1}", info.Name, info.CreationTime);

                    File.Delete(arquivo);
                }
            }
            Console.WriteLine("Arquivos antigos foram deletados. ");
        }
        else {
            Console.WriteLine("Pasta não existe. ");
        }
    }
}

using System.IO;
using System.Text.Json;

using aula3005.Models;

string caminho = "produtos.txt";
string conteudo = "Produto: Caneta - Quantidade: 20 - Preço: 8.50";

// Grava (sobrescreve) o conteúdo no arquivo
File.WriteAllText(caminho, conteudo);

var linhas = new List<string>{
    "Produto: Caderno - Quantidade: 10 - Preço: 12.50",
    "Produto: Caneta - Quantidade: 50 - Preço: 1.99"
};

// Grava todas as linhas
File.WriteAllLines(caminho, linhas);

//Adiciona texto a um arquivo com AppendAllText
string novaLinha = "Produto: Lápis - Quantidade: 100 - Preço: 0.99";
File.AppendAllText(caminho, novaLinha + Environment.NewLine);

//Adiciona texto a um arquivo com StreamWriter
using (StreamWriter sw = new StreamWriter(caminho, true))
{  // true = append
    sw.WriteLine("Produto: Borracha - Quantidade: 20 - Preço: 0.50");
}

//Lê o conteúdo de um arquivo
if (File.Exists(caminho))
{
    string[] linhasLeitura = File.ReadAllLines(caminho);
    foreach (var linha in linhasLeitura)
    {
        Console.WriteLine(linha);
    }
}

//Gravando dados complexos com JSON
var produtos = new List<Produto> {
    new Produto(1, "Caderno", 10, 12.5),
    new Produto(2, "Caneta", 50, 1.99)
};

string caminhoJson = "produtos.json";

// Serializa e grava
string json = JsonSerializer.Serialize(produtos, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText(caminhoJson, json);

//Lendo JSON
string jsonLido = File.ReadAllText(caminhoJson);
var produtosLidos = JsonSerializer.Deserialize<List<Produto>>(jsonLido);
foreach (var prod in produtosLidos){
    Console.WriteLine(prod.ToString());
}

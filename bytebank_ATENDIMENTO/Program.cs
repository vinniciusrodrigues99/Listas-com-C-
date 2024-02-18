using System.Runtime.ExceptionServices;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
int[] idades = new int[5];
// TestaArrayInt();
// TestaBuscaPalavra();

void TestaArrayInt() {
  idades[0] = 15;
  idades[1] = 28;
  idades[2] = 35;
  idades[3] = 50;
  idades[4] = 28;
  Console.WriteLine($"Tamanho do Array {idades.Length}");
  int acumulador = 0;
  foreach (var idade in idades){
      Console.WriteLine(idade);
      acumulador +=idade;
  }
  int media = acumulador/idades.Length;
  Console.WriteLine($"Soma das idades: {acumulador}");
  Console.WriteLine($"Média das idades: {media}");
}
void TestaBuscaPalavra() {

  string[] ArrayDePalavras = new string[5];
  int i = 0;
  foreach (var palavra in ArrayDePalavras) {
    Console.Write($"Digite a {i+1}ª palavra: ");
    ArrayDePalavras[i] = Console.ReadLine();   //O método ReadLine retorna uma string
    i++;
  }

  Console.Write("Digite a palavra a ser buscada:");
  var busca = Console.ReadLine();
  bool encontrou = false;

  for ( int j = 0; j < ArrayDePalavras.Length; j++) {
    if (busca == ArrayDePalavras[j]) { //if (busca.Equals(ArrayDePalavras[j]))
      Console.WriteLine($"A palavra foi encontrada na posição {j+1}");
      encontrou = true;
    }
  }
  if (!encontrou)
    throw new Exception("Palavra não encontrada");
}

// Array amostra = Array.CreateInstance(typeof(double), 5);
// amostra.SetValue(5.9,0);
// amostra.SetValue(1.8,1);
// amostra.SetValue(7.1,2);
// amostra.SetValue(10,3);
// amostra.SetValue(6.9,4);

// TestaMediana(amostra);
void TestaMediana(Array array) //TestaMediana recebe como parâmetro um array do tipo Array
{
  if(array == null || array.Length ==0) //verficando se o array é nulo ou vazio
  Console.WriteLine("Array para o cálculo da mediana está nulo");

  double[] numerosOrdenados = (double [])array.Clone();  //Clonando um array e convertendo para um array do tipo double
  Array.Sort(numerosOrdenados); //Ordenando o array com o método Sort

  int tamanho = numerosOrdenados.Length;  //Obtendo o tamanho do array
  int meio = tamanho / 2; //Obtendo o meio do array
  double mediana = tamanho % 2 == 0 ? (numerosOrdenados[meio-1] + numerosOrdenados[meio]) / 2 : numerosOrdenados[meio]; // ? : operador ternário que retorna um true ou false
  Console.WriteLine($"Com base na amostra a mediana é = {mediana}");
}

//Desáfio da Alura
//Criar um método que recebe um array de inteiros e retorna a média dos valores
Array Valores = Array.CreateInstance(typeof(double), 5);
int i = 0;
foreach(var valor in Valores)
{
  double [] cloneValores = (double [])Valores.Clone();
  Console.Write($"Digite o {i+1}º valor: ");
  cloneValores[i] = double.Parse(Console.ReadLine());
  Valores = cloneValores;
  i++;
}
string valoresDigitados = "";
int j = 0;
foreach( var valor in Valores)
{
  valoresDigitados += Valores.GetValue(j); 
  j++;
  if(j < Valores.Length)
  {
    valoresDigitados += ", ";
  }
  else
  {
    valoresDigitados += ".";
    Console.WriteLine($"Os valores digitados foram: {valoresDigitados}");
  }
}
MediaSimples(Valores);

void MediaSimples(Array array){
  if( array == null || array.Length < 0)
    throw new Exception("Array para o cálculo da média está nulo ou vazio");
  else 
  {
    Array.Sort(array);
    int tamanho = array.Length;
    double acumulador = 0;
    foreach (var valor in array)
    {
      acumulador += (double)valor;
    }
    double media =   acumulador / tamanho;
    Console.WriteLine($"A média dos valores da lista é {media}");
  }
}
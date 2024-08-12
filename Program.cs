/*
 1 - Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada 
     com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
*/

Console.Write("Digite o seu nome: ");
var name = Console.ReadLine();

Console.WriteLine($"Olá {name}, Seja muito bem-vindo!");

/*
2 - Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao 
    final exiba o nome completo. 
*/

Console.Write("Digite o seu nome: ");
name = Console.ReadLine();
Console.Write("Digite o seu sobrenome: ");
var lastname = Console.ReadLine();

Console.WriteLine($"{name} {lastname}");

/*
3 - Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.
*/

var numberOne = 3.2d;
var numberTwo = 2.5d;

Console.WriteLine($"Valor 1: {numberOne} \nValor 2: {numberTwo}");
Console.WriteLine($"Soma dos valores: {numberOne + numberTwo}");
Console.WriteLine($"Subtração dos valores: {numberOne - numberTwo}");
Console.WriteLine($"Multiplicação dos valores: {numberOne * numberTwo}");

if (numberTwo > 0)
{
    Console.WriteLine($"Divisão dos valores: {numberOne / numberTwo}");
}

Console.WriteLine($"Média dos valores: {(numberOne + numberTwo) / 2}");

/*
4 - Crie um programa em que o usuário digita uma ou mais palavras e 
    é exibido a quantidade de caracteres que a palavra inserida tem.
*/

Console.Write("Digite uma palavra: ");
var word = Console.ReadLine();

var numberOfCharacters = 0;
for (int i = 0; i < word?.Length; i++)
{
    if (word[i] != ' ') numberOfCharacters++;
}

Console.WriteLine($"A quantidade de caracteres da palavra digitada é: {numberOfCharacters}");

/*
5 - Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica 
    se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    
    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
*/

#pragma warning disable CS8602 // Dereference of a possibly null reference.
Console.WriteLine("Digite o número de uma placa de carro: ");
var plateNumber = Console.ReadLine();
var isValidPlateNumber = true;

if (plateNumber?.Length != 7) isValidPlateNumber = false;

if (!plateNumber.ToString().All(Char.IsLetterOrDigit)) isValidPlateNumber = false;

var partOfPlateNumber = plateNumber.Substring(0, 3);
if (!partOfPlateNumber.All(Char.IsLetter)) isValidPlateNumber = false;

partOfPlateNumber = partOfPlateNumber.Substring(3, 4);
if (!partOfPlateNumber.All(Char.IsDigit)) isValidPlateNumber = false;

var result = isValidPlateNumber ? "Verdadeiro" : "Falso";
Console.WriteLine($"O número da placa é: {result}");
#pragma warning restore CS8602 // Dereference of a possibly null reference.

/*
6 - Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso. 
*/

var now = DateTime.Now;
var formatOne = now.ToString("dddd MM MMMM yyyy HH:mm:ss");
var formatTwo = now.ToString("dd/MM/yyyy");
var formatThree = now.ToString("HH");
var formatFour = now.ToString("dd de MMMM de yyyy");

Console.WriteLine($"Formato 1: {formatOne}");
Console.WriteLine($"Formato 2: {formatTwo}");
Console.WriteLine($"Formato 3: {formatThree}");
Console.WriteLine($"Formato 4: {formatFour}");

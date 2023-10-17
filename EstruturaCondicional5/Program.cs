using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');
int cod = int.Parse(vet[0]);
int qtd = int.Parse(vet[1]);

double total;
if (cod == 1) {
    total = qtd * 4.00;
} else if (cod == 2) {
    total = qtd * 4.50;
} else if (cod == 3) {
    total = qtd * 5.00;
} else if (cod == 4) {
    total = qtd * 2.00;
} else {
    total = qtd * 1.50;
}

Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
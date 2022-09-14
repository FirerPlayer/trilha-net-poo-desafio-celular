using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Cria 2 Nokias e 2 iPhones - código generalizado

int qtNokias = 2;
int qtIphones = 2;
List<Nokia> nokias = new List<Nokia>();
List<Iphone> iphones = new List<Iphone>();

for (int i = 0; i < qtNokias; i++)
{
    nokias.Add(new Nokia($"9194-{i}839", $"Modelo Nokia A{i}", $"ABFD000{i}",i*1024));
}
for (int i = 0; i < qtIphones; i++)
{
    iphones.Add(new Iphone($"85641-{i}839", $"iPhone C{i}", $"ZYQI000{i}",i*2048));
}

// Liga todos os Smartphones
foreach (Iphone ip in iphones)
{
    ip.Ligar();
}
foreach (Nokia nk in nokias)
{
    nk.Ligar();
}

// Instala o Google Ghrome em todos os Smartphones
foreach (Iphone ip in iphones)
{
    ip.InstalarAplicativo("Google Ghrome");
}
foreach (Nokia nk in nokias)
{
    nk.InstalarAplicativo("Google Ghrome");
}
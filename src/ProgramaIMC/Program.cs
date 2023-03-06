double altura, peso, imc;
string sexo;

double AlturaDigitada()
{
    Console.Write("Digite sua altura: ");
    return double.Parse(Console.ReadLine());
}

altura = AlturaDigitada();

double PesoDigitado()
{
    Console.Write("Digite seu peso: ");
    return double.Parse(Console.ReadLine());
}

peso = PesoDigitado();

string Sexo()
{
    Console.Write("Digite feminino ou masculino para informar seu sexo e seu IMC ser calculado: ");
    return Console.ReadLine();
}

sexo = Sexo();

void IMC()
{
    if ((peso != 0) && (altura != 0))
    {
        imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é: {imc} e você está: ");

        if(sexo == "feminino")
        {
            if(imc < 19.1)
            {
                Console.WriteLine(" Abaixo do peso");
            } else if (imc < 25.9)
            {
                Console.WriteLine("Peso ideal");
            }else if (imc < 27.4)
            {
                Console.WriteLine("Pouco acima do peso");
            }else if (imc < 32.4)
            {
                Console.WriteLine("Acima do peso");
            }else
            {
                Console.WriteLine("Obesidade");
            }
        } else
        {
            if(imc < 20.7)
            {
                Console.WriteLine("Abaixo do peso");
            }else if (imc < 26.5)
            {
                Console.WriteLine("Peso ideal");
            }else if (imc < 27.9)
            {
                Console.WriteLine("Pouco acima do peso");
            }else if (imc < 31.2)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
            
        }
    }

}
IMC();
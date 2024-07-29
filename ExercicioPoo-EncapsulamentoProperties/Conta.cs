namespace Exercicio;

class Conta
{

    public int Numero { get; set; }
    public string Titular { get; set; }

    private double _saldo = 0;

    private double _taxa = 5;
    
    public double Saldo
    {
        get { return _saldo; }
        set
        {
            if (value > 0)
            {
                _saldo += value;
            }
        }
}


    public void Saque(double valor)
    {
        _saldo = _saldo - valor - _taxa;
    } 
    
}

    
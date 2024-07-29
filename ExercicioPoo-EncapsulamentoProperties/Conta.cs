namespace Exercicio;

class Conta
{

    public int Numero { get; set; }
    public string Titular { get; set; }

    private double _saldo = 0;
    
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
    
    
    
}
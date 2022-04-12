 public class Conta
 {
     public int Codigo {get;}
     public double Saldo { get; private set;}  

     public Conta(int codigo)
     {
        Codigo = codigo ;
        Saldo = 0.0 ;
     }

     public void Sacar(double valor)
    {

      VerificarValor(valor);
      Saldo =  Saldo - valor;
    }
    
     public void Depositar(double valor)
     {
       VerificarValor(valor);
       Saldo =  Saldo + valor;
     }
     public void Transferir (double valor, Conta conta )
     {
           VerificarValor(valor);
           VerificarSaldo(valor

     }
      
      public void VerificarValor(double valor)
      {
       if(valor <= 0.0) throw new ArgumentException("Valor deve ser maior que zero");
      }
      public void VerificarSaldo(double valor )
       {
           if(valor )
       }

         
   


}

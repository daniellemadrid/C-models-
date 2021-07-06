namespace servico.Models
{

    public static class Dados
    {
       public static Servico servicoAtual {get; set;}

       static Dados(){
           servicoAtual = new Servico ();
       }
    }

}
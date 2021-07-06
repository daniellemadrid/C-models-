using System.Collections.Generic;
namespace servico.Models
{
  
  public class Servico{
      
      private static List<ItemServico> listaDeItens = new List<ItemServico>();
      
      public void adicionaServico(ItemServico servico){
          listaDeItens.Add(servico);
      }
      public static double totalServico(){
          double total = 0;

          foreach(var lista in listaDeItens){
              total = total + lista.valorUnitario * lista.quantidade;
          }
          return total;
      }
      public List<ItemServico> listaServicos(){
          return listaDeItens;
      }
  }


}
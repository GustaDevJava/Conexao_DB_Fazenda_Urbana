using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Plantio
    {
        protected int id;
        protected string nomeProduto;
        protected string status;
        protected int? quantidade;
        protected int?fazendaId;
        protected string nomePlantio;
        protected DateTime? dataPlantacao;
        protected DateTime? dataColheita;
        protected string imagem;
     
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string NomeProduto
        {
            get
            {
                return nomeProduto;
            }
            set
            {
                nomeProduto = value;

            } 

        }
        public string Status
        {
            get 
            { 
             return status;
            }
            set
            {
                status = value;
            }
        }
        public int? Quantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value;
            }
        }
        public int? FazendaId
        {
            get
            {
                return fazendaId;
            }
            set
            {
                fazendaId = value;
            }
        }
        public string NomePlantio
        {
            get
            {
                return nomePlantio;
            }
            set
            {
                nomePlantio = value;
            }
        }
        public DateTime? DataPlantacao
        {
            get
            {
                return dataPlantacao;
            }
            set
            {
                dataPlantacao = value;
            }
        }
        public DateTime? DataColheita
        {
            get
            {
                return dataColheita;
            }
            set
            {
                dataColheita = value;

            }
        }
        
        public string Imagem
        {
            get
            {
                return imagem;
            }
            set
            {
                imagem = value;
            }
        }
        




    }
   
}

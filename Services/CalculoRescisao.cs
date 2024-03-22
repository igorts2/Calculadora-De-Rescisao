using calculo_de_rescisão.Models;
using Microsoft.Extensions.Options;
using System.Data;

namespace calculo_de_rescisão.Services
{
    
    public class CalculoRescisao
    {
        
        
        public int DiasTrabalhados(Rescisao rescisao)
        {
            if (rescisao.DataFinal < rescisao.DataInicio)
            {
                return 0;
            }
            int dias = (rescisao.DataFinal - rescisao.DataInicio).Days + 1;

            return dias;
            
        }
        public int MesesTrabalhados(Rescisao rescisao) 
        {
            int meses = (rescisao.DataFinal.Year - rescisao.DataInicio.Year) * 12 + rescisao.DataFinal.Month - rescisao.DataInicio.Month;
            return meses;
        }
        public int AnosTrabalhados(Rescisao rescisao) 
        {
            int anos = rescisao.DataFinal.Year - rescisao.DataInicio.Year;
            return anos;
        }
        
        public double SaldoDoSalario(Rescisao rescisao) //ok
        {

            if (rescisao.DataFinal.Day > 0)
            {
                double saldo = (rescisao.Salario / 30) * rescisao.DataFinal.Day;

                return saldo;
            }
            else 
            {
                return 0;
            }
            
        }
        public double AvisoPrevio(Rescisao rescisao) //ok
        {
            if (rescisao.Motivo == "Demissão com justa causa" || rescisao.Motivo == "Pediu demissão")
            {
                return 0;
            }
            if (rescisao.Aviso == "indenizado")
            {
                int anosTrabalhados = AnosTrabalhados(rescisao);
                double valorIndenizado = ((double)anosTrabalhados / 12) * rescisao.Salario;
                return valorIndenizado;
                
            }
            else
            {
                double valorTrabalhado = rescisao.Salario;
                return valorTrabalhado;
            }
        }
        public double FeriasProporcionais(Rescisao rescisao) //ok
        {
            int mesesTrabalhados = MesesTrabalhados(rescisao);
            
            if (rescisao.Ferias == "sim")
            {
                double valorFerias = rescisao.Salario + (rescisao.Salario / 3.0);
                return valorFerias;
            }
            else
            {
                double valorFerias = (rescisao.Salario / 12) * mesesTrabalhados;
                return valorFerias;
            }
            
        }
        public double DecimoTerceiro(Rescisao rescisao) //ok
        {
           
            int mesesTrabalhados = MesesTrabalhados(rescisao);
            if (rescisao.DataInicio.Year == rescisao.DataFinal.Year)
            {
                double decimoTerceiro = (rescisao.Salario / 12) * mesesTrabalhados;
                return decimoTerceiro;
                
            }
            else
            {
                double decimoTerceiro = (rescisao.Salario / 12) * rescisao.DataFinal.Month;
                return decimoTerceiro;
            }
            
        }
        public double FGTS(Rescisao rescisao) //ok
        {
            int mesesTrabalhados = MesesTrabalhados(rescisao);
            double valorDepositado = (rescisao.Salario * 0.08) * mesesTrabalhados;
            if (rescisao.Motivo == "Demissão com justa causa" || rescisao.Motivo == "Pediu demissão")
            {
                
                return valorDepositado;
            }
            else
            {
                double multaRescisoria = valorDepositado * 0.4;
                double valorFGTS = valorDepositado + multaRescisoria;
                return valorFGTS;
            }
            
            
        }



    }
}
